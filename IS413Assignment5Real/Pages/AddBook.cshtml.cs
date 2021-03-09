using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IS413Assignment5Real.Models;
using IS413Assignment5Real.Infrastructure;

namespace IS413Assignment5Real.Pages
{
// basically just info we need for the model of that page
    public class AddBookModel : PageModel
    {
        // create repository of books
        private IBooksRepository repository;
        // constructor
        public AddBookModel(IBooksRepository _repository)
        {
            repository = _repository;
        }

        //properties 
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            // sets count of total books
            ViewData["CartPrice"] = Cart.ComputeTotalSum();
            ViewData["CartQuantity"] = Cart.ComputeBookCount();
        }

        //post

        public IActionResult OnPost(long bookId, string returnUrl, string postType)
        {
            Book book = repository.Books.Where(b => b.BookId == bookId).FirstOrDefault();

            if (postType != "Deleting")
            {
                

                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(book, 1);
                HttpContext.Session.SetJson("cart", Cart);
                // count total books
                ViewData["CartQuantity"] = Cart.ComputeBookCount();
                ViewData["CartPrice"] = Cart.ComputeTotalSum(); 
                return RedirectToPage(new { returnUrl = returnUrl });
            }
            else
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart");
                Cart.RemoveItem(book);
                HttpContext.Session.SetJson("cart", Cart);

                ViewData["CartQuantity"] = Cart.ComputeBookCount();
                ViewData["CartPrice"] = Cart.ComputeTotalSum();
                return RedirectToPage(new { returnUrl = returnUrl });
            }
        }

    }
}
