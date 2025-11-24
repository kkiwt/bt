using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bai7
{
    public class AuthAPI
    {
        private readonly string BaseUrl = "https://nt106.uitiot.vn/";

        // Lấy token
        public async Task<string> GetTokenAsync(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = new { username = username, password = password };
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(BaseUrl + "auth/token", content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        // Refresh token
        public async Task<string> RefreshTokenAsync(string refreshToken)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = new { refresh = refreshToken };
                var json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(BaseUrl + "auth/refresh", content);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
