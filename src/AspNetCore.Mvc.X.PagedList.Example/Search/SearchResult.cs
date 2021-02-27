using X.PagedList;

namespace Olbrasoft.AspNetCore.Mvc.X.PagedList.Example.Search
{
    public class SearchResult
    {
        public IPagedList<SearchHit> SearchHits { get; set; }

        public string SearchQuery { get; set; }
    }
}