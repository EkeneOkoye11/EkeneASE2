using NUnit.Framework;
using ASE_Programming_Language;
using System.Collections.Generic;
using System.Drawing;

/// <summary>
/// TestFixture for testing the CommandLoop class.
/// </summary>
[TestFixture]
public class CommandLoopTests
{
    /// <summary>
    /// Test to ensure that CommandLoop executes the contained commands the specified number of times.
    /// </summary>
    [Test]
    public void CommandLoop_ShouldExecuteCommandsMultipleTimes()
    {
        // Arrange: Setting up the test environment and objects.
        // Create a test command to monitor execution.
        var testCommand = new TestCommand();

        // Create a list of commands with the test command.
        var commands = new List<ICommand> { testCommand };

        // Create an interpreter instance for command execution.
        var interpreter = new Interpreter();

        // Define the loop count for the command loop.
        var loopCount = 3;

        // Create an instance of CommandLoop with the loop count and commands.
        var commandLoop = new CommandLoop(loopCount, commands);

        // Act: Execute the method being tested.
        commandLoop.Execute(interpreter);

        // Assert: Verify the outcome of the execution.
        // Check if the test command was executed the expected number of times.
        Assert.AreEqual(loopCount, testCommand.ExecutionCount);
    }
}
