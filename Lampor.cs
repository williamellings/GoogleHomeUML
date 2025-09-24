namespace GoogleHomeUML
{
    public class Lampor : Apartment //klass
    {
        public int LjusStyrka;
        public string LampNamn;

        public override void LightRoom() //metod
        {
            Console.WriteLine($"Just nu är din fina {LampNamn} på {LjusStyrka} alltså mega ljust");
        }
    }
}
