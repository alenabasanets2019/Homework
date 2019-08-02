using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//05.07
namespace linq
{
    //Студенти(string ім'я, double рейтинг)
    class Students
    {
        public string Name
        {
            get; set;
        }
        public List<string>  courses = new List<string>();
        public double Rating
        {
            get; set;
        }
        public Students (string name, List<string> courses, double rat, string ng)
        {
            Name = name;
            courses = new List<string>();
            Rating = rat;
            NameOfGroups = ng;

        }
    public string NameOfGroups
        {
            get; set;
        }
    }
    //Групи(string Назва, string напрямок)
    class Groups
    {
        public string NameOfGroups
        {
            get; set;
        }
        public string course
        {
            get; set;
        }
        public Groups(string name, string course)
        {
            NameOfGroups = name;
            this.course = course;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>
            {
                new Students("Tom", new List<string>{"JavaScript"},88, "lv-414"),
                new Students ("Bob",  new List<string> {"Requariments"}, 75.4, "lv-387"),
                new Students ("Jon", new List<string> { "JavaScript" }, 63.2, "lv-414"),
                new Students ("Elis", new List<string> {"Test Estimation","JavaScript"}, 76, "lv-308")
            };

            var selectedStudents0 = from student in students
                                   from crs in student.courses
                                   where crs == "JavaScript"
                                   && student.Name.Contains('a')
                                    select student;
            var selectedStudents = students.SelectMany(s => s.courses,
                            (s, c) => new { Students = s, crss = c })
                            .Where(s => s.crss == "JavaScript" && s.Students.Name.Contains('a'));
                            //.Select(s => s.crss);
            foreach (var st in selectedStudents)
                Console.WriteLine("{0} - {1}", st.Students.Name, st.crss);
            int[] arr = { 5, 8, 3, 2, 2, 1, 4 };
            var mult = arr.Where(i=> i%2 != 0).Aggregate((x, y) => x * y);
            Console.WriteLine(mult);
            //grouping
            List<Groups> groups = new List<Groups>
            {
                new Groups("lv-414", "JavaScript"),
                new Groups ("lv-315",  "SQL"),
                new Groups ("lv-387", "C#"),
                new Groups ("lv-308", "Test Estimation")
            };
            
            var result2 =groups.GroupJoin(
                        students, // второй набор
                        t => t.NameOfGroups, // свойство-селектор объекта из первого набора
                        pl => pl.NameOfGroups, // свойство-селектор объекта из второго набора
                        (group, student) => new  // результирующий объект
                        {
                            Name = group.NameOfGroups,
                            Course = group.course,
                            studentname = student.Select(n => n.Name),
                            averagerat = (student.Select(r => r.Rating)).Sum() / student.Count()
                            
                        });
            
            foreach (var item in result2)
                Console.WriteLine("{0} - {1} ({2})", item.Name, item.Course, item.studentname, item.averagerat);
            //foreach (IGrouping<List<string>, Students> g in studentsGroups)
            //{
            //    Console.WriteLine(g.Key);
            //    foreach (var t in g)
            //        Console.WriteLine(t.Name);
            //    Console.WriteLine();
            //}
        }
    }
}
