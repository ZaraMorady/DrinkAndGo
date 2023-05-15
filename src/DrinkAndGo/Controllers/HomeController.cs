﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DrinkAndGo.Data.interfaces;
using DrinkAndGo.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DrinkAndGo.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDrinkRepository _drinkRepository;
        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository; ;
        }


        // GET: /<controller>/
        public ViewResult Index()
        {
            var homeviewmodel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferredDrinks
            };
            return View(homeviewmodel);
        }
    }
}
