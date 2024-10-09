using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rusDamage;
            int rusHealth = 250;
            int rusDodge;

            int lizardDodge;
            int lizardDamage;
            int lizardHealth = 50;
            int lizardQuantity = 8;

            while (rusHealth > 0 && lizardQuantity > -1)
            {
                Console.WriteLine("---- Ход Ящера ----");

                rusDodge = rnd.Next(1, 100);

                if (rusDodge >= 60)
                {
                    lizardDamage = rnd.Next(1, 40);
                    rusHealth -= lizardDamage;
                    Console.WriteLine($"Ящер нанёс вам {lizardDamage} урона и у вас осталось {rusHealth} здоровья!");
                }
                else
                {
                    Console.WriteLine("Вы увернулись");
                }

                Console.WriteLine("---- Ход Салошки ----");
                Console.WriteLine("Здоровье: {0}", rusHealth);

                lizardDodge = rnd.Next(1, 100);


                if (lizardDodge >= 30)
                {
                    rusDamage = rnd.Next(1, 60);
                    lizardHealth -= rusDamage;
                    Console.WriteLine($"Вы нанесли ящеру {rusDamage} урона и у него осталось {lizardHealth} здоровья!");
                }
                else
                {
                    Console.WriteLine("Вы промахнулись");
                }

                if (lizardHealth <= 0)
                {
                    lizardHealth = rnd.Next(20, 90);
                    lizardQuantity--;
                    if (lizardQuantity <= -1)
                    {

                    }
                    else
                    {
                        Console.WriteLine("На сцену выходит новый ящер! " + lizardQuantity + " ящеров осталось");
                    }
                }
            }
            if (rusHealth > 0)
            {
                Console.WriteLine($"Салошник победил и у него осталось {rusHealth} здоровья!");
            }
            else
            {
                Console.WriteLine($"Салошник проиграл а ведь ему осталось победить всего {lizardQuantity} ящеров");
            }
        }
    }
}
