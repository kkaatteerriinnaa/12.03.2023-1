using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Firma
    {
        public string Name { set; get; }
        public int Data { set; get; }
        public string Profile { set; get; }
        public string FIO { set; get; }
        public int Count { set; get; }
        public string Adres { get; set; }
        public List<string> Employee { get; set; }
        public Firma()
        {
            Employee = new List<string>();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Firma> firma = new List<Firma>
            {
                new Firma{Name="Food",Data=2000,Profile="маркетинг",FIO="F I O 1",Count=101,Adres="Лондон", Employee = new List<string> {"ФИО", "Должность","Телефон","Email","1000" } },
                new Firma{Name="IT",Data=2000,Profile="IT",FIO="White",Count=100,Adres="adress2", Employee = new List<string> { "ФИО", "Должность", "Телефон", "Email", "1000" } }
            };

            var print = from i in firma
                        select i;
            foreach (var i in print)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

            var print1 = from i in firma
                         from name in i.Name
                         where name == "Food"
                         select i;
            foreach (var i in print1)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

            var print2 = from i in firma
                         from profile in i.Profile
                         where profile == "маркетинг"
                         select i;
            foreach (var i in print2)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

            var print3 = from i in firma
                         from profile in i.Profile
                         where profile == "IT" || profile == "маркетинг"
                         select i;
            foreach (var i in print3)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

            var print4 = from i in firma
                         from count in i.Count
                         where count > 100
                         select i;
            foreach (var i in print4)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

            var print5 = from i in firma
                         from count in i.Count
                         where count > 100 && count < 300
                         select i;
            foreach (var i in print5)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

            var print6 = from i in firma
                         from adres in i.Adres
                         where adres == "Лондон"
                         select i;
            foreach (var i in print6)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

            var print7 = from i in firma
                         from fio in i.FIO
                         where fio == "White"
                         select i;
            foreach (var i in print7)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

            var print8 = firma.Select(i => i);
            foreach (var i in print8)
            {
                Console.Write("Название:{0} \n Дата основания:{1} \n профиль бизнеса:{2} \n ФИО деректора{3} \n Количество сотрудников{4} \n Адрес:{5}\n", i.Name, i.Data, i.Profile, i.FIO, i.Count, i.Adres);
                Console.WriteLine();
            }

           
        }
    }
}
