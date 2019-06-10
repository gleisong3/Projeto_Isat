using System.Web.Mvc;

/*
 *  Questão 2
 *  Faça um crud básico com listagem, edição e remoção de itens. 
 *  Crie as views que achar necessário. Modele as classes da maneira que achar mais interessante e como você faria no seu dia a dia. 
 *  Como listagem, deixamos por padrão o GridMVC, mas você pode usar outro que tenha mais facilidade.
 */
namespace Questao2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Olá, candidato!";

            return View();
        }
    }
}
