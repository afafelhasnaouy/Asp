using PlateformeConcours.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateformeConcours.Repositories
{
    public interface IStudent
    {
        void InsertStudent3emeAnnee(Etudiant Student); // C
        void InsertStudent4emeAnnee(Etudiant Student); // C

        IEnumerable<Etudiant> GetStudents(); // R

        Etudiant GetStudentByID(int StudentId); // R

        bool UpdateStudent(Etudiant Student); //U

        void DeleteStudent(int StudentId); //D

        void Save();

		Etudiant Login(string Cne, string Cin, string Password);
    }
}
