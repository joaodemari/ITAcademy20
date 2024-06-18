using _01_Controller.Models;
using _01_Controller.Services;
using Microsoft.AspNetCore.Mvc;

public class CEPController : Controller
{
    private ICEPService myService;

    public CEPController(ICEPService ics){
        myService=ics;
    }

    public IActionResult lista(){
        return View(myService.listaTodosOsCEPs());
    }

    public IActionResult cadastra(){
        return View();
    }

    [HttpPost]
    public IActionResult cadastra(CEPViewModel novoCEP){
        myService.cadastreUmCEP(novoCEP);
        return View("lista",myService.listaTodosOsCEPs());
    }

}