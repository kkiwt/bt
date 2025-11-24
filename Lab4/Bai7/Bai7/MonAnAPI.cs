
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bai7
{
    public class MonAnAPI
    {
        private readonly string BaseUrl = "https://nt106.uitiot.vn/";
        private readonly HttpClient client;

        public MonAnAPI(string token)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }
        // 1. Tạo món ăn
        public async Task<string> AddMonAnAsync(string tenMonAn, double gia, string moTa, string hinhAnh, string diaChi)
        {
            var monAnData = new
            {
                ten_mon_an = tenMonAn,
                gia = gia,
                mo_ta = moTa,
                hinh_anh = hinhAnh,
                dia_chi = diaChi
            };

            var json = JsonSerializer.Serialize(monAnData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(BaseUrl + "api/v1/monan/add", content);
            return await response.Content.ReadAsStringAsync();
        }

        // 2. Lấy tất cả món ăn

        // 2. Lấy tất cả món ăn
        public async Task<string> GetAllMonAnAsync(int current = 1, int pageSize = 5)
        {
            var body = new { current, pageSize };
            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(BaseUrl + "api/v1/monan/all", content);
            return await response.Content.ReadAsStringAsync();
        }

        // 3. Lấy món ăn của user hiện tại
        public async Task<string> GetMyDishesAsync(int current = 1, int pageSize = 5)
        {
            var body = new { current, pageSize };
            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(BaseUrl + "api/v1/monan/my-dishes", content);
            return await response.Content.ReadAsStringAsync();
        }

        // 4. Lấy chi tiết món ăn theo ID
        public async Task<string> GetMonAnByIdAsync(int id)
        {
            var response = await client.GetAsync(BaseUrl + $"api/v1/monan/{id}");
            return await response.Content.ReadAsStringAsync();
        }

        // 5. Cập nhật món ăn
        public async Task<string> UpdateMonAnAsync(int id, object monAnData)
        {
            var json = JsonSerializer.Serialize(monAnData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(BaseUrl + $"api/v1/monan/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }

        // 6. Xóa món ăn
        public async Task<string> DeleteMonAnAsync(int id)
        {
            var response = await client.DeleteAsync(BaseUrl + $"api/v1/monan/{id}");
            return await response.Content.ReadAsStringAsync();
        }
    }

 

}

