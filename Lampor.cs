namespace GoogleHomeUML
{
    public class Lampor : Apartment
    {
        public int LjusStyrka;
        public string LampNamn;

        public override void LightRoom()
        {
            Console.WriteLine($"Just nu är din fina {LampNamn} på {LjusStyrka} alltså mega ljust");
        }
    }
}
