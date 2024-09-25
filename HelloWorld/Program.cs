namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
       //Koodi tähän
            int luku1 = 10;
            int luku2 = 5;

            Console.WriteLine("Luvut yhdessä pötkössä: " + luku1 + luku2);
            Console.WriteLine("Luvut erikseen listattuna: " + luku1 + " " + luku2);
            //Console.WriteLine("Luvut erikseen listattuna toisenlaisella koodilla: {0} {1}", luku1, luku2);
            Console.WriteLine("Lukujen summa on: " + (luku1 + luku2));
        }
    }
}
