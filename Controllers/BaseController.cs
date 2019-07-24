using System;
using Microsoft.AspNetCore.Mvc;

public class BaseController : Controller
{
    public ActionResult HandleExceptions(Func<ActionResult> logic)
    {
        try
        {
            return logic();
        }
        catch(Exception ex)
        {
            return View("Error", ex);
        }   
    }
}