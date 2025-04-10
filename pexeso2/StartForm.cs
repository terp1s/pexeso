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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int x = (int)(0.6 * formWidth);
            int y = (int)(0.45 * formHeight);

            int width = formWidth / 3;
            int height = formHeight / 2;

            start_btn.SetBounds(x, y, width, height);
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Form1 hra = new Form1();
            this.Hide();
            hra.Show();
        }
    }
}
