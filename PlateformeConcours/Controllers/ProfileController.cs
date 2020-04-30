using PlateformeConcours.Filters;
using PlateformeConcours.Models;
using PlateformeConcours.Repositories;
using PlateformeConcours.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlateformeConcours.Controllers
{
	//all methods in this controller requires login
	[AuthFilter]
	public class ProfileController : Controller
    {
        HomeViewModel vm;
        public ProfileController()
        {
            vm = new HomeViewModel();

        }
        [HttpPost]
        public ActionResult Edit(Etudiant std)
        {

            //write code to update student 
            ApplicationDbContext db = new ApplicationDbContext();
            StudentRepository st = new StudentRepository(db);
            st.UpdateStudent(std);
            Session["etudiant"] = st.GetStudentByID(std.ID);
            //return Content(std.Cne);
            Session["updated"] = true;
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult logout()
        {
            Session["etudiant"] = null;
            return Redirect("/");

        }
        [HttpPost]
        public ActionResult EditNote(Note note)
        {
            if (ModelState.IsValid)
            {
                //write code to update student 
                ApplicationDbContext db = new ApplicationDbContext();
                StudentRepository st = new StudentRepository(db);
                st.UpdateStudentNote(note);
                Session["etudiant"] = st.GetStudentByID(note.EtudiantNoteId);
                //return Content(std.Cne);
                Session["updated"] = true;
                return RedirectToAction("Index");
            }
            ViewBag.error = true;
            return View(note);
        }
        public ActionResult Edit()
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            Etudiant etu = (Etudiant)Session["etudiant"];
            
            return View(etu);
        }
        public ActionResult EditNote()
        {
            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            Etudiant etu = (Etudiant)Session["etudiant"];

            return View(etu.Note);
        }
        // GET: Profile
        public ActionResult Index()
        {
            if (Session["updated"] != null)
            {
                Session["updated"] = null;
                ViewBag.done = true;
            }
            if (Session["etudiant"] != null)
            {
                vm.etudiant = (Etudiant)Session["etudiant"];

            }
            return View(vm);
        }
    }
}