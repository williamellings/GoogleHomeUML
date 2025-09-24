namespace GoogleHomeUML
{
    public class Tempratur : Apartment
    {
        public decimal tempratur;

        public void AdjustTemp()
        {
            Console.WriteLine($"Hur mycket vill du höja {tempratur} grader obs över 30 grader kan bli jävligt lökigt om du ska programmera vill du höja den mer?");
        }
    }
}
