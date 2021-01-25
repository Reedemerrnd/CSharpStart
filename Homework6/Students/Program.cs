using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Avdeev Roman
 * Переделать программу «Пример использования коллекций» для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;+
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);+
в) отсортировать список по возрасту студента;+
г) *отсортировать список по курсу и возрасту студента;+
д) разработать единый метод подсчета количества студентов по различным параметрам
выбора с помощью делегата и методов предикатов.+
*/
namespace Students
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
        public override string ToString()
        {
            return $"{firstName} {lastName},city {city}, age: {age}, course: {course}";
        }
    }

    class Program
    {
        static int ByAge(Student st1, Student st2)          
        {

            if (st1.age < st2.age) return -1;
            else if (st1.age > st2.age) return 1;
            else return 0;
        }
        // сортировка по курсу и возрасту
        static int ByCousreAndAge(Student st1, Student st2)
        {
            if (st1.course < st2.course) return -1;
            else if (st1.course == st2.course)
            {
                if (st1.age < st2.age) return -1;
                else if (st1.age > st2.age) return 1;
                else return 0;
            }
            else return 1;
        }
        // счетчики и метод подсчета через делегат
        static bool AgeMatch (Student st1)
        {
            return st1.age < 18;
        }
        static bool CityMatch (Student st)
        {
            return st.city == "Москва";
        }
        static int CountItems(List<Student> st,Predicate<Student> p)
        {
            var r = st.FindAll(p).Count();
            return r;
        }
        static void Main(string[] args)
        {
            int courseFive = 0;
            int courseSix = 0;
            List<Student> list = new List<Student>();
            int[] dic = new int[7];
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_6.csv",Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    int age = int.Parse(s[6]);
                    int course = int.Parse(s[5]);
                    //считаем студентов на 5 и 6 курсах
                    if (course == 5) courseFive++; 
                    else if (course == 6) courseSix++;
                    //частотный массив
                    if (age >= 18 && age <= 20) dic[course]++; 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");

                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("5 курс:{0}", courseFive);
            Console.WriteLine("6 курс:{0}", courseSix);
            Console.WriteLine("частотный по курсам 18-20 лет");
            for (int i = 1; i <7; i++)
            {
                Console.WriteLine($"{i} курс: {dic[i]}");
            }
            Console.WriteLine("sort by age");
            list.Sort(ByAge);
            foreach (var v in list) Console.WriteLine(v);
            Console.WriteLine("sort by course and age");
            list.Sort(ByCousreAndAge);
            foreach (var v in list) Console.WriteLine(v);
            Console.WriteLine();
            Console.WriteLine("count age<18");
            Console.WriteLine(CountItems(list,AgeMatch));
            Console.WriteLine("count city = Москва");
            Console.WriteLine(CountItems(list,CityMatch));
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }

}
