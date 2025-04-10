using System.ComponentModel.DataAnnotations.Schema;

namespace pexeso2
{
    class Karticka : PictureBox
    {
        public bool jeAktivni;
        public bool jeObrazkemDolu;
        public Image revers;
        public Image avers;
        Pexeso pexeso;

        public Karticka(Image revers, Image avers, Pexeso pexeso)
        {
            Visible = false;
            jeAktivni = true;
            jeObrazkemDolu = true;
            this.revers = revers;
            this.avers = avers;
            Image = revers;
            this.pexeso = pexeso;
            this.Click += Karticka_Click;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public void DeaktivujSe()
        {
            jeAktivni = false;
            Hide();
        }
        public void Karticka_Click(object sender, EventArgs e)
        {
            if (jeAktivni)
            {
                pexeso.ProcessClickedKarticka(this, this.jeObrazkemDolu);

            }
        }
        public void OtocSe()
        {
            if (jeObrazkemDolu)
            {
                KIvanoviCelem();
            }
            else
            {
                KIvanoviZady();
            }
        }

        private void KIvanoviZady()
        {
            this.Image = revers;
            jeObrazkemDolu = true;
            this.Refresh();
        }

        private void KIvanoviCelem()
        {
            this.Image = avers;
            jeObrazkemDolu = false;
            this.Refresh();

        }
    }
}
