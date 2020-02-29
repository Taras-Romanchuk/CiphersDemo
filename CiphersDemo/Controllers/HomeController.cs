using System.Diagnostics;
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
        public IActionResult CaesarCipherEncrypt()
        {
            return View("CaesarCipher");
        }

        [HttpPost]
        public IActionResult CaesarCipherEncrypt(CaesarCipherViewModel caesarCipherViewModel)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                var caesarCipherData = new CaesarCipherData(caesarCipherViewModel.Shift);
                var cipherService = new CaesarCipherService(caesarCipherData);
                caesarCipherViewModel.OutputText = cipherService.Encrypt(caesarCipherViewModel.InputText);
            }

            return View("CaesarCipher", caesarCipherViewModel);
        }


        [HttpGet]
        public IActionResult CaesarCipherDecrypt()
        {
            return View("CaesarCipher");
        }

        [HttpPost]
        public IActionResult CaesarCipherDecrypt(CaesarCipherViewModel caesarCipherViewModel)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                var caesarCipherData = new CaesarCipherData(caesarCipherViewModel.Shift);
                var cipherService = new CaesarCipherService(caesarCipherData);
                caesarCipherViewModel.OutputText = cipherService.Decrypt(caesarCipherViewModel.InputText);
            }

            return View("CaesarCipher", caesarCipherViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
