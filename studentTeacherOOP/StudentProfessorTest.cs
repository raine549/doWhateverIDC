using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentTeacherOOP
{
    class StudentProfessorTest
    {
        // create a new person and make him say hello
        // create a new student, set an age, say hello, and display her age
        // create a new professor, say hello, and explain 

        Person person = new Person();
        Student student = new Student();
        Professor professor = new Professor();

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();

            Professor professor = new Professor();
            professor.Greet();
            professor.Explain();
        }
    }
}
