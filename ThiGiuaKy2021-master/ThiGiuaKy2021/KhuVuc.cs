using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGiuaKy2021
{
    class KhuVuc
    {
        public int ID_KV { get; set; }
        public string DiaChi { get; set; }
        public override string ToString()
        {
            return DiaChi;
        }
    }
}
