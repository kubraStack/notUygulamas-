namespace ConsoleAppMantıksalOpUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 * Öğrenci sınava girdiyse (kuralı ile)
                 * Aşağıdaki değerler ile aldığı notu uygun ise kredili not sistemine çeviriniz
                 * AA: 100-90
                 * BA: 89-80
                 * CB: 79-70
                 * DD: 69-50
                 * FF: 49-0            
            */

            bool sinavaGirdiMi = true;
            int notu = 60;
            string krediNotu = "";

            if (sinavaGirdiMi)
            {
                if (notu < 100 && notu  >= 90)
                {
                    krediNotu = "AA";
                    Console.WriteLine("Kredi notu: " + krediNotu);
                }
                else if(notu <= 89 && notu >=80)
                {
                    krediNotu = "BA";
                    Console.WriteLine("Kredi notu: " + krediNotu);
                }
                else if(notu <= 79 && notu >= 70)
                {
                    krediNotu = "CB";
                    Console.WriteLine("Kredi notu: " + krediNotu);
                }
                else if (notu <= 69 && notu >= 50)
                {
                    krediNotu = "DD";
                    Console.WriteLine("Kredi notu: " + krediNotu);
                }
                else if(notu <= 49)
                {
                    krediNotu = "FF";
                    Console.WriteLine("Kredi notu: " + krediNotu);
                }
            }

        }
    }
}
