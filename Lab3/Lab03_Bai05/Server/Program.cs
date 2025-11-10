using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Data.SQLite;
using System.IO;

namespace Server
{
    public class MonAn 
    { 
        public int IDMA { get; set; }
        public string TenMon { get; set; }
        public string HinhAnh { get; set; }
        public string TenNguoiDongGop { get; set; }
        public string IDNCC { get; set; }

    }

    public class NguoiDung
    {
        public string IDNCC { get; set; }
        public string HoVaTen { get; set; }
        public string QuyenHan { get; set; }
    }

    public class SQLManager
    {
        private readonly string connectionStr;

        public SQLManager(string connectionString)
        {
            this.connectionStr = connectionString;
        }

        public bool ThemMonAn(MonAn mon, NguoiDung nguoi)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionStr))
                {
                    connection.Open();
                    string insertNguoi = "INSERT OR IGNORE INTO NguoiDung (HoVaTen, QuyenHan, IDNCC) VALUES (@ten, @quyen, @IDNCC); SELECT last_insert_rowid();";
                    using (var cmdInsert = new  SQLiteCommand(insertNguoi, connection))
                    {
                        cmdInsert.Parameters.AddWithValue("@ten", mon.TenNguoiDongGop);

                        cmdInsert.Parameters.AddWithValue("@quyen", nguoi.QuyenHan);

                        cmdInsert.Parameters.AddWithValue("@IDNCC", nguoi.IDNCC);
                        cmdInsert.ExecuteNonQuery(); // Chỉ thực thi INSERT, không lấy ID
                    }

                    string insertMonAn = "INSERT INTO MonAn (TenMon, HinhAnh, IDNCC) VALUES (@Ten, @HinhAnh, @IDNCC)";
                    using (var command = new SQLiteCommand(insertMonAn, connection))
                    {
                        command.Parameters.AddWithValue("@Ten", mon.TenMon);
                        command.Parameters.AddWithValue("@HinhAnh", mon.HinhAnh);
                        command.Parameters.AddWithValue("@IDNCC", nguoi.IDNCC);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi, Không thể thêm món: {ex.Message}");
                return false;
            }
        }


        public MonAn GetMonNgauNhien(string idncc, bool isCaNhan)
        {
            MonAn result = null;
            try
            {
                using (var connection = new SQLiteConnection(connectionStr))
                {
                    connection.Open();

                    string whereClause = isCaNhan ? "WHERE m.IDNCC = @IDNCC" : "";
                    string sqlQuery = $@"
                    SELECT m.TenMon, m.HinhAnh, n.HoVaTen 
                    FROM MonAn m
                    JOIN NguoiDung n ON m.IDNCC = n.IDNCC
                    {whereClause} 
                    ORDER BY RANDOM() LIMIT 1";

                    using (var command = new SQLiteCommand(sqlQuery, connection))
                    {
                        if (isCaNhan)
                            command.Parameters.AddWithValue("@IDNCC", idncc);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = new MonAn
                                {
                                    TenMon = reader.GetString(0),
                                    HinhAnh = reader.GetString(1),
                                    TenNguoiDongGop = reader.GetString(2)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[DB ERROR] Ngẫu nhiên: {ex.Message}");
            }
            return result;
        }
    }
    internal class Program
    {
        static TcpListener server;
        static string db = "Data Source=Food.db";
        const int PORT = 1111;
        static void Main(string[] args)
        {
            InitDataBase();
            Console.WriteLine("DataBase is ready");

            try
            {
                server = new TcpListener(IPAddress.Any, PORT);
                server.Start();
                Console.WriteLine($"Server is running on port {PORT}....");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("New Client Connected.");

                    Task.Run(() => HandleClient(client));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Server Error: " + ex.Message);
            }
        }

        static void InitDataBase()
        {
            using (var connection = new SQLiteConnection(db))
            {
                connection.Open();

                string CreateNguoiDung = @"
                    CREATE TABLE IF NOT EXISTS NguoiDung(
                        IDNCC TEXT PRIMARY KEY,
                        HoVaTen TEXT,
                        QuyenHan TEXT);";

                string CreateMonAn = @"
                    CREATE TABLE IF NOT EXISTS MonAn(
                         IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                            TenMon TEXT,
                            HinhAnh TEXT,
                            IDNCC INTEGER,
                            FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                        );";

                using (var command = new SQLiteCommand(CreateNguoiDung, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (var command = new SQLiteCommand(CreateMonAn, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void HandleClient(TcpClient client)
        {
            var dbManager = new SQLManager(db);

            try
            {
                using (var stream = client.GetStream())
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                using (var writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true })
                {
                    string request;
                    while ((request = reader.ReadLine()) != null)
                    {
                        Console.WriteLine("Received: " + request);

                        string response = ProcessRequest(request, dbManager);

                        writer.WriteLine(response);
                        Console.WriteLine("Sent: " + response);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi xử lý Client: {ex.Message}");
            }
            finally
            {
                client.Close();
                Console.WriteLine("Client đã ngắt kết nối.");
            }
        }

        private static string ProcessRequest(string request, SQLManager dbConnection)
        {
            string[] path = request.Split('|');
            if (path.Length == 0)
            {
                return "Yêu cầu không hợp lệ";
            }

            string action = path[0].ToUpper();

            try
            {
                switch (action)
                {
                    case "THEM_MON":
                        if (path.Length < 6)
                        {
                            return "Lỗi, vui lòng nhập đầy đủ thông tin";
                        }

                        bool check = dbConnection.ThemMonAn(new MonAn
                        {
                            TenNguoiDongGop = path[1],
                            TenMon = path[2],
                            HinhAnh = path[3]
                        }, new NguoiDung
                        {
                            QuyenHan = path[4],
                            IDNCC = path[5]
                        });
                        return check ? "OK|Thêm món ăn thành công" : "ERROR|Thêm món ăn thất bại";

                    case "CHON_MON":
                        if (path.Length < 2)
                        {
                            return "Lỗi, vui lòng chọn lại.";
                        }

                        string type = path[1].ToUpper();
                        string idncc_rand = (type == "CANHAN" && path.Length > 2) ? path[2] : string.Empty;

                        bool isCaNhan = (type == "CANHAN");

                        var monAn = dbConnection.GetMonNgauNhien(idncc_rand, isCaNhan);

                        if (monAn != null)
                        { 
                            return $"OK|{monAn.TenMon}|{monAn.HinhAnh}|{monAn.TenNguoiDongGop}";
                        }
                        return "ERROR|Khong tim thay mon.";

                    default:
                        return $"ERROR|Hanh dong khong xac dinh: {action}";
                }
            }
            catch (Exception ex)
            {
                return $"ERR|Loi xu ly Server: {ex.Message}";
            }

        }
    }
        
}
