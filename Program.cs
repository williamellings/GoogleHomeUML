using System.Collections.Generic;


namespace GoogleHomeUML
{
    public class User
    {
        static void Main(string[] args)
        {

            Lampor minLagenhet = new Lampor();
            minLagenhet.lamporList.Add(new Lampor() { LampNamn = "Fönsterlampa", LjusStyrka = 80, Location = "Vardagsrum", CamName = "Vardagsrumkamera" });
            minLagenhet.lamporList.Add(new Lampor() { LampNamn = "Taklampa", LjusStyrka = 30, Location = "Hall", CamName = "Hallkamera" });

            Tempratur temp = new Tempratur(); //nytt objekt
            temp.tempratur = 20;
            temp.AdjustTemp();
  

            foreach (var lampa in minLagenhet.lamporList)
            {
                Console.WriteLine($"{lampa.LampNamn} i {lampa.Location} har ljusstyrka {lampa.LjusStyrka} kollar {lampa.CamName} ");
            }





        }
    }
}
