namespace GoogleHomeUML
{
    public class Kamror : Apartment //klass ärv
    {
        public string CamName;

        public void CheckCam() //metod
        {
            Console.WriteLine($"Kollar {CamName} i {Location} ");
        }
    }
}
