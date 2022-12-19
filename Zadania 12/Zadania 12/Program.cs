using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_11
{

    class String
    {
        // поля
        int n;
        StringBuilder Line;

        // конструктор, позволяющий создать строку из n символов
        public String(string str)
        {
            Line = new StringBuilder(str);
            n = str.Length;
        }

        // метод для подсчета количества пробелов в строке
        public int probel()
        {
            int count = 0;
            for (int i = 0; i < Line.Length; i++)
                if (char.IsWhiteSpace(Line[i])) count++;
            return count;
        }

        // метод для замены в строке всех прописных символов на строчные
        public string simvol()
        {
            return Line.ToString().ToLower();
        }

        // метод для удаления из строки всех знаков препинания
        public string delete()
        {
            return Line.ToString().Replace(",", "").Replace("!", "").Replace(".", "").Replace(";", "").Replace(":", "").Replace("?", "");
        }

        //Свойство возвращающее общее количество элементов в строке 
        public int N
        {
            get { return Line.Length; }
        }

        //Свойство позволяющее установить значение поля, в соответствии с введенным значением строки с клавиатуры, 
        //а также получить значение данного поля
        public int Set_N
        {
            get { return n; } // действия, выполняемые при получении значения свойства

            set { n = value; } //действия, выполняемые при установке значения свойства
        }

        //Индексатор, позволяющий по индексу обращаться к соответствующему символу строки.
        public char this[int index]
        {
            get
            {
                return Line[index];
            }
        }

        //Операции унарного +: преобразующей строку к строчным символам;
        public static string operator +(String obj)
        {
            return obj.Line.ToString().ToLower();
        }

        //Операция унарного -: преобразующей строку к прописным символам;
        public static string operator -(String obj)
        {
            return obj.Line.ToString().ToUpper();
        }

        //Констант true и false: обращение к экземпляру класса дает значение true, если строка не пустая, иначе false.
        public static bool operator true(String obj)
        {
            if (obj.Line.Length != 0)
                return true;
            return false;
        }
        public static bool operator false(String obj)
        {
            if (obj.Line.Length == 0)
                return true;
            return false;
        }

        //операции &: возвращает значение true, если строковые поля двух объектов посимвольно равны (без учета регистра), иначе false;
        public static bool operator &(String obj1, String obj2)
        {
            return obj1.Line.ToString().ToUpper().Equals(obj2.Line.ToString().ToUpper());
        }
        //Преобразования класса-строка в тип string (и наоборот).
        public static explicit operator string(String obj)
        {
            return obj.Line.ToString();
        }

        public static explicit operator String(string obj)
        {
            return new String(obj);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string str = Console.ReadLine();
            String Line = new String(str); //экземпляр класса

            Console.WriteLine("Количество пробелов в тексте: - {0}", Line.probel());

            Console.WriteLine("Заменить в тексте все прописные символы на строчные: \n{0}", Line.simvol());

            Console.WriteLine("Удалить из текста все знаки препинания: \n{0}", Line.delete());

            Console.WriteLine("Общее количество символов в тексте: {0}", Line.N);

            Console.WriteLine("Значение данного поля: {0}", Line.Set_N);


            Console.WriteLine("Введите строку:");
            str = Console.ReadLine();
            String Line2 = new String(str);
            Console.WriteLine("Равны ли строки? {0}", Line & Line2);

            Console.WriteLine("Преобразование строки к строчным символам : \n {0}", -Line);

            Console.WriteLine("Преобразование строки к прописным символам: \n {0}", +Line);
            Console.Write(Line[0]);

            if (Line)
                Console.WriteLine("Строка не пустая.");
            else
                Console.WriteLine("Строка пустая.");
        }
    }
}







