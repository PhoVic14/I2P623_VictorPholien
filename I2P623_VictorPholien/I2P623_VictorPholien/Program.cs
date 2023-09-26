

namespace I2P623_VictorPholien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Etat des feux:");
            Console.WriteLine("______________");
            Console.WriteLine(AfficheEtat());

            Console.WriteLine("Changement d'état");
            Console.WriteLine("_________________");
            Console.WriteLine(Change());

            Console.WriteLine("Feu clignotant");
            Console.WriteLine("______________");
            Console.WriteLine(Clignote());
        }
    }
}