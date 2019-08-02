using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Serialization
{
    [DataContract]
    [Serializable]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        //protected 
        public int Rating;
        [DataMember]
        public Group Group { get; set; }
        public Student(string name, int rat, Group group)
        {
            Name = name;
            Rating = rat;
            Group = group;
        }
        
        public int GetRating()
            {
            return Rating;
            }
        public Student()
        { }
    }
    [DataContract]
    [Serializable]
    public class Group
    {
        [DataMember]
        public string Name { get; set; }
        public Group(string name)
        {
            Name = name;
        }
        public Group() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Alan", 55, new Group("C#")),
                new Student("Bob", 41, new Group("Java")),
                new Student("Tom", 76, new Group("JavaScript")),
                new Student("Ford", 25, new Group("C++")),
            };
            Console.WriteLine("Select type of serialize");
            string str = Console.ReadLine();
            switch (str)
            {
                case "Binary":
                    //binary
                    // создаем объект BinaryFormatter
                    BinaryFormatter formatter = new BinaryFormatter();
                    // получаем поток, куда будем записывать сериализованный объект
                    using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
                    {
                        //foreach (Student s in students)
                            formatter.Serialize(fs, students);

                        Console.WriteLine("Объект сериализован");
                    }
                    using (FileStream fs = new FileStream("people.dat", FileMode.OpenOrCreate))
                    {
                        List<Student> newStudent = (List<Student>)formatter.Deserialize(fs);
                        //foreach (Student s in newStudent)
                        //{
                        //    newStudent.Add((Student)formatter.Deserialize(fs));
                        //}
                       
                        foreach (Student sk in newStudent)
                        {
                            Console.WriteLine("Имя: {0} --- Рейтинг: {1} --- Група: {2}", sk.Name, sk.GetRating(), sk.Group.Name);
                        }
                        Console.WriteLine("Объект десериализован");
                    }
                    break;
                case "Soap":
                    //soap

                    // создаем объект SoapFormatter
                    SoapFormatter formatterS = new SoapFormatter();
                    // получаем поток, куда будем записывать сериализованный объект
                    using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
                    {
                        //foreach (Student s in students)
                            formatterS.Serialize(fs, students.ToArray());

                        Console.WriteLine("Объект сериализован");
                    }

                    // десериализация
                    using (FileStream fs = new FileStream("people.soap", FileMode.OpenOrCreate))
                    {
                        //List<Student> newStudent = new List<Student>();
                        Student[] newStudent = (Student[])formatterS.Deserialize(fs);
                        //foreach (Student s in newStudent)
                        //{
                        //    newStudent.Add((Student)formatterS.Deserialize(fs));
                        //}
                        foreach (Student s in newStudent)
                        {
                            Console.WriteLine("Имя: {0} --- Рейтинг: {1} --- Група: {2}", s.Name, s.GetRating(), s.Group.Name);
                        }
                        Console.WriteLine("Объект десериализован");
                    }
                    break;
                case "Xml":
                    //xml
                    Student[] newStudent1 = students.ToArray();

                    XmlSerializer formatterX = new XmlSerializer(typeof(Student[]));

                    // получаем поток, куда будем записывать сериализованный объект
                    using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
                    {
                        //foreach (Student s in students)
                            formatterX.Serialize(fs, newStudent1);

                        Console.WriteLine("Объект сериализован");
                    }

                    // десериализация
                    using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
                    {

                       // List<Student> newStudent = new List<Student>();
                        Student[] stud= (Student[])formatterX.Deserialize(fs);
                        //foreach (Student s in newStudent)
                        //{
                        //    newStudent.Add((Student)formatterX.Deserialize(fs));
                        //}
                        foreach (Student s in stud)
                        {
                            Console.WriteLine("Имя: {0} --- Рейтинг: {1} --- Група: {2}", s.Name, s.GetRating(), s.Group.Name);
                        }
                        Console.WriteLine("Объект десериализован");
                    }
                    break;
                case "Json":
                    //json
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));

                    using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
                    {
                        //foreach (Student s in students)
                            jsonFormatter.WriteObject(fs, students);
                    }

                    using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
                    {


                        List<Student> newStudent = (List<Student>)jsonFormatter.ReadObject(fs); 
                        //foreach (Student s in newStudent)
                        //{
                        //    newStudent.Add((Student)jsonFormatter.ReadObject(fs));
                        //}
                        foreach (Student s in newStudent)
                        {
                            Console.WriteLine("Имя: {0} --- Рейтинг: {1} --- Група: {2}", s.Name, s.GetRating(), s.Group.Name);
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

        }
    }
}
