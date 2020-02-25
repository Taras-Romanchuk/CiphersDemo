﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CiphersDemo.CipherServices;
using CiphersDemo.Models;
using CiphersDemo.ViewModels;

namespace CiphersDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CaesarCipher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CaesarCipher(CaesarCipherViewModel caesarCipherViewModel)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                var caesarCipherData = new CaesarCipherData(caesarCipherViewModel.Shift);
                var cipherService = new CaesarCipherService(caesarCipherData);
                caesarCipherViewModel.OutputText = cipherService.Encrypt(caesarCipherViewModel.InputText);
            }

            return View(caesarCipherViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
