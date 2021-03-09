using System;
using Microsoft.AspNetCore.Mvc;
using IS413Assignment5Real.Models;
using System.Linq;

namespace IS413Assignment5Real.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IBooksRepository repository;


        public NavigationMenuViewComponent(IBooksRepository ib)
        {
            repository=  ib ;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedFilter = RouteData?.Values["filterer"];
            return View(repository.Books
                .Select(b => b.Category)
                .Distinct().OrderBy(b => b));
        }
 
    }
}
