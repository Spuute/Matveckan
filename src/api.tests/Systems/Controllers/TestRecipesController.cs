using System.Collections.Generic;
using System.Threading.Tasks;
using api.Controllers;
using api.Entities;
using api.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace api.tests.System.Controllers;

public class TestRecipesController
{
    [Fact]
    public async Task Get_OnSuccess_ReturnesStatusCode200() {
        // Arrange
        var mockRecipesService = new Mock<IRecipeService>();
        var sut = new RecipesController(mockRecipesService.Object);

        mockRecipesService
            .Setup(service => service.GetAllRecipes())
            .ReturnsAsync(new List<Recipe>());


        // Act
        var result = (OkObjectResult)await sut.Get();

        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_OnSuccess_InvokesRecipeServiceExactlyOnce() {
        // Arrange
        var mockRecipesService = new Mock<IRecipeService>();

        mockRecipesService
            .Setup(service => service.GetAllRecipes())
            .ReturnsAsync(new List<Recipe>());

        var sut = new RecipesController(mockRecipesService.Object);

        // Act
        var result = await sut.Get();

        // Assert
        mockRecipesService.Verify(
            service => service.GetAllRecipes(),
            Times.Once());
    }
}