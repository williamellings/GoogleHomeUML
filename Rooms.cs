namespace GoogleHomeUML
{
    public class Apartment : GoogleHome
    {
        public string Location = "Vardagsrum";

        public void Room()
        {
            Console.WriteLine($"Du har valt {Location} ");
        }

        public virtual void LightRoom()
        {
            Console.WriteLine("Ljust i rummet");
        }
    }
}
