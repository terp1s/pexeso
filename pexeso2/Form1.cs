using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace pexeso2
{
    public partial class Form1 : Form
    {
        Pexeso pexeso;
        List<Karticka> karticky;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            karticky = new List<Karticka>();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            pexeso = new Pexeso(this, this);
            PexesoPrep pexesoprep = new PexesoPrep(200, pexeso);
            karticky = pexesoprep.PrepareGame(20, this);
            pexeso.karticky = this.karticky;

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            pexeso.Start(height, width);
        }
    }
}
