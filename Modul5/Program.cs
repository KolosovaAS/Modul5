using System;

namespace Modul5
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterUser();
            Console.WriteLine(); 
        }
        static void EnterUser()
        {
           
            (string name, string family, double age, bool pet, int petnum, string[] petname, int numcolor, string[] color) anketa = ("", "", 0.0, false, 0, null, 0, null);


            bool inname;
            string name1;
            do
            {
                Console.Write("Введите имя:");
                name1 = Console.ReadLine();
                inname=CheckStr(name1);

            } while (inname==false);
            anketa.name = name1;

            bool infamily;
            string family1;
            do
            {
                Console.Write("Введите фамилию:");
                family1 = Console.ReadLine();
                infamily = CheckStr(family1);

            } while (infamily == false);
            anketa.family = family1;
            
            string age1;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                age1 = Console.ReadLine();

            } while (CheckNum(age1, out intage));

            anketa.age = intage;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var result = Console.ReadLine();

            if (result == "Да")
            {   anketa.pet = true;
                string numpet1;
                int innumpet;
                do
                {
                    Console.WriteLine("Введите количество питомцев цифрами ");
                    numpet1 = Console.ReadLine();

                } while (CheckNum(numpet1, out innumpet));
                anketa.petnum = innumpet;
                anketa.petname = CreateArrayPetname(innumpet);

            }
            else
            { 
                anketa.pet = false;
              
            }
                        
            string numcolor1;
            int innumcolor;
            do
            {
                Console.WriteLine("Введите количество любимых цветов цифрами");
                numcolor1 = Console.ReadLine();

            } while (CheckNum(numcolor1, out innumcolor));
            anketa.numcolor = innumcolor;
            anketa.color = CreateArrayColor(innumcolor);

            //печать кортежа на экран
            Console.WriteLine(anketa.name);
            Console.WriteLine(anketa.family);
            Console.WriteLine(anketa.age);
            for (int i = 0; i < anketa.petname.Length; i++)
            {
                string item = anketa.petname[i];
                Console.WriteLine(anketa.petname[i]);
            }
            for (int i = 0; i < anketa.color.Length; i++)
            {
                string item = anketa.color[i];
                Console.WriteLine(anketa.color[i]);
            }
            Console.ReadKey();
            
        }
        static string[] CreateArrayPetname(int num)
        {

            Console.WriteLine("Введите имена питомцев?");
            var result = new string[num];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Console.ReadLine();
            }

            return result;
        }
        static string[] CreateArrayColor(int numcolor)
        {

            Console.WriteLine("Введите любимые цвета?");
            var result = new string[numcolor];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                { 
                    corrnumber = intnum;
                    return false;
                }
            }
            
            {
                corrnumber = 0;
                return true;
            }
        }
        static bool CheckStr(string text)
        {
            if (int.TryParse(text, out int number))
            {
                Console.WriteLine("Вы ввели число {0}", number);
                return false;  
            }
            {
                return true;
            }

            
        }
    }
}
