using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EFDataAccessLibrary;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentsService" in both code and config file together.
[ServiceContract]
public interface IStudentsService
{
    [OperationContract]
    List<Student> GetAllStudents();

    [OperationContract]
    List<Student> GetStudentsByCountry(string country);

    [OperationContract]
    Student GetStudentById(int studentId);
}
