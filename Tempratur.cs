namespace GoogleHomeUML
{
    public class Tempratur  //klass ärv
    {
        public decimal tempratur;

        public void AdjustTemp() //metod
        {
            Console.WriteLine($"Tempen ligger jsut nu på {tempratur} grader");
        }
    }
}
