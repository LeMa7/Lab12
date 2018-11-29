using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Reflector
    {
        public static void ShowClassInfo(Type t)
        {
            StreamWriter sw = new StreamWriter("ClassInfo.txt");
            sw.WriteLine("Информация о классе : ");
            sw.WriteLine("Full Name : " + t.FullName);
            sw.WriteLine("Is class : " + t.IsClass);
            sw.WriteLine("Is sealed : " + t.IsSealed);
            sw.WriteLine("Is abstract : " + t.IsAbstract); 

            sw.Close();
        }

        public static void ShowMethods(Type t)
        {
            Console.WriteLine("Методы:");
            foreach (MethodInfo i in t.GetMethods())
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();
        }

        public static void ShowFieldsAndProperties(Type t)
        {
            Console.WriteLine("Поля:");
            foreach (FieldInfo i in t.GetFields())
            {
                Console.WriteLine(i.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Свойства:");
            foreach (PropertyInfo i in t.GetProperties())
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();
        }

        public static void ShowInterfaces(Type t)
        {
            Console.WriteLine("Интферфейсы:");
            foreach(Type i in t.GetInterfaces())
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();
        }

        public static void ShowMethodsWithParameter(Type t,string str)
        {
            Console.WriteLine("Методы с параметром " + str + ":");
            foreach(MethodInfo i in t.GetMethods())
            {
                foreach(ParameterInfo f in i.GetParameters())
                {
                    if (f.Name.Contains(str))
                    {
                        Console.WriteLine(i.Name);
                    }
                }
            }
            Console.WriteLine();
        }

        public static void RunMethodWithParamsFromFile(Type t,string str)
        {
            StreamReader sr = new StreamReader("FileWithParams.txt");
            string param = sr.ReadLine();
            MethodInfo mt = t.GetMethod(str);
            object o = Activator.CreateInstance(typeof(Candy));
            mt.Invoke(o, new object[] { param });

        }
    }
}
