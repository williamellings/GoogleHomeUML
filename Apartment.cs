namespace GoogleHomeUML
{
    public class Apartment : GoogleHome //klass apart ärver av 
    {
        public string Location = "Vardagsrum";


        public virtual void LightRoom() //metod
        {
            Console.WriteLine("Ljust i rummet");
        }
    }
}
