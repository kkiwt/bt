using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Lab2

{
    // Lớp cho Người Đóng Góp
    public class NguoiDung
    {
        public int IDNCC { get; set; }
        public string HoVaTen { get; set; }
        public string QuyenHan { get; set; }
    }


    public class MonAn
    {
        public int IDMA { get; set; }
        public string TenMonAn { get; set; }
        public string HinhAnh { get; set; } // Đường dẫn đến file ảnh
        public int IDNCC { get; set; }
        public string TenNguoiDongGop { get; set; } // Dùng cho truy vấn JOIN
    }

    public static class DataAccess
    {
        private const string ConnectionString = "Data Source=MonAnMoiDB.sqlite";

        // Tạo Database và các Bảng
        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                // Tạo bảng
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS NguoiDung (
                        IDNCC INTEGER PRIMARY KEY,
                        HoVaTen TEXT NOT NULL,
                        QuyenHan TEXT
                    );";
                command.ExecuteNonQuery();


                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS MonAn (
                        IDMA INTEGER PRIMARY KEY,
                        TenMonAn TEXT NOT NULL,
                        HinhAnh TEXT,
                        IDNCC INTEGER,
                        FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC)
                    );";
                command.ExecuteNonQuery();


                InsertSampleData(connection);
            }
        }

        private static void InsertSampleData(SQLiteConnection connection)
        {
            // Kiểm tra xem đã có người dùng chưa
            var checkUserCmd = connection.CreateCommand();
            checkUserCmd.CommandText = "SELECT COUNT(*) FROM NguoiDung";
            if (Convert.ToInt32(checkUserCmd.ExecuteScalar()) == 0)
            {
                var insertUserCmd = connection.CreateCommand();
                insertUserCmd.CommandText = @"
                    INSERT INTO NguoiDung (IDNCC, HoVaTen, QuyenHan) VALUES 
                    (1, 'Kiet', 'Admin'),
                    (2, 'Nguyen', 'User'),
                    (3, 'Tuan', 'User');";
                insertUserCmd.ExecuteNonQuery();

                var insertFoodCmd = connection.CreateCommand();
                insertFoodCmd.CommandText = @"
                    INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES 
                    ('Bún riêu', 'bunrieu.jpg', 1),
                    ('Cơm tấm sườn trứng', 'comtam.jpg', 1),
                    ('Phở bò', 'pho.jpg', 2),
                    ('Gỏi cuốn', 'goicuon.jpg', 2),
                    ('Bánh mì', 'banhmi.jpg', 3);";
                insertFoodCmd.ExecuteNonQuery();
            }
        }

        public static List<MonAn> LoadMonAn()
        {
            var MonAns = new List<MonAn>();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        MA.IDMA, MA.TenMonAn, MA.HinhAnh, MA.IDNCC, ND.HoVaTen 
                    FROM MonAn AS MA
                    JOIN NguoiDung AS ND ON MA.IDNCC = ND.IDNCC
                    ORDER BY MA.TenMonAn;";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MonAns.Add(new MonAn
                        {
                            IDMA = reader.GetInt32(0),
                            TenMonAn = reader.GetString(1),
                            HinhAnh = reader.GetString(2),
                            IDNCC = reader.GetInt32(3),
                            TenNguoiDongGop = reader.GetString(4)
                        });
                    }
                }
            }
            return MonAns;
        }

       
        public static MonAn GetRandomMonAn()
        {
            MonAn monAn = null;
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT 
                        MA.IDMA, MA.TenMonAn, MA.HinhAnh, MA.IDNCC, ND.HoVaTen 
                    FROM MonAn AS MA
                    JOIN NguoiDung AS ND ON MA.IDNCC = ND.IDNCC
                    ORDER BY RANDOM() LIMIT 1;"; // Truy vấn SQLite ngẫu nhiên

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        monAn = new MonAn
                        {
                            IDMA = reader.GetInt32(0),
                            TenMonAn = reader.GetString(1),
                            HinhAnh = reader.GetString(2),
                            IDNCC = reader.GetInt32(3),
                            TenNguoiDongGop = reader.GetString(4)
                        };
                    }
                }
            }
            return monAn;
        }

        // Thêm món ăn
        public static void AddMonAn(string TenMonAn, string HinhAnh, int idNcc)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) 
                    VALUES (@TenMonAn, @HinhAnh, @IDNCC);";

                command.Parameters.AddWithValue("@TenMonAn", TenMonAn);
                command.Parameters.AddWithValue("@HinhAnh", HinhAnh);
                command.Parameters.AddWithValue("@IDNCC", idNcc);
                command.ExecuteNonQuery();
            }
        }

        public static int GetOrCreateNguoiDungId(string tenNguoi)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // Tìm kiếm người đóng góp nếu như người thêm món ăn là cùng 1 người
                var findCmd = connection.CreateCommand();
                findCmd.CommandText = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @Ten";
                findCmd.Parameters.AddWithValue("@Ten", tenNguoi);
                object result = findCmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result); // Trả về ID nếu tìm thấy
                }

                // Nếu không tìm thấy, thêm người dùng mới
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText = @"
            INSERT INTO NguoiDung (HoVaTen, QuyenHan) 
            VALUES (@Ten, 'User');
            SELECT last_insert_rowid();";
                insertCmd.Parameters.AddWithValue("@Ten", tenNguoi);

                long newId = (long)insertCmd.ExecuteScalar();
                return (int)newId;
            }
        }


        public static void DeleteMonAn(int idMa)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM MonAn WHERE IDMA = @IDMA;";
                command.Parameters.AddWithValue("@IDMA", idMa);
                command.ExecuteNonQuery();
            }
        }
    }
}