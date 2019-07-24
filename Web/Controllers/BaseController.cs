using System;
using Microsoft.AspNetCore.Mvc;
using DatabaseFrontEnd;
using Microsoft.Extensions.Configuration;

public class BaseController : Controller
{
    protected DatabaseFrontEnd.Database DB;
    protected IConfiguration configuration;

    public BaseController(IConfiguration _config)
    {
        DB = new DatabaseFrontEnd.Database(_config.GetConnectionString("warchest"));
    }

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