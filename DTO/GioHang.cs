using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Table(Name = "GioHang")]
    public class GioHang
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public string Ma_gio_hang { get; set; }
        [Column]
        public string Ma_Khach_Hang {  get; set; }
        [Column]
        public string Trang_Thai { get; set; }
        [Column]
        public string Ma_NV {  get; set; }
    }
}
