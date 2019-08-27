using System;
using System.Threading.Tasks;
using AspNetCoreBank.Controllers;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using AspNetCoreBank.Tests;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace AspNetCoreBank
{
    public class IndexTests : BaseClientControllerTests 
    {

        private static readonly Client FirstItem = new Client()
        {
            Id = 1,
            Document=95699120,
            Name = "Jury",
            Lastname = "Umanchuk",
            Date = DateTime.Now
        };

    public IndexTests()
        : base(FirstItem)
    {
    }

    [Fact]

    public async Task IndexGetViewModelShouldBeOfTypeTodoViewModel()
    {
            //Act
            var result = await ControllerUnderTest.Index(95699120);

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsAssignableFrom<ClientsViewModel>(viewResult.ViewData.Model);

    }

    }
    
}