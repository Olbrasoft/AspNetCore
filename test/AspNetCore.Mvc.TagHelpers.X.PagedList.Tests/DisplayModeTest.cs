using Olbrasoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AspNetCore.Mvc.TagHelpers.X.PagedList.Tests
{
    public class DisplayModeTest
    {
        [Theory]
        [InlineData(DisplayMode.Always)]
        [InlineData(DisplayMode.Never)]
        [InlineData(DisplayMode.IfNeeded)]
        public void TestNumber(DisplayMode number)
        {
            Assert.True((Convert.ToInt32(number) >= 0));
        }
    }
}