﻿using CRUD_MVC_dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC_dotnet.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddStudentViewModel viewModel )
        {
            return View();
        }
    }
}
