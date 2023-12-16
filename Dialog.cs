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
    public partial class Dialog : Form
    {
        Form_Format form_Format;
        public Dialog(Form_Format form_)
        {
            InitializeComponent();
            form_Format = form_;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Format_Click(object sender, EventArgs e)
        {

            int inp;
            bool flag = int.TryParse(Size_text.Text, out inp);

            if (flag == false)
            {
                MessageBox.Show("Value Must be Int...");
            }
            else
            {
                
    

            if (Red_Color.Checked)
            {
                form_Format.color = Color.Red;
            }
            if (Green_Color.Checked)
            {
                form_Format.color = Color.Green;
            }
            if (Blue_Color.Checked)
            {
                form_Format.color = Color.Blue;
            }







             form_Format.font = new Font(Dialog_Font.SelectedItem.ToString(), int.Parse(Size_text.Text));





            if (Bold_Format.Checked)
                form_Format.font = new Font(Dialog_Font.SelectedItem.ToString(), int.Parse(Size_text.Text), FontStyle.Bold);

            if (Italic_Format.Checked)
                form_Format.font = new Font(Dialog_Font.SelectedItem.ToString(), int.Parse(Size_text.Text), FontStyle.Italic);

            if (UnderLine_Format.Checked)
                form_Format.font = new Font(Dialog_Font.SelectedItem.ToString(), int.Parse(Size_text.Text), FontStyle.Underline);
 

                this.Close();
                form_Format.Show();


            }

        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            Dialog_Font.SelectedIndex = 0;
        }
    }
}
