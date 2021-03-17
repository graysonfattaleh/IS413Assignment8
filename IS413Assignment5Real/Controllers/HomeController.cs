using IS413Assignment5Real.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IS413Assignment5Real.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using IS413Assignment5Real.Infrastructure;

namespace IS413Assignment5Real.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //makes private repository of type ibooks
        private IBooksRepository _repository;
        // determine number of items per page
        public int NumPages = 5;

        

        public HomeController(ILogger<HomeController> logger,IBooksRepository repository)
        {
            // home controller constructor guy has attribute _repository which is repository
            _logger = logger;
            _repository = repository;
            
            
            
        }

        public IActionResult Index(string filterer, int pageNum = 1)
        {
            // set for home nav book count and quant
            try
            {
                Cart cart = HttpContext.Session.GetJson<Cart>("cart");
               ViewData["CartQuantity"] = cart.ComputeBookCount(); 
                ViewData["CartPrice"] = cart.ComputeTotalSum(); 
            }
            catch
            {
                ViewData["CartQuantity"] = 0;
                ViewData["CartPrice"] = 0;
            };
            if (ModelState.IsValid)
            {
                // puts the list guy in sets
                return View(new BookListViewModel
                {
                    // setbooks
                    Books = _repository.Books.
                    Where(b=> filterer == null || filterer == b.Category).
                    OrderBy(b => b.Price).
                    Skip((pageNum - 1) * NumPages).
                    Take(NumPages),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = pageNum,
                        ItemsPerPage = NumPages,
                        // either uses all books or just books in cat
                        TotalItems =
                        filterer ==null ?  _repository.Books.Count() : _repository.Books.Where(b => b.Category == filterer).Count()
                    },
                    CurrentCategory = filterer

                }) ;

                   
            }
            else
            {
                return View();
            }
        }

        public IActionResult BookList()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
