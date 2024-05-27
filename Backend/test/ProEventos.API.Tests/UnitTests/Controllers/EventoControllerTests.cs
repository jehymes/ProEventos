using System.Net;
using FluentAssertions;
using ProEventos.API.Controllers;
using Xunit;

namespace ProEventos.API.Tests.UnitTests.Controllers
{
    public class EventoControllerTests
    {
        private EventoController eventoController;

        public EventoControllerTests(){
            eventoController = new EventoController(); //new Mock<T>().object
        }

        [Fact]
        public void Get_Evento_SuccessTest()
        {
            var response = eventoController.Get();
            // Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            // Assert.Equal("Exemplo de GET", response);
            response.Should().Be("Exemplo de GET");
        }
    }
}