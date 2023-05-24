using BethanysPieShop.Controllers;
using BethanysPieShop.ViewModels;
using BethanysPieShopTests.Mocks;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopTests.Controllers;

public class HomeControllerTests
{
    [Fact]
    public void Index_Use_PieOfTheWeeks_FromRepository()
    {
        var mockPieRepository = RepositoryMocks.GetPieRepository();

        HomeController homeController = new HomeController(mockPieRepository.Object);

        var result = homeController.Index();

        Assert.NotNull(result);
        var homeViewModel = Assert.IsAssignableFrom<HomeViewModel>(result.Model);

        var piesOfTheWeek = homeViewModel?.PiesOfTheWeek?.ToList();
        Assert.NotNull(piesOfTheWeek);
        Assert.True(piesOfTheWeek?.Count() == 3);
        Assert.Equal("Apple Pie", piesOfTheWeek?[0].Name);
    }
}
