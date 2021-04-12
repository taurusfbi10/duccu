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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetKVCBB();
        }
        public void SetKVCBB()
        {
            kvcbb.Items.Add(new KhuVuc() { ID_KV = 0, DiaChi = "All" });
            foreach (KhuVuc i in CSDL_OOP.Instance.GetAllKV())
            {
                kvcbb.Items.Add(i);
            }
        }
        public void Show(int id)
        {
            dataGridView1.DataSource = CSDL_OOP.Instance.GetListKho(id);
        }
        private void showbtn_Click(object sender, EventArgs e)
        {
            if (kvcbb.SelectedIndex != -1)
            {
                Show(((KhuVuc)kvcbb.SelectedItem).ID_KV);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(0);
            f2.del = new Form2.MyDel(Show);
            f2.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (kvcbb.SelectedIndex != -1 || (kvcbb.SelectedItem).ToString() == txtsearch.Text)
            {
                int id = Convert.ToInt32(txtsearch.Text);
                Show(id);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                Form2 f2 = new Form2(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Kho"].Value.ToString()));
                f2.del = new Form2.MyDel(Show);
                f2.Show();
            }    
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
