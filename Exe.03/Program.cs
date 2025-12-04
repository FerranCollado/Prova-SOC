namespace Exe._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hores, minuts, segons;
            int horesresoltes, minutresol, ResultatFinal;
            Console.WriteLine("Quantes hores has estat esperant? ");
            hores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quants minuts has esperat? ");
            minuts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quants segons has estat esperant? ");
            segons = Convert.ToInt32(Console.ReadLine());

            horesresoltes = hores * 3600;
            minutresol = minuts * 60;

           ResultatFinal = (horesresoltes + minutresol + segons);
            Console.Clear();
            Console.WriteLine("Els segons que has estat esperant són " + ResultatFinal );

        }
    }
}
