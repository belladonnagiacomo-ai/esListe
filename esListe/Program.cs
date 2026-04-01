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
                Console.WriteLine(z);
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
                if((i % 2) == 0)
                {
                    pari.Add(i);
                }
                
            }
            foreach (int z in pari)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine();

            List<string> Duplicati = new List<string>() {"g", "g", "i", "a", "u", "a", "r"};
            List<string> nonD = new List<string>();
            for(int i = Duplicati.Count - 1; i >= 0; i--)
            {
                bool cont = nonD.Contains(Duplicati[i]);
                if(cont == false)
                {
                    nonD.Add(Duplicati[i]);
                }
            }
            foreach(string i in nonD)
            {
                Console.Write(i + "  ");
            }

            Console.WriteLine();

            List<int> numeri = new List<int>() { 2, 9, 4, 5, 10, 11, 1, 3, 8, 6, 7 };
            Console.WriteLine("Inserisci un numero");
            int nu = Convert.ToInt32(Console.ReadLine());
            bool c = numeri.Contains(nu);
            if(c == true)
            {
                numeri.Remove(nu);
            }

        }
    }
}
