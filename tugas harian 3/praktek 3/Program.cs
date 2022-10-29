internal class Program
{
    private static void Main(string[] args)
    {
        //masukin hari
        string[] hari = new string[] { "senin", "selasa", "rabu", "kamis", "jum'at", "sabtu", "minggu" };
  
        Console.WriteLine("Masukkan hari, 1-10");
        int nomor = Convert.ToInt32(Console.ReadLine());
        if (nomor == 1)
        {
            Console.WriteLine(hari[0]);
        }
        else if (nomor == 2)
        {
            Console.WriteLine(hari[1]);
        }
        else if (nomor == 3)
        {
            Console.WriteLine(hari[2]);
        }
        else if (nomor == 4)
        {
            Console.WriteLine(hari[3]);
        }
        else if (nomor == 5)
        {
            Console.WriteLine(hari[4]);
        }
        else if (nomor == 6)
        {
            Console.WriteLine(hari[5]);
        }
        else if (nomor == 7)
        {
            Console.WriteLine(hari[6]);
        }

        else 
        {
            Console.WriteLine("tidak ditemukan");
        }
        Console.WriteLine("masukkan karakter");
            char karakter = Convert.ToChar(Console.ReadLine());
            if (karakter == 'a')
            {
                Console.WriteLine(hari[0]);
            }
            else if (karakter == 'b')
            {
                Console.WriteLine(hari[1]);
            }
            else if (karakter == 'c')
            {
                Console.WriteLine(hari[2]);
            }
            else if (karakter == 'd')
            {
                Console.WriteLine(hari[3]);
            }
            else if (karakter == 'e')
            {
                Console.WriteLine(hari[4]);
            }
            else if (karakter == 'f')
            {
                Console.WriteLine(hari[5]);
            }
            else if (karakter == 'g')
            {
                Console.WriteLine(hari[6]);
            }
        else
        {
            Console.WriteLine("tidak ditemukan");
        }
    }
    }
    
