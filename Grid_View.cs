using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6
{
    public partial class Grid_View : Form
    {

        public Grid_View()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != null && txt_Name.Text.Length >= 3)
            {
                int inp;
                bool flag = int.TryParse(txt_Phone.Text, out inp);

                if (flag == false)
                {
                    MessageBox.Show("Phone Must be Number...");
                }
                else
                {
                    dataGridView1.Rows.Add(txt_Name.Text,txt_Phone.Text,Birth_Date_Time.Text);
                }
            }
            else
            {
                MessageBox.Show("The Name Must be More Than Three Charaters..");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Must be DataBase...");
        }
    }
}
