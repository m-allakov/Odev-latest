namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int ySayi;
            Console.Write("Başlangıç Sayıyı Giriniz:");
            int sayi1= int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz:");
            int sayi2= int.Parse(Console.ReadLine());
            Console.Write("Kaç Aded Sayı İstiyorsunuz:");
            int adet= int.Parse(Console.ReadLine());
            int[] ints = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                ySayi = rnd.Next(sayi1, sayi2);
                if (i==0)
                {
                    ints[i] = ySayi;
                }
                
                    for (int j = 0; j < i; j++)
                    {
                        if (ints[j] == ySayi)
                        {
                            i--;
                            break;
                        }
                        else
                        {
                            ints[i] = ySayi;
                        }
                    }
                
                
                
                
                
                
            }
            Array.Sort(ints);
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            

        }
    }
}