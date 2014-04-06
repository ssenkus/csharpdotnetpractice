using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticalWebAPI.Controllers
{
    public class FileUploadController : Controller
    {
        //
        // GET: /FileUpload/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /FileUpload/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /FileUpload/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FileUpload/Create
        /*
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                
                
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        } */

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                var fileName = Path.GetFileName(file.FileName);

                Debug.WriteLine(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                var path = Path.Combine(Server.MapPath("~/Content/Uploads"), fileName);
                file.SaveAs(path);
            }
            // redirect back to the index action to show the form once again
            return RedirectToAction("Index");
        }


        //
        // GET: /FileUpload/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /FileUpload/Edit/5
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

        //
        // GET: /FileUpload/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /FileUpload/Delete/5
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
