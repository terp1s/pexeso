namespace pexeso2
{
    class PexesoPrep
    {
        List<Karticka> karticky;
        ImageList avers;
        Image revers;
        int rozmerKarticky;
        Pexeso pexeso;
        public PexesoPrep(int rozmer, Pexeso pexeso)
        {
            rozmerKarticky = rozmer;
            avers = new ImageList();
            karticky = new List<Karticka>();
            this.pexeso = pexeso;
        }
        public List<Karticka> PrepareGame(int pocetKarticek, Control ParentControls)
        {
            revers = GetRevers("revers.jpg");
            avers = GetAvers(20);
            CreateKarticky(pocetKarticek, ParentControls);

            return karticky;
        }
        private Image GetRevers(string file)
        {
            string pathRevers = Path.Combine(Application.StartupPath, "obrazky", file);

            using (var stream = new FileStream(pathRevers, FileMode.Open, FileAccess.Read))
            {
                return Image.FromStream(stream);
            }
        }
        private ImageList GetAvers(int count)
        {
            ImageList av = new ImageList();
            av.ImageSize = new Size(rozmerKarticky, rozmerKarticky);

            string pathImagesPattern = Path.Combine(Application.StartupPath, "obrazky", "{0}.png");

            for (int i = 0; i < count / 2; i++)
            {
                Image im;
                string pathImage = string.Format(pathImagesPattern, i);
                im = Image.FromFile(pathImage);

                av.Images.Add(im);
            }

            return av;
        }
        private void CreateKarticky(int pocetKarticek, Control ParentControls)
        {
            for (int i = 0; i < pocetKarticek - 1; i = i + 2)
            {
                Image im = avers.Images[(i / 2)];

                karticky.Add(new Karticka(revers, im, pexeso));
                karticky.Add(new Karticka(revers, im, pexeso));
                ParentControls.Controls.Add(karticky[i]);
                ParentControls.Controls.Add(karticky[i + 1]);
            }

            foreach (Karticka karticka in karticky)
            {
                karticka.Height = rozmerKarticky;
                karticka.Width = rozmerKarticky;
            }
        }
    }
}
