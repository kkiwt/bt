using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bai7
{
    public class UserAPI
    {
        private readonly string BaseUrl = "https://nt106.uitiot.vn/";
        private readonly HttpClient client;

        public UserAPI(string token)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        // Tạo user
        public async Task<string> SignupAsync(object userData)
        {
            var json = JsonSerializer.Serialize(userData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(BaseUrl + "api/v1/user/signup", content);
            return await response.Content.ReadAsStringAsync();
        }

        // Lấy thông tin user hiện tại
        public async Task<string> GetCurrentUserAsync()
        {
            var response = await client.GetAsync(BaseUrl + "api/v1/user/me");
            return await response.Content.ReadAsStringAsync();
        }

        // Lấy tất cả user (superuser)
        public async Task<string> GetAllUsersAsync()
        {
            var response = await client.PostAsync(BaseUrl + "api/v1/user/all", null);
            return await response.Content.ReadAsStringAsync();
        }

        // Lấy user theo username
        public async Task<string> GetUserByUsernameAsync(string username)
        {
            var response = await client.GetAsync(BaseUrl + $"api/v1/user/{username}");
            return await response.Content.ReadAsStringAsync();
        }

        // Lấy user theo ID
        public async Task<string> GetUserByIdAsync(int id)
        {
            var response = await client.GetAsync(BaseUrl + $"api/v1/user/id/{id}");
            return await response.Content.ReadAsStringAsync();
        }

        // Xóa user theo username
        public async Task<string> DeleteUserByUsernameAsync(string username)
        {
            var response = await client.DeleteAsync(BaseUrl + $"api/v1/user/{username}");
            return await response.Content.ReadAsStringAsync();
        }

        // Xóa user theo ID
        public async Task<string> DeleteUserByIdAsync(int id)
        {
            var response = await client.DeleteAsync(BaseUrl + $"api/v1/user/id/{id}");
            return await response.Content.ReadAsStringAsync();
        }

        // Cập nhật user theo username
        public async Task<string> UpdateUserByUsernameAsync(string username, object userData)
        {
            var json = JsonSerializer.Serialize(userData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(BaseUrl + $"api/v1/user/{username}", content);
            return await response.Content.ReadAsStringAsync();
        }

        // Cập nhật user theo ID
        public async Task<string> UpdateUserByIdAsync(int id, object userData)
        {
            var json = JsonSerializer.Serialize(userData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(BaseUrl + $"api/v1/user/id/{id}", content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
