using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneBookNew.Models;

namespace PhoneBookNew.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            using (DBModel dbModel = new DBModel())
            {
                return View(dbModel.Contacts.ToList());
            }
                
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            using (DBModel dbModel = new DBModel())
            {
                return View(dbModel.Contacts.Where(x => x.Id == id).FirstOrDefault());
            }
                
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                using (DBModel dbModel = new DBModel())
                {
                    dbModel.Contacts.Add(contact);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModel dbModel = new DBModel())
            {
                return View(dbModel.Contacts.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Contact contact)
        {
            try
            {
                // TODO: Add update logic here

                using (DBModel dbModel = new DBModel())
                {
                    dbModel.Entry(contact).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModel dbModel = new DBModel())
            {
                return View(dbModel.Contacts.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModel dbModel = new DBModel())
                {
                    Contact contact = dbModel.Contacts.Where(x => x.Id == id).FirstOrDefault();
                    dbModel.Contacts.Remove(contact);
                    dbModel.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
