using System;
using AspNetCoreBank.Controllers;
using AspNetCoreBank.Models;
using AspNetCoreBank.Services;
using Moq;
using Xunit;

namespace AspNetCoreBank.Tests
{
    public abstract class BaseClientControllerTests
    {
        protected readonly Client Client;
        protected readonly Mock<IClientService> MockService;
        protected readonly ClientController ControllerUnderTest;

        protected BaseClientControllerTests(Client client)
        {
            Client = client;
            MockService = new Mock<IClientService>();
            MockService
                .Setup(svc => svc.GetClient(It.IsAny<int>()))
                .ReturnsAsync(Client);
            ControllerUnderTest = new ClientController(MockService.Object);
        }
    }
}
