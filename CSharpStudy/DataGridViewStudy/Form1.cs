using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridViewStudy
{
    public partial class Form1 : Form
    {
        private List<Info> listInfo;
        public Form1()
        {
            InitializeComponent();
            InitializeInfo();
            foreach (Info info in listInfo)
            {
                this.dataGridView1.Rows.Add(info.No, info.Name, info.Gender, info.DelBtn);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataGridView1.Columns["DelBtn"].Index)
            {
                if (MessageBox.Show("削除しますか?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeInfo()
        {
            List<Info> listInfo = new List<Info>();
            listInfo.Add(new Info(1, "Munk", "女", "削除"));
            listInfo.Add(new Info(2, "Toan", "男", "削除"));
            listInfo.Add(new Info(3, "Bung", "男", "削除"));
            listInfo.Add(new Info(4, "Hjue", "女", "削除"));
            this.listInfo = listInfo;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VKL", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
