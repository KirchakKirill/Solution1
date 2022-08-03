using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryCodeBLog.BL.Controller;

namespace InterfaceCodeBlog.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Fitness");
            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();
            var usercontrl = new UserController(name);
            if (usercontrl.IsNewUser)
            {
                Console.WriteLine("Введите пол:");
                var gender = Console.ReadLine();
                bool f = true;
                double weight = ParseDOuble(f,"Вес");
                double height = ParseDOuble(f,"Рост");
                DateTime bd;
                ParseDate( f, out bd);

                usercontrl.SetNewUserData(gender, bd, weight, height);
            }

            //Console.WriteLine(usercontrl.CurrentUser);

            //
            //Console.WriteLine("Введите дату рождения");
            //var birthdate = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Введите вес");
            //var weight = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите рост");
            //var height = Double.Parse(Console.ReadLine());

            //usercontrl.Save();
        }

        private static void ParseDate( bool f, out DateTime bd)
        {
            string brd;
            do
            {
                if (!f)
                {
                    Console.WriteLine("Неверный формат даты рождения...");
                }
                Console.WriteLine("Введите дату рождения:");
                brd = Console.ReadLine();
            } while (!(f = DateTime.TryParse(brd, out bd)));
           
        }

        private static double ParseDOuble(bool f,string name)
        {
            string s;
            double value;
            do
            {
                if (!f)
                {
                    Console.WriteLine("Неверный формат ...");
                }
                Console.WriteLine($"Введите {name}:");
                s = Console.ReadLine();
            } while (!(f = double.TryParse(s, out value)));

            return value;
        }
    }
}
