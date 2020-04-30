using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using PlateformeConcours.Models;

namespace PlateformeConcours.Repositories
{
	public class StudentRepository : IStudent
	{
		private ApplicationDbContext DBcontext;

		public StudentRepository(ApplicationDbContext dbContext)

		{

			this.DBcontext = dbContext;

		}
		public void DeleteStudent(int StudentId)
		{
			throw new NotImplementedException();
		}

		public Etudiant GetStudentByID(int StudentId)
		{
            return DBcontext.Etudiants.Include("Note").Include("Filiere").First(e => e.ID==StudentId);
		}

		public IEnumerable<Etudiant> GetStudents()
		{
			throw new NotImplementedException();
		}

		public void InsertStudent3emeAnnee(Etudiant Student)
		{
			try
			{
				//here we store the student 
				DBcontext.Etudiants.Add(Student);
				// then we create a third year student object where we give it the id of the previous student stored in the database
				Etudiant3a etudiant3 = new Etudiant3a();
				etudiant3.EtudiantId = Student.ID;
				DBcontext.Etudiants3a.Add(etudiant3);
				DBcontext.SaveChanges();
			}
			catch (Exception e)
			{
				e.GetBaseException();
			}


		}

		public void InsertStudent4emeAnnee(Etudiant Student)
		{
            try
            {
                //here we store the student 
                DBcontext.Etudiants.Add(Student);
                // then we create a third year student object where we give it the id of the previous student stored in the database
                Etudiant4a etudiant4 = new Etudiant4a();
                etudiant4.EtudiantId = Student.ID;
                DBcontext.Etudiants4a.Add(etudiant4);
                DBcontext.SaveChanges();
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }

        }

        public void Save()
		{
			throw new NotImplementedException();
		}
        public bool UpdateStudentNote(Note note)
        {
            DBcontext.Entry(note).State = System.Data.Entity.EntityState.Modified;
            try
            {
                if (DBcontext.SaveChanges() > 0)
                {
                    return true;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            return false;
        }


        public bool UpdateStudent(Etudiant Student)
		{
            DBcontext.Entry(Student).State=System.Data.Entity.EntityState.Modified;
            try
            {
                if (DBcontext.SaveChanges() > 0)
                {
                    return true;
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            return false;
		}
		public Etudiant Login(string Cne, string Cin, string Password)
		{
			Password = Utils.Utils.CalculateMD5Hash(Password);
			//var etu = DBcontext.Etudiants.Where(e => e.Cin.Equals(Cin) && e.Cne.Equals(Cne) && md5.GetHashCode().ToString().Equals(e.Password)).FirstOrDefault();
			var etu = (from e in DBcontext.Etudiants
					   where
						 e.Cin.Equals(Cin,StringComparison.OrdinalIgnoreCase) && e.Cne.Equals(Cne, StringComparison.OrdinalIgnoreCase)
						 && Password.Equals(e.Password, StringComparison.OrdinalIgnoreCase)
											   select e).FirstOrDefault();
			return etu;
		}

	}
}