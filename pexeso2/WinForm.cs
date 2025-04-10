using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pexeso2
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();

        }

        private void ano_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void ne_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
            this.Close();
        }

        private void WinForm_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int hura_width = (int)(0.6*formWidth);
            int hura_height = formHeight / 2;

            int hura_x = (int)(0.2*formWidth);
            int hura_y = (int)(0.01* formHeight);

            int dalsi_x = (int)(0.24 * formWidth);
            int dalsi_y = (int)(0.4 * formHeight);

            int dalsi_width = formWidth / 2;
            int dalsi_height = formHeight / 3;

            int ano_width = (int)(0.3*formWidth);
            int ano_height = (int)(0.3*formHeight);

            int ano_x = (int)(0.05 * formWidth);
            int ano_y = (int)(0.7 * formHeight);

            int ne_width = (int)(0.3 * formWidth);
            int ne_height = (int)(0.3 * formHeight);

            int ne_x = (int)(0.65 * formWidth);
            int ne_y = (int)(0.7 * formHeight);

            ano.SetBounds(ano_x, ano_y, ano_width, ano_height);
            ne.SetBounds(ne_x, ne_y, ne_width, ne_height);
            hura.SetBounds(hura_x, hura_y, hura_width, hura_height);
            dalsiHra.SetBounds(dalsi_x, dalsi_y, dalsi_width, dalsi_height);
        }
    }
}
