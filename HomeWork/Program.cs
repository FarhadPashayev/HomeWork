namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Il daxil edin");
            int Sil = int.Parse(Console.ReadLine());
            if (Sil<=2022) 
               {
                Console.WriteLine("duzgundur");

            }else
            {
                Console.WriteLine("Sehvdir");
            }   
            
            Console.WriteLine("Ay daxil edin");
            int Say = int.Parse(Console.ReadLine());
            if (Say <= 12)
            {
                Console.WriteLine("duzgundur");

            }
            else
            {
                Console.WriteLine("Sehvdir");
            }
            Console.WriteLine("Gun daxil edin");
            int Sgun = int.Parse(Console.ReadLine());
            if (Sgun <= 30)
            {
                Console.WriteLine("duzgundur");

            }else
            {
                Console.WriteLine("Sehvdir");
            }   
            //
            Console.WriteLine(" Son ili daxil edin");
            int Eil = int.Parse(Console.ReadLine());
            if (Eil > 0 || Eil<=2022)
            {
                int age = Eil - Sil;
                Console.WriteLine("Yash:"+age);

            }
            else
            {
                Console.WriteLine("Sehvdir");
            }
            Console.WriteLine("Son ay daxil edin");
            int Eay = int.Parse(Console.ReadLine());
            if (Eay <= 12)
            {
                Console.WriteLine("duzgundur");

            }
            else
            {
                Console.WriteLine("Sehvdir");
            }
            Console.WriteLine("Son gun daxil edin");
            int Egun = int.Parse(Console.ReadLine());
            if (Egun <= 30)
            {
                Console.WriteLine("duzgundur");

            }
            else
            {
                Console.WriteLine("Sehvdir");
            }




           
            //  int Age = (EGun - SGun);
            //Console.WriteLine(Age);



            //if () {
            
            
            //}

        }
    }
}