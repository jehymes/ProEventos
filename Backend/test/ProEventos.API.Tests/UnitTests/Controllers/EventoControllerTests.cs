using FluentAssertions;
using Moq;
using ProEventos.API.Controllers;
using Xunit;

namespace ProEventos.API.Tests.UnitTests.Controllers
{
    public class EventoControllerTests
    {
        private readonly EventoController eventoController;

        public EventoControllerTests(){
            eventoController = new Mock<EventoController>().Object;
        }

        [Fact]
        public void Get_Evento_SuccessTest()
        {
            //Act
            var response = eventoController.Get();

            //Assert
            response.Should().BeEquivalentTo(eventoController._evento);
        }

        [Fact]
        public void GetById_Evento_SuccessTest()
        {
            //Arrange
            var compare = eventoController._evento.Where(evento => evento.EventoId == 1);
            
            //Act
            var response = eventoController.GetById(1);

            //Assert
            response.Should().NotBeNull();
            response.Should().BeEquivalentTo(compare);
        }
        
        [Fact]
        public void Post_Evento_SuccessTest()
        {
            //Arrange
            
            //Act
            var response = eventoController.Post();

            //Assert
            response.Should().NotBeNull();
            response.Should().Be("Exemplo de POST");
        }

        [Fact]
        public void Put_Evento_SuccessTest()
        {
            //Arrange
            
            //Act
            var response = eventoController.Put(1);

            //Assert
            response.Should().NotBeNull();
            response.Should().Be("Exemplo de PUT com id = 1");
        }

        [Fact]
        public void Delete_Evento_SuccessTest()
        {
            //Arrange
            
            //Act
            var response = eventoController.Delete(1);

            //Assert
            response.Should().NotBeNull();
            response.Should().Be("Exemplo de DELETE com id = 1");
        }
    }
}