namespace pexeso2
{
    class Pexeso
    {
        public List<Karticka> karticky { get; set; }
        Control ParentControls { get; set; }
        int vybraneKartickyPocet;
        List<Karticka> vybraneKarticky;
        bool locked;
        int kartickyCount;
        Form Form;
        public Pexeso(Control controls, Form form)
        {
            vybraneKarticky = new List<Karticka>();
            ParentControls = controls;
            locked = false;
            kartickyCount = 20;
            this.karticky = new List<Karticka>();
            Form = form;
        }
        private void Shuffle(List<Karticka> karticky)
        {
            Random random = new Random();

            for (int i = 0; i < karticky.Count; i++)
            {
                int r = random.Next(i, karticky.Count);

                (karticky[r], karticky[i]) = (karticky[i], karticky[r]);
            }
        }
        public void Start(int height, int width)
        {
            Shuffle(karticky);
            RozdejKarticky(5, 4, height, width);
        }
        private void RozdejKarticky(int row, int column, int height, int width)
        {
            int rozmerKarticky = karticky[0].Height;
            int rozestupY = 50+(height - (row * rozmerKarticky)) / (row);
            int rozestupX = (int)((16.0 / 9.0) * rozestupY);

            int i = 0;

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    Point point = new Point(250 + (rozestupX + rozmerKarticky) * x, 20 + (rozestupY + rozmerKarticky) * y);
                    karticky[i].Location = point;
                    karticky[i].Visible = true;
                    i++;
                }
            }
        }
        private void Win()
        {
            WinForm win = new WinForm();
            win.Show();
            Form.Close();
        }

        private void AssesTurn()
        {
            if (vybraneKarticky[0].Image == vybraneKarticky[1].Image)
            {
                vybraneKarticky[0].DeaktivujSe();
                vybraneKarticky[1].DeaktivujSe();

                kartickyCount -= 2;

                if (kartickyCount == 0)
                {
                    Win();
                }
            }
            else
            {
                vybraneKarticky[0].OtocSe();
                vybraneKarticky[1].OtocSe();
            }

            vybraneKartickyPocet = 0;
            vybraneKarticky = new List<Karticka>();
            locked = false;
        }

        public async void ProcessClickedKarticka(Karticka karticka, bool avers)
        {
            if (locked)
            {
                return;
            }

            if (avers)
            {
                vybraneKartickyPocet += 1;
                vybraneKarticky.Add(karticka);
                karticka.OtocSe();
            }
            else
            {
                vybraneKartickyPocet -= 1;
                vybraneKarticky.Remove(karticka);
                karticka.OtocSe();
            }

            if (vybraneKartickyPocet == 2)
            {
                locked = true;
                await Task.Delay(2000);
                AssesTurn();
                
            }
        }
    }
}
