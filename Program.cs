using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a;
            byte b;
            sbyte c;
            char d;
            decimal e;
            double f;
            float g;
            int i;
            uint n;
            long l;
            ulong m;
            short s;
            ushort t;
            object o;
            string s1;
            dynamic dyn;
            Console.Write("bool a: = ");//Консоль выводит фразу, написанную в кавычках
            a = bool.Parse(Console.ReadLine());//метод Parse принимает строку и возвращает объект типа bool
            Console.WriteLine(a);//все остальные методы работают точно также, только возращают другие типы
            Console.Write("byte b: = ");
            b = byte.Parse(Console.ReadLine());
            Console.WriteLine(b);
            Console.Write("sbyte c: = ");
            c = sbyte.Parse(Console.ReadLine());
            Console.WriteLine(c);
            Console.Write("char d: = ");
            d = char.Parse(Console.ReadLine());
            Console.WriteLine(d);
            Console.Write("decimal e: = ");
            e = decimal.Parse(Console.ReadLine());
            Console.WriteLine(e);
            Console.Write("double f: = ");
            f = double.Parse(Console.ReadLine());
            Console.WriteLine(f);
            Console.Write("float g: = ");
            g = float.Parse(Console.ReadLine());
            Console.WriteLine(g);
            Console.Write("int i: = ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i);
            Console.Write("uint n: = ");
            n = uint.Parse(Console.ReadLine());
            Console.WriteLine(n);
            Console.Write("long l: = ");
            l = long.Parse(Console.ReadLine());
            Console.WriteLine(l);
            Console.Write("ulong m: = ");
            m = ulong.Parse(Console.ReadLine());
            Console.WriteLine(m);
            Console.Write("short s: = ");
            s = short.Parse(Console.ReadLine());
            Console.WriteLine(s);
            Console.Write("ushort t: = ");
            t = ushort.Parse(Console.ReadLine());
            Console.WriteLine(t);
            Console.Write("object o: = ");
            o = Console.ReadLine();
            Console.WriteLine(o);
            Console.Write("string s1: = ");
            s1 = Console.ReadLine();
            Console.WriteLine(s1);
            Console.Write("dynamic dyn: = ");
            dyn = Console.ReadLine();
            Console.WriteLine(dyn);

            Console.Write("string = ");
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);//происходит конвертация из string в int. Отличие от Parse в том, что в случае 
            Console.WriteLine(num);//если строка будет пустой, то программа не выдаст исключение  

            int num1 = 123;//неявное преобразование заключается в преобразовании из меньшего типа данных в больший. 
            long bignum1 = num1;//Оно называется неявным, так как компилятор за нас сделает преобразование
            float num2 = 12.23F;//Так как потеря данных будет отсутствовать 
            double bignum2 = num2;
            byte num3 = 12;
            short bignum3 = num3;
            byte num4 = 13;
            ushort bignum4 = num4;
            uint num5 = 12345;
            ulong bignum5 = num5;

            double num6 = 12.34;//Явное преобразование предполагает наше вмешательство  
            int newnum6 = (int)num6;//Потребуется приведение, которая исключит ошибку компиляции
            long num7 = 456;//Приведение исключает случаи, когда данные будут потеряны или или же случится сбой по той или иной причине
            int newnum7 = (int)num7;
            short num8 = 64;
            byte newnum8 = (byte)num8;
            ulong num9 = 56789;
            uint newnum9 = (uint)num9;
            ushort num10 = 33333;
            byte newnum10 = (byte)num10;

            int value = 123;
            object obj = (int)value;
            int newvalue = (int)obj;

            var k = 155;//Ключевое слово Var не является типом данных
            int sum = 14 + k;//Var заставляет компилятора за нас определить, какой тип данных мы только что ввели.
            //Если же мы присвоим значение другого типа уже инициализированной переменной var, то компилятор выдаст ошибку
            //Мы не сможем поменять уже определенный тип данных, который ранее уже определил компилятор
            //Единственое исключение - это ссылочный тип dynamic, который позволяет такое сделать


            int? nvalue = null;//значение null присваивается по умолчанию любому ссылочному типу данных
            Console.WriteLine(nvalue);//Ссылочный тип должен на что-то ссылаться, иначе это вызовет исключение NullPointExeption 
            nvalue = 123;//Значимому типу данных обычно не присваивается значение null, но с помощью знака "?" это возможно 
            Console.WriteLine(nvalue);//Знак ? позволяет присваивать значимым типа данных null значение

            string string1 = "Hello World I Am HERE";
            string string2 = "Beautiful World";
            string string3 = "Goodbye World";
            Console.WriteLine(string.Compare(string1, string2));//сравнение строк, ориентирующая по региональному алфавиту, возвращает значение 0,1,-1 
            string combination = string1 + " " + string2;//1 - первая строка предшествует второй, 0 - строки равны, -1 - вторая строка предшествует первой
            Console.WriteLine(combination);
            string1 = String.Copy(string2);//Копирование строки и последующее присваивание
            Console.WriteLine(string1);
            string1 = "Hello World I Am HERE";
            int startPosition = string1.IndexOf(" ") + 1;//Задается начальная позиция в строке string1 
            string word = string1.Substring(startPosition, string1.IndexOf(" ", startPosition) - startPosition);//Выделяется пятое слово в напсианной строке
            Console.WriteLine("Substring: " + word);
            string[] words = string2.Split(new char[] { ' ' });//Происходит расчленение строки. Пятое слово становится массивом типа Char
            foreach (string newstring in words)
            {
                Console.WriteLine(newstring);
            }
            string sub = "Nice ";
            string3 = string3.Insert(8, sub);//Начиная с определенной позиции 8 присоединяется строка sub
            Console.WriteLine(string3);
            string2 = string2.Remove(0, 2);//Удаляются все символы начиная с позиции 0 и заканичвая позиции 2
            Console.WriteLine(string2);
            Console.WriteLine($"first sentence: {0}; second sentence: {1}; third sentence: {2}", string1, string2, string3);//Значение {X} заменяет переменную с опреденным порядком. 
            //После запятой по порядку пишут все нужные переменные
            string stringnull = null;
            bool nl = string.IsNullOrEmpty(stringnull);//Проверяет, является ли строка null пустой 
            Console.WriteLine(nl);
            var sb = new StringBuilder("Souls 2:");//класс stringbuilder позволяет свободно модифицировать строку
            Console.WriteLine(sb);//В отличие от класса string, он не ограничен неизменяемостью данных
            sb.Remove(6, 2);//Начиная с позиции строки 6 удаляет два символа "2:"
            Console.WriteLine(sb);
            string stroke = "Dark ";
            sb.Insert(0, stroke);//Метод класса stringbuilder добавляет в начале строки sb строку stroke
            string end = "2: Scholar for Sin";
            sb.AppendFormat(end);//Метод класса stringbuilder добавляет в конце строки sb строку end
            Console.WriteLine(sb);

            int[] A = new int[10];
            Random random = new Random();//создан экземпляр класса для создания рандомных чисел
            for (int z = 0; z < A.Length; i++)
            {
                A[i] = random.Next(10);//метод создания рандомных чисел
            }
            string stroke_new = "Animation";

            (int, int, int, char) task(int[] A, string stroke_new)//создание локальной функции 
            //значение (int, int, int, char) означает, что впоследствии в качестве результата функции можно использовать кортеж
            {
                int min = A[0], max = A[0], sum = 0;
                char first;
                for (int i = 0; i < A.Length; i++)
                {
                    if (min > A[i])
                    {
                        min = A[i];
                    }
                }
                for (int i = 0; i < A.Length; i++)
                {
                    if (max < A[i])
                    {
                        max = A[i];
                    }
                }
                for (int i = 0; i < A.Length; i++)
                {
                    sum = sum + A[i];
                }
                first = stroke[0];
                var result = (max, min, sum, first);//кортеж
                return result;
            }

            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };//создание двумерного массива
            int rows = numbers.GetUpperBound(0) + 1;//Считает сколько будет столбов
            int columns = numbers.Length / rows;//Считает сколько будет строк
            for (int z = 0; z < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[z, j]} \t");//вывод элементов массива
                }
                Console.WriteLine();
            }
            int[] massive = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(String.Join(", ", massive));//создание строки, где перечисляются с запятой все элементы массива
            Console.WriteLine("Длина: " + massive.Length);
            int index = 2;
            for (int z = index; z < massive.Length - 1; i++)
            {
                massive[i] = massive[i + 1];
            }
            Array.Resize(ref massive, massive.Length - 1);//изменяет размер одномерного массива
            Console.WriteLine(String.Join(", ", massive));
            int[][] stMass = new int[3][];//Создание ступенчатого двумерного массива
            stMass[0] = new int[2];//Каждый одномерный массив имеет разную длину
            stMass[1] = new int[3];
            stMass[2] = new int[4];

            for (int z = 0; z < stMass.Length; i++)
            {
                for (int j = 0; j < stMass[i].Length; j++)
                {
                    stMass[i][j] = random.Next(10);
                }
            }

            for (int z = 0; z < stMass.Length; i++)
            {
                for (int j = 0; j < stMass[i].Length; j++)
                {
                    Console.Write(stMass[i][j] + " ");
                }
                Console.WriteLine();
            }
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var stroke__new = "Hello_World";

            (int, string, char, string, ulong) t1 = (5, "Darkness", 'C', "Light", 125);//Создание кортежа разных типов
            Console.WriteLine($"Cortege elements: - {t1.Item1}, {t1.Item2}, {t1.Item3}, {t1.Item4}, {t1.Item5}");//t{x}.Item{x} означает, что мы вставляем в это место х элемент кортежа
            Console.WriteLine($"Cortege elements: - {t1.Item1}, {t1.Item3}, {t1.Item4}");
            Console.WriteLine($"Число {t1.Item5} больше, чем число {t1.Item1}");
            Console.WriteLine("{0} and {1} are unbounded", t1.Item2, t1.Item4);
            (int, int) t2 = (1, 2);
            (int, int) t3 = (1, 3);
            if (t2 == t3) Console.WriteLine("Equal");//Сравнение двух кортежей
            else Console.WriteLine("Not equal");
            Console.Write("Int separate: ");
            Console.WriteLine(123_456_789);

            void task1()
            {
                int num = int.MaxValue;
                try
                {
                    checked
                    {
                        Console.WriteLine(num + 1);
                    }
                }
                catch (ObjectDisposedException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            void task2()
            {
                int num = int.MaxValue;
                unchecked
                {
                    Console.WriteLine(num + 1);
                }
            }

            task1();//Здесь предполагается создание ошибки, так как превышено максимальное число типа Int
            task2();
        }
    }
    }
