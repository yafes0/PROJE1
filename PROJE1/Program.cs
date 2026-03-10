namespace PROJE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SAYI1;
            int SAYI2;
            string METİN1;
            string METİN2;
            int SONUÇ;

            Console.WriteLine("1.Sayıyı giriniz:");
            METİN1 = Console.ReadLine();
            SAYI1 = Convert.ToInt32(METİN1);

            Console.WriteLine("2. Sayıyı giriniz:");
            METİN2 = Console.ReadLine();
            SAYI2 = Convert.ToInt32(METİN2);

            SONUÇ = SAYI1 + SAYI2;

            Console.WriteLine(SONUÇ.ToString());
        }
    }
}
