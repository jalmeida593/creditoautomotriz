using CreditoAutomotriz.Entities;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace CreditoAutomotriz.XUnitTest
{
    public class CreditoAutomotrizUnitTests
    {
        private object formFile;

        [Fact]
        public async Task Leer_ArchivoTest_True()
        {
            //Arrange 
            var pp = File.ReadAllLines("//localhost/Users/Jonat/Desktop/UploadedFiles/Marcas/cmarcas.csv");
            //Act 
            if (pp != null)
            {
                    
            }

            //Assert
            Assert.True(true);
        }
    }
}