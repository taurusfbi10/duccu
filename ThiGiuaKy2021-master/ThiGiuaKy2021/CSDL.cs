using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGiuaKy2021
{
    class CSDL
    {
        public DataTable DataKho { get; set; }
        public DataTable DataKhuVuc { get; set; }
        public static CSDL _Instance;
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDL();
                return _Instance;
            }
            private set { }
        }
        private CSDL()
        {
            DataKho = new DataTable();
            DataKho.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Kho", typeof(int)),
                new DataColumn("Ten", typeof(string)),
                new DataColumn("DienTich", typeof(double)),
                new DataColumn("TrangThai", typeof(string)),
                new DataColumn("ID_KV", typeof(int))
            });
            DataKhuVuc = new DataTable();
            DataKhuVuc.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_KV",typeof(int)),
                new DataColumn("DiaChi",typeof(string))
            });
            DataKhuVuc.Rows.Add(NewRowKV(new KhuVuc()
            {
                ID_KV = 1,
                DiaChi = "Hue",
            }));
            DataKhuVuc.Rows.Add(NewRowKV(new KhuVuc()
            {
                ID_KV = 2,
                DiaChi = "Da Nang",
            }));
            DataKhuVuc.Rows.Add(NewRowKV(new KhuVuc()
            {
                ID_KV = 3,
                DiaChi = "Ha Noi",
            }));
            DataKho.Rows.Add(NewRowKho(new Kho()
            {
                ID_Kho = 1,
                Ten = "Kho 1",
                DienTich = 500,
                TrangThai = "Full",
                ID_KV = 1
            }));
            DataKho.Rows.Add(NewRowKho(new Kho()
            {
                ID_Kho = 2,
                Ten = "Kho 2",
                DienTich = 600,
                TrangThai = "Full",
                ID_KV = 1
            }));
            DataKho.Rows.Add(NewRowKho(new Kho()
            {
                ID_Kho = 3,
                Ten = "Kho 3",
                DienTich = 700,
                TrangThai = "Full",
                ID_KV = 2
            }));
            DataKho.Rows.Add(NewRowKho(new Kho()
            {
                ID_Kho = 4,
                Ten = "Kho 4",
                DienTich = 800,
                TrangThai = "Not Full",
                ID_KV = 3
            }));
            DataKho.Rows.Add(NewRowKho(new Kho()
            {
                ID_Kho = 5,
                Ten = "Kho 5",
                DienTich = 400,
                TrangThai = "KHD",
                ID_KV = 3
            }));

        }
        public DataRow NewRowKho(Kho kho)
        {
            DataRow r = DataKho.NewRow();
            r["ID_Kho"] = kho.ID_Kho;
            r["Ten"] = kho.Ten;
            r["DienTich"] = kho.DienTich;
            r["TrangThai"] = kho.TrangThai;
            r["ID_KV"] = kho.ID_KV;
            return r;
        }
        public DataRow NewRowKV(KhuVuc kv)
        {
            DataRow r = DataKhuVuc.NewRow();
            r["ID_KV"] = kv.ID_KV;
            r["DiaChi"] = kv.DiaChi;
            return r;
        }
        
        public void AddNewKho(Kho kho)
        {
            DataKho.Rows.Add(NewRowKho(kho));
        }
        public void EditKho(Kho kho)
        {
            foreach(DataRow r in DataKho.Rows)
            {
                if (Convert.ToInt32(r["ID_Kho"].ToString()) == kho.ID_Kho)
                {
                    r["Ten"] = kho.Ten;
                    r["DienTich"] = kho.DienTich;
                    r["TrangThai"] = kho.TrangThai;
                    r["ID_KV"] = kho.ID_KV;
                }
            }
        }
        public void SetDataKho(List<Kho> l)
        {
        }
    }
}
