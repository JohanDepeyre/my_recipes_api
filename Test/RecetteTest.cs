using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Application.DTO;
using Application.Managers.Interfaces;
using Data.Data;
using Data.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json;
using Presentation.Controllers;
using Xunit;
namespace Test
{

      public class UsersControllerTests
    {
        private readonly HttpClient _client;

        public UsersControllerTests()
        {
            _client  = new HttpClient(); ;
        }

        [Fact]
        public async Task Post_CreatesRecette_DoitRetournerNonNull()
        {
            // Arrange
            var mockRepo = new Mock<IRecetteManager>();
            var recette = new RecetteDto();
            mockRepo.Setup(repo => repo.CreateRecette(recette)).Returns(new RecetteDto());
            var controller = new RecetteController(mockRepo.Object);

            // Act
            var result = controller.PostRecette(recette);

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public async Task GetAllRecette_DoitRetournerNonNull()
        {

            // Arrange
            var mockRepo = new Mock<IRecetteManager>();

            mockRepo.Setup(repo => repo.GetRecette());
            var controller = new RecetteController(mockRepo.Object);

            // Act
            var result =  controller.GetRecette();

            // Assert
            Assert.NotNull(result);
        }
    }
    
}