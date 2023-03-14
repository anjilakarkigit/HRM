using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class JobsController : Controller
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        //return all the jobs so that candidates can apply to the job
        return View();
    }
    
    //get the job detailed information
    [HttpGet]
    public IActionResult Details(int id)
    {
        return View();
    }
    
    //Users should be authenticated and user should have role for creating new job
    //HR/Manager
    [HttpPost]
    public IActionResult Create()
    {
        //take the information from the View and save to DB
        return View();
    }
}