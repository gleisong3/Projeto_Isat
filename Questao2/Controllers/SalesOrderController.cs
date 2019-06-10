using System.Collections.Generic;
using System.Web.Mvc;

namespace Questao2.Controllers
{
    public class SalesOrderController : Controller
    {
        //
        // GET: /SalesOrder/

        public ActionResult Index()
        {
            // TODO: Retornar a coleção de pedidos de vendas (SalesOrder).
            var list = new List<Foo>() 
            { 
                new Foo()
                {
                    Title = "Title 1",
                    Description = "Description"
                },
                new Foo()
                {
                    Title = "Title 2",
                    Description = "Description"
                },
                new Foo()
                {
                    Title = "Title 3",
                    Description = "Description"
                },
                new Foo()
                {
                    Title = "Title 4",
                    Description = "Description"
                },
                new Foo()
                {
                    Title = "Title 5",
                    Description = "Description"
                }
            };

            return View(list);
        }

        //
        // GET: /SalesOrder/Create

        public ActionResult Create()
        {
            // TODO: Implementação.
            return View();
        } 

        //
        // POST: /SalesOrder/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            // TODO: Implementação.
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /SalesOrder/Edit/5
 
        public ActionResult Edit(int id)
        {
            // TODO: Implementação.
            return View();
        }

        //
        // POST: /SalesOrder/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            // TODO: Implementação.
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
        // POST: /SalesOrder/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // TODO: Implementação.
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
