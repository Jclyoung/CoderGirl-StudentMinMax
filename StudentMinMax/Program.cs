using System;
using System.Collections.Generic;
using System.IO;

namespace StudentMinMax
{

    public class GetGradesFromFileData
    {

        public string filePath = @"C:\Users\jclyo\Source\Repos\CoderGirl-StudentMinMax\studentdata.txt";

        public static void Main()
        {
           
            List<Student> students = CreateStudent();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} Min: {student.GetMinimumScore()} Max: {student.GetMaximumScore()}");
            }

            Console.ReadLine();
        }

        private static List<string> GetStudentData(string filePath)
        {
            List<string> students = new List<string>();
            foreach (string line in File.ReadLines(filePath))
            {
                students.Add(line);
            }

            return students;
        }

        private static List<Student> CreateStudent()
        {
            string filePath = @"C:\Users\jclyo\Source\Repos\CoderGirl-StudentMinMax\studentdata.txt";
            List<string> newStudents = GetStudentData(filePath);
            List<Student> students = new List<Student>();
            string name = "";
            int[] scores = Array.Empty<int>();

            foreach (string newStudent in newStudents)
            {
                Student student = new Student(name, scores);
                string[] data = newStudent.Split(" ");
                name = data[0];
                scores = new int[data.Length - 1];

                for (int i = 0; i < data.Length; i++)
                {
                    if (i != 0)
                    {
                        scores[i-1] = Convert.ToInt32(data[i]);
                    }

                }

                student.Name = name;
                student.Scores = scores;
                students.Add(student);

            }

            return students;
        }
    }
}