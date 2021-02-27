using Olbrasoft.AspNetCore.Mvc.X.PagedList.Example.Search;

namespace AspNetCore.Mvc.X.PagedList.Example.Search.Services
{
    public interface ISearchService
    {
        SearchResult GetSearchResult(string query, int page, int pageSize);
    }
}