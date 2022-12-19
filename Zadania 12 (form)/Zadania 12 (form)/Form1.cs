using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_12__form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
                get { return Line[index]; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Заполните 2 строку");
                return;
            }
            string str = textBox1.Text;
            String Line = new String(str); //экземпляр класса

            textBox2.Text += Line.probel();

            textBox4.Text += Line.simvol();

            textBox3.Text += Line.delete();

            textBox5.Text += Line.N;


            str = textBox6.Text;
            String Line2 = new String(str);
          textBox10.Text += Line & Line2;

            textBox9.Text += -Line;

          textBox8.Text += +Line;

            if (Line)
                textBox7.Text +="Строка не пустая.";
            else
               textBox7.Text += "Строка пустая.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
            textBox4.Text = "";
            textBox4.Clear();
            textBox5.Text = "";
            textBox5.Clear();
            textBox6.Text = "";
            textBox6.Clear();
            textBox7.Text = "";
            textBox7.Clear();
            textBox8.Text = "";
            textBox8.Clear();
            textBox9.Text = "";
            textBox9.Clear();
            textBox10.Text = "";
            textBox10.Clear();

        }
    }
}
