using NUnit.Framework;
using ASE_Programming_Language;
using System.Drawing; // Include this if needed for other tests

/// <summary>
/// TestFixture for testing the CommandVariableAssignment class.
/// </summary>
[TestFixture]
public class CommandVariableAssignmentTests
{
    /// <summary>
    /// Tests whether the Execute method of CommandVariableAssignment correctly sets a variable in the Interpreter.
    /// </summary>
    [Test]
    public void Execute_ShouldSetVariableInInterpreter()
    {
        // Arrange: Set up the test environment.
        // Initialize an Interpreter instance.
        var interpreter = new Interpreter(); // Create an actual instance or use a mock/stub if appropriate.

        // Create an instance of CommandVariableAssignment with a test variable and value.
        var command = new CommandVariableAssignment("testVariable", 10);

        // Act: Execute the method under test.
        // Execute the command using the interpreter.
        command.Execute(interpreter);

        // Assert: Verify the expected outcome.
        // Retrieve the value of the test variable from the interpreter.
        int result = interpreter.GetVariableValue("testVariable"); // Assumes GetVariableValue method exists.

        // Check if the variable was set to the expected value.
        Assert.AreEqual(10, result);
    }
}
