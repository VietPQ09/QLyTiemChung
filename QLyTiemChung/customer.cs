using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyTiemChung
{
    internal class customer
    {
        private string _MaKH;
        private string _TenKH;
        private DateTime _NgSinh;
        private string _GT;
        private string _Diachi;
        private string _Sdt;
        private string _NgGH;

        public customer() { }
        public customer(string maKH, string tenKH, DateTime ngSinh, string gT, string diachi, string sdt, string ngGH)
        {
            _MaKH = maKH;
            _TenKH = tenKH;
            _NgSinh = ngSinh;
            _GT = gT;
            _Diachi = diachi;
            _Sdt = sdt;
            _NgGH = ngGH;
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public DateTime NgSinh { get => _NgSinh; set => _NgSinh = value; }
        public string GT { get => _GT; set => _GT = value; }
        public string Diachi { get => _Diachi; set => _Diachi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public string NgGH { get => _NgGH; set => _NgGH = value; }
    }
}
