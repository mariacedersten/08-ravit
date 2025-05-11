using System.IO.Pipes;

namespace Ravit
{
    /// <summary>
    /// Tämä luokka esittää ravihevosta joka juoksee ympäri rataa
    /// </summary>
    class Horse
    {
        // Luokan muuttujat
        // Class variables
        //Joko private tai public
        //(tai protected)
        public string lempiruoka;
        public float nopeus;
        public int kilpailunumero;
        public string nimi;

        private float kylläisyys;

        // Luokan konstruktori määärittää mitä
        // tietoja pitää antaa kun luodaan uusi olio
        // Konstruktorin mini on sama kuin luokan nimi
        // Jos on määtitelty yksikin konstruktori
        // niin oletuskonstruktori katoaa...
        // Dokumentaatiokommentti alkaa kolmella kauttaviivalla.

        /// <summary>
        /// Luo uuden hevosen joka on valmis kilpailemaan
        /// </summary>
        /// <param name="ruoka">Hevosen lempiruoka</param>
        /// <param name="nimi">Hevosen kilpailunimi</param>
        /// <param name="kilpailunumero">Kilpailubunero pitää olla positiivinen kokonaisluku</param>
        /// <param name="nopeus">Hevosen nopeus yksikkö on kilometriä tunnissa kmh/h</param>

        public Horse(string ruoka, string nimi, int kilpailunumero, float nopeus)
        {
            if (nopeus > 0)
            {
                // tallenna annettu parametri 
                // olioon. Sana this viittaa olioon
                // itseensä
                this.nopeus = nopeus;
            }
            this.nimi = nimi;
            this.kilpailunumero = kilpailunumero;
            this.lempiruoka = ruoka;
        }

        public void AnnaRuoka(int annoksia)
        {
            // Varmistaa että hevonen ei syö liikaa
            if (annoksia > 0)
            {
                kylläisyys += 0.1f * annoksia;

            }
        }



        // Luokan finsktiot
        public void TulostaTiedot()
        {
            // Tulosta hevosen tiedot:
            // Tulosta hevosen tiedot:
            Console.WriteLine($"Hevosen nimi: {nimi}, kilpailunumero: {kilpailunumero}, nopeus: {nopeus} km/h, lempiruoka: {lempiruoka}.");
        }

    }
}