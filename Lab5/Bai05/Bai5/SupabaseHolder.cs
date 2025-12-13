
using System.Threading.Tasks;
using Supabase;

namespace Bai7
{

    public static class Globals
    {

        public static readonly string SupabaseUrl = "https://txttykfbpifhdokssxpg.supabase.co";
        public static readonly string SupabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InR4dHR5a2ZicGlmaGRva3NzeHBnIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjQ4MjQ2MzAsImV4cCI6MjA4MDQwMDYzMH0.ZORPXfACyOaKcMr3p73Xm-ENpuvpS7iPAhTJuCmXXsE";


    }
    public static class SupabaseHolder
    {
        public static Client Client { get; private set; }
        private static bool _initialized = false;
        private static readonly object _lock = new object();

        public static async Task InitializeAsync()
        {
            // Đảm bảo thread-safe nếu nhiều nơi cùng gọi
            if (_initialized && Client != null) return;

            lock (_lock)
            {
                if (_initialized && Client != null) return;
            }


            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true,
                AutoRefreshToken = true,

            };

            var client = new Supabase.Client(Globals.SupabaseUrl, Globals.SupabaseKey, options);
            await client.InitializeAsync();

            SupabaseHolder.Client = client;


            lock (_lock)
            {
                Client = client;
                _initialized = true;
            }
        }
    }
}
