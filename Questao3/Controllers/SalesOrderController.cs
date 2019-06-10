using Questao2.Application;
using Questao2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Questao2.Controllers
{
    public class SalesOrderController : Controller
    {
        // GET: SalesOrder
        public ActionResult Index()
        {
            var itemApplicationADO = new ItemApplicationADO();
            var list = itemApplicationADO.SelectAll();

            return View(list);
        }


        // GET: SalesOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesOrder/Create
        [HttpPost]
        public ActionResult Create(Item item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var itemApplicationADO = new ItemApplicationADO();

                    itemApplicationADO.Save(item);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: SalesOrder/Edit/5
        public ActionResult Edit(int id)
        {
            var itemApplicationADO = new ItemApplicationADO();
            var item = itemApplicationADO.SelectById(id);

            if (item == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(item);
            }
        }

        // POST: SalesOrder/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Item item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var itemApplicationADO = new ItemApplicationADO();

                    itemApplicationADO.Save(item);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: SalesOrder/Delete/5
        public ActionResult Delete(int id)
        {
            var itemApplicationADO = new ItemApplicationADO();
            var item = itemApplicationADO.SelectById(id);

            if (item == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(item);
            }
        }

        // POST: SalesOrder/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var itemApplicationADO = new ItemApplicationADO();
                itemApplicationADO.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
