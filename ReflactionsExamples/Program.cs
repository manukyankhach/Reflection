using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Console.WriteLine("------------------------------");

            //Получение типа через GetType:
            Person person = new Person("Jon", 35);
            Program program = new Program();
            Type type2 = person.GetType();
            Console.WriteLine($"GetType - {type2}");
            Console.WriteLine($"GetType - {program}");
            Console.WriteLine("------------------------------");

            //Получение типа через Type.GetType():
            Type type3 = Type.GetType("ReflactionsExamples.Person", false, true);
            Type type4 = Type.GetType("ReflactionsExamples.Program", false, true);
            Console.WriteLine($"Type.GetType() - {type3}");
            Console.WriteLine($"Type.GetType() - {type4}");
            Console.WriteLine("------------------------------");

            //Консольный вывод:
            Console.WriteLine($"type.Name - {type.Name}");
            Console.WriteLine($"type.FullName - {type.FullName}");
            Console.WriteLine($"type.Namespace - {type.Namespace}");
            Console.WriteLine($"type.Assembly - {type.Assembly}");
            Console.WriteLine($"type.AssemblyQualifiedName - {type.AssemblyQualifiedName}");
            Console.WriteLine($"type.IsValueType - {type.IsValueType}");
            Console.WriteLine($"type.IsClass - {type.IsClass}");
            Console.WriteLine("------------------------------");

            //Поиск реализованных интерфейсов
            Type type5 = typeof(Person);
            Type [] getInterfaces = type5.GetInterfaces();
            foreach (Type item in getInterfaces)
            {
                Console.WriteLine($"Interfaces Items - {item}");
            }
            Console.WriteLine("------------------------------");

            Type type6 = typeof(Person);
            MemberInfo[] memberInfo = type6.GetMembers();
            foreach (MemberInfo item in memberInfo)
            {
                Console.WriteLine($"item.Name - {item.Name},item.DeclaringType - {item.DeclaringType},item.MemberType - {item.MemberType}," +
                    $"item.MetadataToken - {item.MetadataToken}, item.CustomAttributes -{item.CustomAttributes}");
            }
            Console.WriteLine("------------------------------");

            Type type7 = Type.GetType("ReflactionsExamples.Person", false, true);
            var memberInfo2 = type7.GetMembers();
            Console.WriteLine($"memberInfo2[0].Name - {memberInfo2[0].Name}, memberInfo2[0].DeclaringType - {memberInfo2[0].DeclaringType}," +
                $"memberInfo2[0].MemberType - {memberInfo2[0].MemberType}");
            Console.WriteLine("------------------------------");

            Person person1 = new Person("Gag", 25);
            Type type8 = person1.GetType();
            MemberInfo[] memberInfo1 = type8.GetMembers(BindingFlags.DeclaredOnly
            | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var item in memberInfo1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");
            // получаем метод print
            MemberInfo[] memberInfos = type8.GetMember("Print", BindingFlags.Instance | BindingFlags.Public);
            foreach (var item in memberInfos)
            {
                Console.WriteLine($"{item.MemberType} - {item.Name}");
            }
            Console.ReadLine();
        }
    }
}
