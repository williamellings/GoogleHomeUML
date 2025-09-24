namespace GoogleHomeUML
{
    public class Tempratur : Apartment //klass ärv
    {
        public decimal tempratur;

        public void AdjustTemp() //metod
        {
            Console.WriteLine($"Hur mycket vill du höja {tempratur} grader obs över 30 grader kan bli jävligt lökigt om du ska programmera vill du höja den mer?");
        }
    }
}
