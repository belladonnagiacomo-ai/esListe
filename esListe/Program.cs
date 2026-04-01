namespace esListe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> n = new List<int>() ;
            
            for(int i = 0; i <= 10; i++)
            {
               n.Add(i) ;
            }
            foreach(int z in n)
            {
                Console.WriteLine($"[{n[z]}]");
            }
           
            Console.WriteLine();

            List<int> num = new List<int>() {2,6,10,50,20,13,1,3,8,6,7};
            int somma = 0;
            foreach (int i in num )
            {
               
                somma += i;
                
            }
            Console.WriteLine("La somma e: " + somma);

            Console.WriteLine();

            List<int> pari = new List<int>();
            foreach (int i in num )
            {
                if((i & 2) == 0)
                {
                    pari.Add(i);
                }
                Console.WriteLine("numeri pari: " + pari);
            }

            Console.WriteLine();



        }
    }
}
