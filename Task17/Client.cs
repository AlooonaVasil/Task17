using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Client<T>
    {
        private T AccountNum { get; set; }
        private string Name { get; set; }
        private double Amount { get; set; }


        public string GetInfo()
        {
            return $"{AccountNum} {Name} {Amount}";
        }

        public void InputInfo()
        {
            Console.WriteLine("Введите числовой код клиента");
            AccountNum = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите сумму денег на счете");
            Amount = Convert.ToDouble(Console.ReadLine());
        }

    }


}
