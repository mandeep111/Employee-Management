using Employee_Management.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Management.Controllers
{
    public class EmployeeController : Controller

    {
        employee_dbEntities dbObj = new employee_dbEntities();
        // GET: Employee
        public ActionResult Employee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(employee_table model)
        {
            employee_table obj = new employee_table();
            obj.name = model.name;
            obj.email = model.email;
            obj.phone = model.phone;
            obj.address = model.address;
            obj.description = model.description;

            dbObj.employee_table.Add(obj);
            dbObj.SaveChanges();
            return View(viewName: "Employee");
        }
    }
}