using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class StudentArrayOfObjects
    {
        int StuId;
        string StudName;
        string email;
        long phone;
        //Array of student object
        StudentArrayOfObjects[] student;

        public void StoreStudent()
        {
            Console.WriteLine("Enter size of array:");
            int val=int.Parse(Console.ReadLine());
            student = new StudentArrayOfObjects[val];

            for(int i=0;i<val;i++)
            {
                student[i] = new StudentArrayOfObjects();

                Console.WriteLine("Enter Student id:");
                student[i].StuId=int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name:");
                student[i].StudName = Console.ReadLine();

                Console.WriteLine("Enter Student email-id:");
                student[i].email =Console.ReadLine();

                Console.WriteLine("Enter Student phone no:");
                student[i].phone = long.Parse(Console.ReadLine());


            }

        }

        // search student by id
        public void SearchById(int id)
        {
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].StuId == id)
                {
                    Console.WriteLine("{0} {1} {2} {3}", student[i].StuId, student[i].StudName, student[i].email, student[i].phone, "\n");
                    return;
                }
            }
            Console.WriteLine("Student not found");
        }


        // search student by name
        public void SearchByName(string Name)
        {
            for (int i = 0; i < student.Length; i++)
            {
                if (student[i].StudName == Name)
                {
                    Console.WriteLine("{0} {1} {2} {3}", student[i].StuId, student[i].StudName, student[i].email, student[i].phone, "\n");
                    return;
                }
            }
            Console.WriteLine("Student not found");
        }

        public void print()
        {
            for(int i=0;i<student.Length;i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", student[i].StuId, student[i].StudName, student[i].email, student[i].phone,"\n");

            }
            
        }
    }
}
