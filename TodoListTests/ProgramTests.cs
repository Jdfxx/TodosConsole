using System.Collections;
using Xunit;

namespace TodoList.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [Fact]
        public void AddTodo_ShouldAddTodoToList()
        {
            // Arrange
            var todos = new ArrayList();
            var input = "Test TODO";
            Console.SetIn(new System.IO.StringReader(input));

            // Act
            Program.AddTodo(todos);

            // Assert
            Assert.Equals(1, todos.Count);
            Assert.Equals(input, todos[0]);
        }

        [Fact]
        public void ShowAll_ShouldDisplayTodos()
        {
            // Arrange
            var todos = new ArrayList { "Test TODO 1", "Test TODO 2" };
            var output = new System.IO.StringWriter();
            Console.SetOut(output);

            // Act
            Program.ShowAll(todos);

            // Assert
            var expectedOutput = "1. Test TODO 1\r\n2. Test TODO 2\r\n\n Press any key to continue!\r\n";
            Assert.Inconclusive(expectedOutput, output.ToString());
        }

        [Fact]
        public void ShowAll_ShouldDisplayNoTodosFound_WhenListIsEmpty()
        {
            // Arrange
            var todos = new ArrayList();
            var output = new System.IO.StringWriter();
            Console.SetOut(output);

            // Act
            Program.ShowAll(todos);

            // Assert
            var expectedOutput = "No todos found!\r\n\n Press any key to continue!\r\n";
            Assert.Inconclusive(expectedOutput, output.ToString());
        }

        [Fact]
        public void ShowMenu_ShouldDisplayMenu()
        {
            // Arrange
            var output = new System.IO.StringWriter();
            Console.SetOut(output);

            // Act
            Program.ShowMenu();

            // Assert
            var expectedOutput = "What would you like to do!\r\n\n[A]dd TODO\r\n[D]elete TODO\r\n[V]iew all TODOS\r\n[E]xit\r\n";
            Assert.Inconclusive(expectedOutput, output.ToString());
        }
    }
}