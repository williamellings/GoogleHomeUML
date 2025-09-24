namespace GoogleHomeUML
{
    internal class User
    {
        static void Main(string[] args)
        {

            Lampor lampa = new Lampor(); //nytt objekt
            lampa.LampNamn = "Fönsterlampa";
            lampa.LjusStyrka = 80;
            lampa.LightRoom();

            Tempratur temp = new Tempratur(); //nytt objekt
            temp.tempratur = 20;
            temp.AdjustTemp();

            Kamror kamera = new Kamror(); //nytt objekt
            kamera.CamName = "Hallkamera";
            kamera.CheckCam();
        }
    }
}
