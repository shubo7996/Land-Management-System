﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using TataSteel.Models;
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace TataSteel.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDB Context = new EmployeeDB();

        // GET: Employee
        public ActionResult Index()
        {
            var employeeDetails = Context.employees.FindAll().ToList();
            return View(employeeDetails);
        }

        // GET: Employee/Details/5
        public ActionResult Details(string id)
        {
            var empID = Query<EmployeeModel>.EQ(p => p.ID, new ObjectId(id));
            var empDetails =Context.employees.FindOne(empID);
            return View(empDetails);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(EmployeeModel employeemodel)
        {
            var document = Context.employees;
           
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var result = document.Insert(employeemodel);
                }
                else
                {
                    TempData["Message"] = "Enter Valid Details";
                    return View("Create", employeemodel);
                }

            return RedirectToAction("Index");
            
            
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
