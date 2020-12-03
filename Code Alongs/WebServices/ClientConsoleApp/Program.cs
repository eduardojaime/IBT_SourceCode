using ClientConsoleApp.StudentsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsServiceClient client = new StudentsServiceClient();

            var results = client.GetStudentsByCountry("Colombia");

            foreach (Student student in results)
            {
                Console.WriteLine(String.Format("{0} {1} - {2}", student.FirstName, student.LastName, student.EmailAddr));
            }

            Console.ReadKey();

        }
    }
}
