namespace OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldat s1 = new Soldat();
            Soldat s2 = new Soldat();

            s1.Puissance = 1;

            s1.Piew_piew(s2);
            Console.WriteLine(s2.Vie);
            }
    }
}