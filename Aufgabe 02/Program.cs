namespace Aufgabe_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib die Anzhal Tage des Monates ein");
                string Monat = Console.ReadLine();
            int Monatszahl = Convert.ToInt32(Monat);

            Console.WriteLine("Ein Monat mit  " + (Monatszahl * 86400));

        }
    }
}
