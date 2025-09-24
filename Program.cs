namespace GoogleHomeUML
{
    internal class User
    {
        static void Main(string[] args)
        {
            Apartment googleHome = new Apartment();
            googleHome.Room();

            Lampor lampa = new Lampor();
            lampa.LampNamn = "Fönsterlampa";
            lampa.LjusStyrka = 80;
            lampa.LightRoom();

            Tempratur temp = new Tempratur();
            temp.tempratur = 200;
            temp.AdjustTemp();

            Kamror kamera = new Kamror();
            kamera.CamName = "Hallkamera";
            kamera.CheckCam();
        }
    }
}
