internal class Program
{
    private static void Main(string[] args)
    {
        DateTime danes = DateTime.Now;

        if (danes.DayOfWeek == DayOfWeek.Monday) {
            Console.WriteLine("Jej pri Janezu!");
        } else if (danes.DayOfWeek == DayOfWeek.Tuesday) {
            Console.WriteLine("Jej pri Micki!");
        } else if (danes.DayOfWeek == DayOfWeek.Wednesday) {
            Console.WriteLine("Jej pri Tonetu!");
        } else if (danes.DayOfWeek == DayOfWeek.Thursday) {
            Console.WriteLine("Jej pri Bricu!");
        } else if (danes.DayOfWeek == DayOfWeek.Friday) {
            Console.WriteLine("Jej pri Kenu"!);
        } else if (danes.DayOfWeek == DayOfWeek.Saturday) {
            Console.WriteLine("Jej pri Marjanu!");
        } else if (danes.DayOfWeek == DayOfWeek.Sunday) {
            Console.WriteLine("Jej pri Francu!");
        }
    }
}