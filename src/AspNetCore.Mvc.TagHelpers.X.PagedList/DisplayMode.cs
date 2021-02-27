namespace Olbrasoft.AspNetCore.Mvc.TagHelpers
{
    /// <summary>
    /// A tri-state enum that controls the visibility of portions of the PagedList paging control.
    /// </summary>
    public enum DisplayMode

    {
        /// <summary>
        /// Always render.
        /// </summary>
        Always,

        /// <summary>
        /// Never render.
        /// </summary>
        Never,

        /// <summary>
        /// Only render when there is data that makes sense to show (context sensitive).
        /// </summary>
        IfNeeded
    }
}