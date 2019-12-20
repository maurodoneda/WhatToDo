using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WhatToDo.Models;

namespace WhatToDo.Controllers
{
    public class ToDosController : Controller
    {
        public IActionResult Index()
        {
            List<ToDo> list = new List<ToDo>();

            list.Add(new ToDo { Id=1,Name = "Buy plane Tickes", Date = DateTime.Now, Duration = "1h" });
            list.Add(new ToDo { Id = 2, Name = "Study C#", Date = DateTime.Now, Duration = "3h" });

            return View(list);
        }
    }
}