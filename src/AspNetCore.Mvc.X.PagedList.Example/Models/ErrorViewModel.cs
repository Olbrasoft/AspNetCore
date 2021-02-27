using System;

namespace Olbrasoft.AspNetCore.Mvc.X.PagedList.Example.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}