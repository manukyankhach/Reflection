using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflactionsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Получение типа через typeof:
            Type type = typeof(Person);
            Type type1 = typeof(Program);
            Console.WriteLine($"typeof - {type}");
            Console.WriteLine($"typeof - {type1}");

            //Получение типа через GetType:
            Person person = new Person("Jon", 35);
            Program program = new Program();
            Type type2 = person.GetType();
            Console.WriteLine($"GetType - {type2}");
            Console.WriteLine($"GetType - {program}");

            //Получение типа через Type.GetType():
            Type type3 = Type.GetType("ReflactionsExamples.Person", false, true);
            Type type4 = Type.GetType("ReflactionsExamples.Program", false, true);
            Console.WriteLine($"Type.GetType() - {type3}");
            Console.WriteLine($"Type.GetType() - {type4}");

            //Консольный вывод:
            Console.WriteLine($"type.Name - {type.Name}");
            Console.WriteLine($"type.FullName - {type.FullName}");
            Console.WriteLine($"type.Namespace - {type.Namespace}");
            Console.WriteLine($"type.Assembly - {type.Assembly}");
            Console.WriteLine($"type.AssemblyQualifiedName - {type.AssemblyQualifiedName}");
            Console.WriteLine($"type.IsValueType - {type.IsValueType}");
            Console.WriteLine($"type.IsClass - {type.IsClass}");

            //Поиск реализованных интерфейсов
            Type type5 = typeof(Person);
            Type [] getInterfaces = type5.GetInterfaces();
            foreach (Type item in getInterfaces)
            {
                Console.WriteLine($"Interfaces Items - {item}");
            }
            Console.ReadLine();
        }
    }
}
