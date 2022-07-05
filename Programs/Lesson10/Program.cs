using System;
namespace Lesson10CSharp
{
    internal class Program
    {
        public static void Main()
        {
            Student[] studentsList = new Student[3];
            for (int i = 0; i < studentsList.Length; i++)
            {

                Console.WriteLine("Sisteme Telebe Elave ele");
                Console.WriteLine($"{i + 1} Telebe elave et");
                Console.WriteLine("FullName");
                string fn = Console.ReadLine();
                Console.WriteLine("GroupName");
                string gn = Console.ReadLine();
                Console.WriteLine("Age");
                byte age = Convert.ToByte(Console.ReadLine());
                studentsList[i] = new Student(fn, gn, age);
            }



            Console.WriteLine("1. Qrupa gore telebe sayini oyren  \n 2.Telebenin adina gore qrupunu tap  ");
            int axtarish = Int32.Parse(Console.ReadLine());
            switch (axtarish)
            {
                case 1:
                    Console.WriteLine("Grup nomresini daxil edin");
                    string grnum = Console.ReadLine();
                    Student.GroupNumCheck(grnum, studentsList);
                    break;
                case 2:
                    
                        Console.WriteLine("Telebenin adini daxil edin");
                        string stfn= Console.ReadLine();
                        Student.GroupNumCheck(stfn, studentsList);
                        break;
                    
                default:

                    Console.WriteLine("Duzgun secim olmadi");
                    break;


            }

        }

       
    }
    public class Student
    {
        public string FullName;
        public string GroupName;
        public byte Age;

        public Student(string fn, string gn, byte age)
        {
            FullName = fn;
            GroupName = gn;
            Age = age;
        }

        public static void GroupNumCheck(string grnumch, Student[] stdnts)
        {
            int count = 0;
            foreach(var item in stdnts)
            {
                if (item.GroupName == grnumch)
                {
                    count++;
                }
            }
            Console.WriteLine($"{grnumch}  grupunda {count} telebe var");
        }

        public static void FullNameGrNumCheck(string fn, Student[] stdnts)
        {
            foreach(var item in stdnts)
            {
                if(item.FullName == fn)
                {
                    Console.WriteLine($"{item.FullName}   {item.GroupName} grupunun telebesidir");
                }
            }
        }

    }
}