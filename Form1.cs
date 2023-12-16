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
    public partial class Form_Format : Form
    {
        public Font font
        {
            get { return txt_Format.Font; }
            set { txt_Format.Font = value; }
        }

        public Color color
        {
            get {return txt_Format.ForeColor;}
            set { txt_Format.ForeColor = value;} 
        }
        public Size size
        {
            get { return txt_Format.Size; }
            set { txt_Format.Size = value;}
        }
        public Form_Format()
        {
            InitializeComponent();
        }

        private void Format_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog(this);
            if (txt_Format.Text.Length>=1)
            {
                dialog.Show();
                //txt_Format.ForeColor = color;
            }
            else
            {
                MessageBox.Show("Enter any Text...");
            }
 

        }
    }
}
