using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Moq;
using Olbrasoft.AspNetCore.Mvc.TagHelpers;
using System;
using Xunit;

namespace AspNetCore.Mvc.TagHelpers.X.PagedList.Tests
{
    public class PagerTagHelperTest
    {
        [Fact]
        public void Instance_Inherit_From_TagHelper()
        {
            //Arrange
            var type = typeof(TagHelper);

            var UrlHelperFactoryMock = new Mock<IUrlHelperFactory>();

            //Act
            var helper = new PagerTagHelper(UrlHelperFactoryMock.Object);

            //Assert
            Assert.IsAssignableFrom(type, helper);
        }
    }
}