using BookLib.Models;
using BookLib.Models.ViewModels;
using BookLib.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookLib.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;

        public HomeController(ILogger<HomeController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.NewRelease = new ShowCase
            { 
                Books = 20, 
                CDs = 25,
                BookList = new List<BookSummarizedViewModel>
                { 
                    new BookSummarizedViewModel
                    {
                        Id = "1",
                        AuthorName = "Sarah Penner",
                        Title ="The Lost Apothecary",
                        Genre = "Non-Fiction",
                        PhotoUrl = "",
                        Stars = 5,
                        AvailabilityStatus = true,
                    },
                    new BookSummarizedViewModel
                    {
                        Id = "2",
                        AuthorName = "Ebele Okolo",
                        Title ="Kadara",
                        Genre = "Fiction",
                        PhotoUrl = "",
                        Stars = 4,
                        AvailabilityStatus = true,
                    },
                    new BookSummarizedViewModel 
                    {
                        Id = "3",
                        AuthorName = "Chinua Achebe",
                        Title = "Things Fall Apart",
                        Genre = "Non-Fiction",
                        PhotoUrl = "",
                        Stars = 4,
                        AvailabilityStatus = true,
                    },

                }


            };
            homeViewModel.Tabs = new Dictionary<string, List<string>>
            {
                { "Fiction", new List<string>{"Drama", "Horror", "Mistery", "Sci-fi"} },
                { "Non-Fiction", new List<string>{"Biograpy ", "Art", "Sports", "Travel"} },
                { "CD", new List<string>{"Blues", "Classical", "Folk", "Reggea", "Hip-Hop", "Rap", "Rock"} }
            };
            return View(homeViewModel); 
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
