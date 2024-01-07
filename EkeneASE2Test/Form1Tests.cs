using NUnit.Framework;
using ASE_Programming_Language;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ASE_Programming_LanguageTests
{
    /// <summary>
    /// TestFixture for testing Form1 class functionalities.
    /// </summary>
    [TestFixture]
    public class Form1Tests
    {
        private IRandomNumberGenerator randomNumberGenerator;
        private object expectedCount;

        /// <summary>
        /// Tests whether GenerateRandomCommands in Form1 creates the specified number of commands.
        /// </summary>
        [Test]
        public void GenerateRandomCommands_ShouldCreateSpecifiedNumberOfCommands()
        {
            // Arrange: Set up the testing environment.
            var testRandom = new TestableRandomNumberGenerator(50); // Use a fixed value for testing.
            var form = new Form1(testRandom);
            int numberOfCommands = 10;

            // Act: Perform the operation to be tested.
            var commands = form.GenerateRandomCommands(numberOfCommands);

            // Assert: Verify the outcome is as expected.
            Assert.AreEqual(numberOfCommands, commands.Count, "Incorrect number of commands generated.");
        }

        /// <summary>
        /// Tests concentric circle drawing functionality in Form1 for varying gaps.
        /// </summary>
        [Test]
        public void ExecuteMultiLineCommands_ShouldDrawConcentricCirclesWithVaryingGaps()
        {
            // Arrange
            var form = new Form1(new TestableRandomNumberGenerator(50));
            string commandText = "size = count *"; // Example command text.

            // Act
            form.ExecuteMultiLineCommands(commandText);

            // Assert
            int expectedGapMultiplier = 0; 
            Assert.AreEqual(expectedGapMultiplier, form.LastGapMultiplier, "Gap multiplier was not calculated correctly.");
        }

        /// <summary>
        /// Tests multiline if command processing in Form1.
        /// </summary>
        [Test]
        public void ExecuteMultiLineCommands_ShouldProcessCommandsCorrectly()
        {
            // Arrange
            var form = new Form1(randomNumberGenerator);
            string commandText = "set number 10\nif size > 10\nendif";

            // Act
            form.ExecuteMultiLineCommands(commandText);

            // Assert
            int expectedNumber = (int)0.0d; // Example expected value.
            Assert.AreEqual(expectedNumber, form.Number, "Number was not set correctly.");
        }

        /// <summary>
        /// Tests whether GenerateShapes in Form1 creates the expected number of shapes.
        /// </summary>
        [Test]
        public void GenerateShapes_ShouldCreateExpectedNumberOfShapes()
        {
            // Arrange
            var form = new Form1(randomNumberGenerator);
            int expectedNumberOfShapes = 6; // Example expected value.

            // Act
            var shapes = form.GenerateShapes();

            // Assert
            Assert.AreEqual(expectedNumberOfShapes, shapes.Count, "The number of shapes generated was not as expected.");
        }
    }
}
