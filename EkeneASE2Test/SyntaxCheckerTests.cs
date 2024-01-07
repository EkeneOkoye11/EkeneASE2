using NUnit.Framework;
using ASE_Programming_Language; // Ensure this is the correct namespace of the Form1 class containing CheckSyntax
using System.Security.Cryptography;

/// <summary>
/// TestFixture for testing the syntax checking functionality in Form1.
/// </summary>
[TestFixture]
public class SyntaxCheckerTests
{
    private IRandomNumberGenerator randomNumberGenerator;

    /// <summary>
    /// Tests whether the CheckSyntax method in Form1 correctly detects invalid 'set loop' commands.
    /// </summary>
    [Test]
    public void CheckSyntax_ShouldDetectInvalidSetLoopCommand()
    {
        // Arrange: Set up the test environment.
        // Initialize Form1 with a random number generator (if required).
        var syntaxChecker = new Form1(randomNumberGenerator);

        // Define an invalid command line.
        string[] lines = { "set loop ten" }; // Invalid because "ten" is not an integer.

        // Act: Perform the operation to be tested.
        // Call the CheckSyntax method with the invalid command line.
        var errors = syntaxChecker.CheckSyntax(lines);

        // Assert: Verify the outcome is as expected.
        // Check if the errors list contains the expected error message.
        Assert.That(errors, Has.Some.Contains("Invalid 'set loop' command."));
    }
}
