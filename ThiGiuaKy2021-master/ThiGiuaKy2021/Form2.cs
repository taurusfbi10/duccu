using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiGiuaKy2021
{
    
    public partial class Form2 : Form
    {
        public delegate void MyDel(int id);
        public MyDel del;
        private int IDKho;
        public Form2(int ID_Kho)
        {
            InitializeComponent();
            IDKho = ID_Kho;
            SetKVCBB();
            SetInfor();
        }
        public void SetKVCBB()
        {
            foreach (KhuVuc i in CSDL_OOP.Instance.GetAllKV())
            {
                idkvcbb.Items.Add(i);
            }
        }
        public void SetInfor()
        {
            Kho kho = CSDL_OOP.Instance.GetKhoByID(IDKho);
            if (kho != null)
            {
                txtidkho.Text = (kho.ID_Kho).ToString();
                txttenkho.Text = kho.Ten;
                if (kho.TrangThai == "Full")
                    fullrdo.Checked = true;
                if (kho.TrangThai == "Not Full")
                    notfullrdo.Checked = true;
                if (kho.TrangThai == "KHD")
                    khdrdo.Checked = true;
                txtdientich.Text = (kho.DienTich).ToString();
                foreach (var i in idkvcbb.Items)
                {
                    if (((KhuVuc)i).ID_KV == kho.ID_KV)
                    {
                        idkvcbb.SelectedItem = i;
                        break;
                    }
                }
            }
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            Kho k = new Kho();
            try
            {
                k = new Kho()
                {
                    ID_Kho = Convert.ToInt32(txtidkho.Text),
                    Ten = txttenkho.Text,
                    DienTich = Convert.ToInt32(txtdientich.Text),
                    TrangThai = fullrdo.Checked == true ? "Full" : notfullrdo.Checked == true ? "Not full" : "HRD",
                    ID_KV = ((KhuVuc)idkvcbb.SelectedItem).ID_KV
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nhap du thong tin", "Thong bao");
            }
            if (CSDL_OOP.Instance.GetKhoByID(k.ID_Kho) == null)
            {
                CSDL_OOP.Instance.AddKho(k);
            } 
            else
            {
                CSDL_OOP.Instance.EditKho(k);
            }
            del(k.ID_KV);
            this.Dispose();
        }
    }
}