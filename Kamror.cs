namespace GoogleHomeUML
{
    public class Kamror : Apartment
    {
        public string CamName;

        public void CheckCam()
        {
            Console.WriteLine($"Kollar {CamName} i {Location} ");
        }
    }
}
