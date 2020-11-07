using Employee_Management.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Management.Controllers
{
    public class EmployeeController : Controller

    {
        employee_dbEntities dbObj = new employee_dbEntities();
        // GET: Employee
        public ActionResult Employee(employee_table model)
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult AddEmployee(employee_table model)
        {
            employee_table obj = new employee_table();
            if (ModelState.IsValid)
            {
                obj.id = model.id;
                obj.name = model.name;
                obj.email = model.email;
                obj.phone = model.phone;
                obj.address = model.address;
                obj.description = model.description;

                if (model.id == 0) {
                    dbObj.employee_table.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }
                
            }
            ModelState.Clear();
            return RedirectToAction("ViewEmployee");
        }

        public ActionResult ViewEmployee()
        {
            var result = dbObj.employee_table.ToList();
            return View(result);
        }

        public ActionResult DeleteEmployee(int id)
        {
            var result = dbObj.employee_table.Where(x => x.id == id).First();
            dbObj.employee_table.Remove(result);
            dbObj.SaveChanges();

            var list = dbObj.employee_table.ToList();
            return View(viewName: "ViewEmployee", list);

        }
    }
}