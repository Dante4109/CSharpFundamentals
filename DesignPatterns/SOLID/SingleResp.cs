using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleFundies.DesignPatterns.SOLID
{
    public class Student
    {
        public int StudentId { get; set; }
        public string email { get; set; }
    }

    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class StudentRepository
    {

        // Serves as our DB connection
        public StudentDAL studentDAL = new StudentDAL();
        IList<Student> studentList = new List<Student>();

        public Student FetchByID(int id)
        {
            Student selectedStudent = new Student();
            selectedStudent = null;
            studentList = studentDAL.SelectAllStudents();

            try
            {
                var result = from s in studentList
                             where s.StudentId == id
                             select s;

                selectedStudent = result.First();

            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);
                Console.Write("Re-try with a different id.");
            }

            return selectedStudent;
        }

        public Student FetchByEmail(string email)
        {
            Student selectedStudent = new Student();
            studentList = studentDAL.SelectAllStudents();

            try
            {
                var result = from s in studentList
                             where s.email == email
                             select s;

                selectedStudent = result.First();
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);
                Console.Write("Re-try with a different email.");
            }

            return selectedStudent;
        }

        public bool Save(Student std)
        {
            Logger.Log("Starting Save()");

            //use EF to add a new student or update existing student to db

            Logger.Log("Ending Saving()");

            return true;
        }


        public bool Delete()
        {
            Logger.Log("Starting Delete()");

            //use EF to delete a student 

            Logger.Log("Ending Delete()");

            return true;
        }

        public bool SaveCourse(Student std, Course cs)
        {
            Logger.Log("Starting SaveCourse()");

            //use EF to save a course for a student

            Logger.Log("Ending SaveCourse()");

            return true;
        }

        public class StudentDAL
        {
            public IList<Student> SelectAllStudents()
            {
                IList<Student> studentList = new List<Student>();
                //Get the Students from the Database
                //for now we are hard coded the employees
                studentList.Add(new Student() { StudentId = 1, email = "FrankRush@School.com" });
                studentList.Add(new Student() { StudentId = 2, email = "JohnSmith@School.com" });
                studentList.Add(new Student() { StudentId = 3, email = "JoyBlum@School.com" });
                return studentList;
            }
        }
    }
}
