using Olbrasoft.AspNetCore.Mvc.TagHelpers;

namespace Olbrasoft.AspNetCore.Mvc.TagHelpers
{
    ///<summary>
    /// Options for configuring the output of <see cref = "HtmlHelper" />.
    ///</summary>
    public partial class PagedListRenderOptions
    {
        private static void SetMinimalOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = DisplayMode.Never;
            option.DisplayLinkToLastPage = DisplayMode.Never;
            option.DisplayLinkToPreviousPage = DisplayMode.Always;
            option.DisplayLinkToNextPage = DisplayMode.Always;
            option.DisplayLinkToIndividualPages = false;
        }

        private static void SetPageNumbersOnlyOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = DisplayMode.Never;
            option.DisplayLinkToLastPage = DisplayMode.Never;
            option.DisplayLinkToPreviousPage = DisplayMode.Never;
            option.DisplayLinkToNextPage = DisplayMode.Never;
            option.DisplayLinkToIndividualPages = true;
        }

        private static void SetPageNumbersPlusPrevAndNextOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = DisplayMode.Never;
            option.DisplayLinkToLastPage = DisplayMode.Never;
            option.DisplayLinkToPreviousPage = DisplayMode.Always;
            option.DisplayLinkToNextPage = DisplayMode.Always;
            option.DisplayLinkToIndividualPages = true;
        }

        private static void SetPageNumbersPlusFirstAndLastOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = DisplayMode.Always;
            option.DisplayLinkToLastPage = DisplayMode.Always;
            option.DisplayLinkToPreviousPage = DisplayMode.Never;
            option.DisplayLinkToNextPage = DisplayMode.Never;
            option.DisplayLinkToIndividualPages = true;
        }

        private static void SetFullOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = DisplayMode.Always;
            option.DisplayLinkToLastPage = DisplayMode.Always;
            option.DisplayLinkToPreviousPage = DisplayMode.Always;
            option.DisplayLinkToNextPage = DisplayMode.Always;
            option.DisplayLinkToIndividualPages = true;
        }

        /// <summary>
        /// Only show Previous and Next links.
        /// </summary>
        public static PagedListRenderOptions Minimal
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetMinimalOption(option);

                return option;
            }
        }

        /// <summary>
        /// Only show Page Numbers.
        /// </summary>
        public static PagedListRenderOptions PageNumbersOnly
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetPageNumbersOnlyOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus Previous and Next links.
        /// </summary>
        public static PagedListRenderOptions PageNumbersPlusPrevAndNext
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetPageNumbersPlusPrevAndNextOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus First and Last links.
        /// </summary>
        public static PagedListRenderOptions PageNumbersPlusFirstAndLast
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetPageNumbersPlusFirstAndLastOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus Previous, Next, First and Last links.
        /// </summary>
        public static PagedListRenderOptions Full
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetFullOption(option);

                return option;
            }
        }
    }
}