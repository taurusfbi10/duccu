
namespace ThiGiuaKy2021
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchbtn = new System.Windows.Forms.Button();
            this.kvcbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.delbtn = new System.Windows.Forms.Button();
            this.sortbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showbtn = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(664, 24);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 0;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // kvcbb
            // 
            this.kvcbb.FormattingEnabled = true;
            this.kvcbb.Location = new System.Drawing.Point(117, 21);
            this.kvcbb.Name = "kvcbb";
            this.kvcbb.Size = new System.Drawing.Size(226, 24);
            this.kvcbb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khu Vuc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.delbtn);
            this.groupBox1.Controls.Add(this.sortbtn);
            this.groupBox1.Controls.Add(this.editbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.showbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 356);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sach Kho";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(612, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(367, 318);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 5;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // sortbtn
            // 
            this.sortbtn.Location = new System.Drawing.Point(499, 318);
            this.sortbtn.Name = "sortbtn";
            this.sortbtn.Size = new System.Drawing.Size(75, 23);
            this.sortbtn.TabIndex = 4;
            this.sortbtn.Text = "Sort";
            this.sortbtn.UseVisualStyleBackColor = true;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(240, 318);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 3;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(128, 318);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(26, 318);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 0;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(460, 25);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(173, 22);
            this.txtsearch.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kvcbb);
            this.Controls.Add(this.searchbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.ComboBox kvcbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sortbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button delbtn;
    }
}

