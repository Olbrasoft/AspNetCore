using AspNetCore.Mvc.X.PagedList.Example.Search.Services;
using Microsoft.AspNetCore.Mvc;
using Olbrasoft.AspNetCore.Mvc.X.PagedList.Example.Models;
using Olbrasoft.AspNetCore.Mvc.X.PagedList.Example.Search;

namespace AspNetCore.Mvc.X.PagedList.Example.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService searchService;

        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        public IActionResult Index(string query, int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 5;
            var model = new SearchViewModel();

            if (string.IsNullOrWhiteSpace(query))
            {
                model.SearchResult = new SearchResult();
            }
            else
            {
                model.SearchResult = searchService.GetSearchResult(query, pageNumber, pageSize);
            }

            model.SearchResult.SearchQuery = query;

            return View(model);
        }
    }
}