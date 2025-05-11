namespace Ravit
{
    internal class Program
    {
        // Tämä ohjelma simuloi hevosurheilia
        //jossa etilaiset hevoset juoksevat kilpaa

        public static void Main()
        {
            //Jokaisella hevosella on
            // - lempiruoka: string
            // - nopeus: float
            // - kilpailunumero: int
            // - nimi : string

            // Horse luokka on samassa
            // nimiavaruudessa "Ravit"
            Horse[] hevoset;

            // Varaa muistia 3 hevoselle
            // mutta ei luo hevoksia
            hevoset = new Horse[3];

            // (Luo yksi hevonen)
            // (Luo olio luokan Horse määritelmän mukaan) 
            /*hevoset[0] = new Horse();
            // Muuta hevosen tietoja; muuttujien
            // pitää olla public jotta tämä onnistuu
            hevoset[0].lempiruoka = "omena";
            hevoset[0].nopeus = 19.1f;
            hevoset[0].kilpailunumero = 1234;
            hevoset[0].nimi = "Kallion Keisari";*/

            hevoset[0] = new Horse("omena", "Kallion Keisari", 1234, 19.1f);

            //Tulosta hevosen tiedot:
            // h0 viittaa taulukon ensimmäiseen 
            // hevoseen
            /*Horse h0 = hevoset[0];
            h0.TulostaTiedot();*/

            hevoset[1] = new Horse("peruna", "Kekkonen", 6435, 12.0f);
            /*Horse h1 = hevoset[1];
            h1.TulostaTiedot();*/
            hevoset[2] = new Horse("sokeripala", "Mansikki", 234, 1.0f);

            // hevoset[2].kkylläisyys = 300.0f; ei voi koska private
            hevoset[2].AnnaRuoka(3);

            // Koska Veikkauslippu on struct
            // siitä tehdään aito kopio kun sen sijoittaa
            // toiseen muuttujaan.

            Veikkauslippu v1 = new Veikkauslippu(124, 50.0f);
            Veikkauslippu v2 = v1;
            v2.Lunasta();

            // Koska Horse on classm siitä tehdään
            // viittaus kun sen sijoittaa toiseen muuttujaan 

            Horse kekkonen = hevoset[1];
            Horse kakkonen = kekkonen;
            kakkonen.AnnaRuoka(100);

            v1.TulostaTiedot();
            v2.TulostaTiedot();

            while (true)
            {
                Console.WriteLine("Valitse toiminto");
                Console.WriteLine("1: Näytä hevosten tiedot");
                Console.WriteLine("2: Ruoki hevosta");
                Console.WriteLine("3: Järjestä kilpailu");
                Console.WriteLine("4: Lopeta peli");

                int vastaus = Int32.Parse(Console.ReadLine());
                switch (vastaus)
                {
                    case 1:
                        for (int i = 0; i < hevoset.Length; i += 1)
                        {
                            hevoset[i].TulostaTiedot();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Anna hevosen numero 1-3");
                        int heppa = Int32.Parse(Console.ReadLine());
                        hevoset[heppa - 1].AnnaRuoka(1);
                        break;
                }
            }

            for (int i = 0; i < hevoset.Length; i++)

            {
                hevoset[i].TulostaTiedot();
            }
            /*foreach (Horse heppa in hevoset)
            {
                heppa.TulostaTiedot();
            }*/


            /*// Tulosta hevosen tiedot:
            // Tulosta hevosen tiedot:
            Console.WriteLine($"Hevosen nimi: {h0.nimi}");
            Console.WriteLine($"Kilpailunumero: {h0.kilpailunumero}");
            Console.WriteLine($"Nopeus: {h0.nopeus} km/h");
            Console.WriteLine($"Lempiruoka: {h0.lempiruoka}");*/
        }
    }
}

