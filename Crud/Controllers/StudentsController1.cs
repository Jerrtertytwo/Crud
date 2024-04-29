using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    public class StudentsController1 : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddStudentViewModel viewModel)
        {
            return View();
       }
            
    }
}
