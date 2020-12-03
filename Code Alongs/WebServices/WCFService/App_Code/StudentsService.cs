using EFDataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentsService" in code, svc and config file together.
public class StudentsService : IStudentsService
{
    StudentsModel dbContext = new StudentsModel();

    public List<Student> GetAllStudents()
    {
        var result = dbContext.Students.ToList();
        return result;
    }

    public Student GetStudentById(int studentId)
    {
        var result = dbContext.Students.Where(s => s.StudentId == studentId).FirstOrDefault();
        return result;
    }

    public List<Student> GetStudentsByCountry(string country)
    {
        var result = dbContext.Students.Where(s => s.Country == country).ToList();
        return result;
    }
}
