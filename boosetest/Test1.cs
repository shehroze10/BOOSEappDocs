using Microsoft.VisualStudio.TestTools.UnitTesting;
using BOOSEapp;
using BOOSE;





namespace boosetest
{
   
 
    [TestClass]
    public class AppCanvasTests
    {
        private AppCanvas canvas;

       
        [TestInitialize]
        public void Setup()
        {
            canvas = new AppCanvas(600, 400);
        }

       
        [TestMethod]
        public void MoveTo_UpdatesPositionCorrectly()
        {
            
            int expectedX = 200;
            int expectedY = 150;

            
            canvas.MoveTo(expectedX, expectedY);

            
            Assert.AreEqual(expectedX, canvas.Xpos, "X position did not update correctly after MoveTo.");
            Assert.AreEqual(expectedY, canvas.Ypos, "Y position did not update correctly after MoveTo.");
        }

       
        [TestMethod]
        public void DrawTo_UpdatesPositionCorrectly()
        {
            // Arrange
            int newX = 300;
            int newY = 250;

            // Act
            canvas.DrawTo(newX, newY);

            // Assert
            Assert.AreEqual(newX, canvas.Xpos, "X position did not update correctly after DrawTo.");
            Assert.AreEqual(newY, canvas.Ypos, "Y position did not update correctly after DrawTo.");
        }

        
        [TestMethod]
        public void MultiLineProgram_ExecutesSuccessfully()
        {
            
            var factory = new AppCommandFactory();      
            var program = new StoredProgram(canvas);
            var parser = new Parser(factory, program);

            string code = @"
                moveto 100,150
                pen 0,0,255
                circle 150
                pen 255,0,0
                moveto 150,50
                rect 150,100
            ";

            
            parser.ParseProgram(code);
            program.Run();

            
            Assert.AreEqual(150, canvas.Xpos, "Final X position incorrect after multiline program.");
            Assert.AreEqual(50, canvas.Ypos, "Final Y position incorrect after multiline program.");
        }
    }
}
