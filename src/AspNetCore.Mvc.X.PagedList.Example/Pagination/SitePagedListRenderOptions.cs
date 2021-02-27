using Olbrasoft.AspNetCore.Mvc.TagHelpers;

namespace Olbrasoft.AspNetCore.Mvc.X.PagedList.Example.Pagination
{
    public class SitePagedListRenderOptions
    {
        public static PagedListRenderOptions Boostrap4
        {
            get
            {
                var option = PagedListRenderOptions.Bootstrap4Full;

                option.MaximumPageNumbersToDisplay = 5;

                return option;
            }
        }
    }
}