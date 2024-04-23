using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProCRUD.Models;
using System.Data;


namespace ProCRUD.Controllers 
{ 
    public class DefaultController : Controller
    {
        // GET: Default
       Database1Entities2 db= new Database1Entities2();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Read()       
        {
           
            var members = db.Table.ToList();
       
            return View(members);
        }
        
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Table member)
        {
            
            db.Table.Add(member);
            db.SaveChanges();
            return RedirectToAction("Read");
        }
        
        public ActionResult Edit(int id) 
        {
          
            var member=db.Table.Where(model=>model.Id==id).FirstOrDefault(); ;
            return View(member);
        }
        [HttpPost]
        public ActionResult Edit(Table member)
        {
            
            var memberdata = db.Table.Where(m => m.Id == member.Id).FirstOrDefault();
            memberdata.Account = member.Account;
            memberdata.UserName = member.UserName;
            memberdata.Password = member.Password;
            memberdata.Email = member.Email;
            memberdata.Address = member.Address;
            db.SaveChanges();

            return RedirectToAction("read");

        }
       
        public ActionResult Delete(Table member)
        {
            var memberData = db.Table.Where(m => m.Id == member.Id).FirstOrDefault();
            db.Table.Remove(memberData);
            db.SaveChanges();
            return RedirectToAction("Read");
        
        }
    }
}