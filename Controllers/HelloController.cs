// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace DojoSurvey.Controllers;
public class HelloController : Controller
{
    [HttpGet]
    [Route("")]

    //The below code looks like a function, right? However, in the context of a
    //  web application it is called an action.
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet]
    [Route("results")]
    public ActionResult Result()
    {
        return View("Result");
    }

    [HttpPost]
    [Route("process")]
    public IActionResult Process(string NameField,
    string DojoLocation, string FavoriteLanguage, string CommentField)
    {
        ViewBag.Name = NameField;
        ViewBag.Location = DojoLocation;
        ViewBag.Language = FavoriteLanguage;
        if (CommentField == null)
        {
            CommentField = "No Comment";
        }
        ViewBag.Comment = CommentField;
        return View("Result");
    }
}