namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib die erste Zahl ein");
            string eingabe1 = Console.ReadLine();
            int Zahl1 = Convert.ToInt32(eingabe1);



            Console.WriteLine("Gib die zweite Zahl ein");
            string eingabe2 = Console.ReadLine();
            int Zahl2 = Convert.ToInt32(eingabe2);

            Console.WriteLine("Das Ergebnis ist " + (Zahl1 + Zahl2));

        }
    }
}
