
// SupabaseModel.cs
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace Bai7
{
    [Table("monan")]
    public class MonAnModel : BaseModel
    {
        [PrimaryKey("id", false)] public string Id { get; set; }

        [Column("ten_mon_an")] public string TenMonAn { get; set; }


        [Column("gia")] public int Gia { get; set; }

        [Column("mo_ta")] public string MoTa { get; set; }

        [Column("hinh_anh")] public string HinhAnh { get; set; }

        [Column("dia_chi")] public string DiaChi { get; set; }

        [Column("nguoi_dong_gop")] public string NguoiDongGop { get; set; }

        [Column("ngay_them")] public DateTime? NgayThem { get; set; }


    }
}
