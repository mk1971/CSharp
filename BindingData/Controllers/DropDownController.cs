using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BindingData.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BindingData.Controllers
{
    public class DropDownController : Controller
    {
        private readonly ApplicationUser _auc;

        public DropDownController(ApplicationUser auc)
        {
            _auc = auc;
        }

        public IActionResult Index()
        {
            List<Country> cl = new List<Country>();
            cl = (from c in _auc.country select c).ToList();
            cl.Insert(0, new Country { Cid = 0, Cname = "--Select Country Name--" });
            ViewBag.message = cl;
            return View();
        }
    }
}
