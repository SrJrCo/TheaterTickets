using fa23FinalProjectGroup14.DAL;
using fa23FinalProjectGroup14.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Norboev_Asilbek_HW4.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext db)
        {
            _context = db;
        }
        public ActionResult Index(String SearchString)
        {
            var query = from jp in _context.Movies select jp;
            if (SearchString == null)
            {
                ViewBag.AllMovies = _context.Movies.Count();
                //Populate the view bag with a count of selected job postings
                List<Movie> SelectedMovies = query.Include(jp => jp.Genre).ToList();
                ViewBag.SelectedMovies = SelectedMovies.Count();
                return View(SelectedMovies);
            }
            else
            {
                query = query.Where(jp => jp.Title.Contains(SearchString) || jp.Description.Contains(SearchString) || jp.Tagline.Contains(SearchString));
                List<Movie> SelectedMovies = query.Include(jp => jp.Genre).ToList();
                ViewBag.AllMovies = _context.Movies.Count();
                //Populate the view bag with a count of selected job postings
                ViewBag.SelectedMovies = SelectedMovies.Count();

                return View(SelectedMovies);
            }
        }

        public IActionResult DetailedSearch()
        {
            ViewBag.AllGenres = GetAllGenreSelectList();

            MovieSearchViewModel svm = new MovieSearchViewModel();

            svm.SelectedGenreID = 0;
            return View(svm);
        }

        private SelectList GetAllGenreSelectList()
        {
            //Get the list of months from the database (Select *)  
            //This would be Book in HW3
            List<Genre> GenreList = _context.Genres.ToList();

            //add a dummy entry so the user can select all months
            //type of Month class; name SelectNone -- creating a fake month
            //Don't want this in the DB, but needs to be in the drop down
            //code below creates new instance of Month Class, and add new item and set two properties

            //What happens if I choose MonthID that already exists?
            Genre SelectNone = new Genre() { GenreID = 0, GenreName = "All Genres" };

            //incrementally added this to monthList 
            GenreList.Add(SelectNone);

            SelectList GenreSelectList = new SelectList(GenreList.OrderBy(m => m.GenreID), "GenreID", "GenreName");

            //return the SelectList
            return GenreSelectList;
        }

        public ActionResult DisplaySearchResults(MovieSearchViewModel svm)
        {
            //*************************************************************************************
            //Code for string result
            var query = from jp in _context.Movies
                        select jp;

            if (svm.Title != null && svm.Title != "") //user entered something
            {
                //In this example, we are just showing the output.
                //In a real search, you would put a query here that 
                //selects records that match the name
                query = query.Where(jp => jp.Title.Contains(svm.Title));
            }
            //*************************************************************************************
            //code for searching GPA
            if (svm.Tagline != null && svm.Tagline != "")//they searched for something
            {
                query = query.Where(jp => jp.Tagline.Contains(svm.Tagline));
            }
            
            //if (svm.Rating != null)
            //{
            //    if (svm.TypeSearch == SearchType.Greater)
            //    {
            //        query = query.Where(jp => jp. >= svm.Salary);

            //    }
            //    else
            //    {
            //        query = query.Where(jp => jp.MinimumSalary <= svm.Salary);

            //    }
            //}
            if (svm.SelectedGenreID != 0)
            {
                query = query.Where(jp => jp.Genre.GenreID == svm.SelectedGenreID);
            }
            //go to the search view
            List<Movie> movies = query.Include(jp => jp.Reviews).ToList();
            //in a 'real' search, you would execute the query here and pass the selected records to the view
            ViewBag.AllJobs = _context.Movies.Count();
            //Populate the view bag with a count of selected job postings
            ViewBag.SelectedJobs = movies.Count();
            return View(movies);
        }

    }
}