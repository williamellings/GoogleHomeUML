namespace GoogleHomeUML
{
    public class GoogleHome //huvudklass 
    {
        private int Password;
        public string Status = "Lyssnar";

        public void HejGoogle() //metod
        {
            Console.WriteLine($"hej jag {Status}");
        }
    }
}
