using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana
            //Kui kasutaja on 13 aastat või vanem, siis ta võib Instagrami kasutada
            //Kui kasutaja o noorem, kui 13, siis ta on liiga noor.

            Console.WriteLine("Palun, sisesta om vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled pisavalt vana, et Instagrami kontot luua");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua");
            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd saad endale Instagrami kontot luua");
            }

            Console.WriteLine("Kena päeva!");
            
        }
    }
}
