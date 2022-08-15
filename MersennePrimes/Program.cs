using System;
using System.Numerics;

class MersennePrimes
{
    public static bool infinity;
    public static void Main()
    {
        MersennePrimes c = new MersennePrimes();
        int n = 0;
        Console.WriteLine(@"welcome to the mersenne Primes search. 
mersenne prime is found by using 2^n-1=x.
options:(enter the number to select)
1.get a limited search
2.get all the meresenne primes your computer can handle
3.exit
");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("enter the max value for n");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The Mersenne Primes up to the power of {0} are:", n);
                for (int i = 0; i < n; i++)
                {
                    mersennePrimes(i);
                }

                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine("this will run forever you can press any key to stop after its started");
                Console.WriteLine("are you sure you want to continue Y/N");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "Y")
                {
                    BigInteger x = 1;
                    infinity = true;
                    while (infinity)
                    {
                        mersennePrimes(x);
                        x++;
                    }

                    Console.ReadKey();
                }
                else
                {
                    break;
                }
                break;
            case 3:
                Environment.Exit(0);
                break;
            default:
                break;
        }
        
    }

   

    private static void mersennePrimes(BigInteger i )
    {
        try
        {
            BigInteger x;
            x = (BigInteger)(Math.Pow(2, (double)i) - 1);
            
            if (isprime(x))
            {
                Console.WriteLine("2^{0}-1 = {1}", i, x);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("this is the limitation of my program the numbers get to big for me to parse them");
            infinity = false;
            throw;
        }
        

    }

    private static bool isprime(BigInteger n)
    {
        if (n == 0 || n == 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt((double)n); i++)
        {
            if (n % i == 0)
            {
                return  false;
            }
        }
        return true;
    }
}



