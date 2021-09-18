using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //program arvutab kasutaja vanust
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada"
            //Kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"oled pisavalt vana, et juhilube saada"
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //Palju õnne! Nüüd sa saad juhilube taoleda"

            Console.WriteLine("Palun sisestage oma vanus");

            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada!");
            }

            else if(userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada");
            }

            else
            {
                Console.WriteLine("Palju Õnne! Nüüd sa saad juhilube taotleda!");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
