using System.Collections;
using TodoList;

namespace TodoListTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void AddTodo_ShouldAddTodoToList()
        {
            // Arrange
            var program = new Program();
            var todos = new ArrayList();
            var input = "Test TODO";
            Console.SetIn(new StringReader(input));

            // Act
            program.AddTodo(todos);

            // Assert
            Assert.AreEqual(1, todos.Count);
            Assert.AreEqual(input, todos[0]);
        }

        [TestMethod]
        public void ShowAll_ShouldDisplayTodos()
        {
            // Arrange
            var program = new Program();
            var todos = new ArrayList { "Test TODO 1", "Test TODO 2" };
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            program.ShowAll(todos);

            // Assert
            var expectedOutput = "1. Test TODO 1\r\n2. Test TODO 2\r\n\n Press any key to continue!\r\n";
            Assert.IsTrue(output.ToString().Contains(expectedOutput));
        }

        [TestMethod]
        public void ShowAll_ShouldDisplayNoTodosFound_WhenListIsEmpty()
        {
            // Arrange
            var program = new Program();
            var todos = new ArrayList();
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            program.ShowAll(todos);

            // Assert
            var expectedOutput = "No todos found!\r\n\n Press any key to continue!\r\n";
            Assert.IsTrue(output.ToString().Contains(expectedOutput));
        }

        [TestMethod]
        public void ShowMenu_ShouldDisplayMenu()
        {
            // Arrange
            var program = new Program();
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            program.ShowMenu();

            // Assert
            var expectedOutput = "What would you like to do!\r\n\n[A]dd TODO\r\n[D]elete TODO\r\n[V]iew all TODOS\r\n[E]xit\r\n";
            Assert.IsTrue(output.ToString().Contains(expectedOutput));
        }
    }
}