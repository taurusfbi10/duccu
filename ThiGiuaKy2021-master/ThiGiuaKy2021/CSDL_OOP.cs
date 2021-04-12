using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThiGiuaKy2021
{
    class CSDL_OOP
    {
        public static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDL_OOP();
                return _Instance;
            }
            private set { }
        }
        private CSDL_OOP() { }
        public List<KhuVuc> GetAllKV()
        {
            List<KhuVuc> data = new List<KhuVuc>();
            foreach (DataRow r in CSDL.Instance.DataKhuVuc.Rows)
            {
                data.Add(new KhuVuc()
                {
                    ID_KV = Convert.ToInt32(r["ID_KV"]),
                    DiaChi = r["DiaChi"].ToString()
                });
            }
            return data;
        }
        public List<Kho> GetAllKho()
        {
            List<Kho> data = new List<Kho>();
            foreach (DataRow r in CSDL.Instance.DataKho.Rows)
            {
                data.Add(new Kho()
                {
                    ID_Kho = Convert.ToInt32(r["ID_Kho"]),
                    Ten = r["Ten"].ToString(),
                    DienTich = Convert.ToDouble(r["DienTich"]),
                    TrangThai = r["TrangThai"].ToString(),
                    ID_KV = Convert.ToInt32(r["ID_KV"])
                });
            }
            return data;
        }
        public List<Kho> GetListKho(int id)
        {
            List<Kho> data = new List<Kho>();
            foreach (Kho i in CSDL_OOP.Instance.GetAllKho())
            {
                if ((i.ID_KV == id || id == 0))
                    data.Add(i);
            }
            return data;
        }
        public Kho GetKhoByID(int IDKho)
        {
            foreach (Kho i in CSDL_OOP.Instance.GetAllKho())
                if (i.ID_Kho == IDKho)
                    return i;
            return null;
        }
        public void AddKho(Kho k)
        {
            CSDL.Instance.AddNewKho(k);
        }
        public void EditKho(Kho k)
        {
            CSDL.Instance.EditKho(k);
        }
        public bool DeleteKhobyID(int IDKho)
        {
            List<Kho> listkho = new List<Kho>();
            foreach (DataRow r in CSDL.Instance.DataKho.Rows)
            {
                listkho.Add(new Kho()
                {
                    ID_Kho = Convert.ToInt32(r["ID_Kho"]),
                    Ten = r["Ten"].ToString(),
                    DienTich = Convert.ToDouble(r["DienTich"]),
                    TrangThai = r["TrangThai"].ToString(),
                    ID_KV = Convert.ToInt32(r["ID_KV"])
                });
            }
            foreach (var i in listkho)
            {
                if (i.ID_Kho == IDKho)
                {
                    listkho.Remove(i);
                    break;
                }
            }
            return true;
        }
    }
}
