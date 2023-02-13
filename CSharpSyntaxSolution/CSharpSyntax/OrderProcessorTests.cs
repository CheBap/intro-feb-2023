using Moq;

namespace CSharpSyntax;

public class OrderProcessorTests
{
    [Fact]

    public void CanAddItems()
    {
        var item1 = new Item { Name = "Eggs", Qty = 1, Price = 3.99M };
        var item2 = new Item { Name = "Beer", Qty = 1, Price = 12.99M };

        var mockedDatabase = new Mock<IHandleTheDatabase>();
        var orderProcessor = new OrderProcessor(mockedDatabase.Object);

        orderProcessor.AddItem(item1);
        orderProcessor.AddItem(item2);

        mockedDatabase.Verify(mockedDatabase => mockedDatabase.AddShoppingItem(item1), Times.Once);
        mockedDatabase.Verify(mockedDatabase => mockedDatabase.AddShoppingItem(item2), Times.Once);
    }

    [Fact]

    public void HandlesDatabaseErrors()
    {
        var item1 = new Item { Name = "Eggs", Qty = 1, Price = 3.99M };
        var item2 = new Item { Name = "Beer", Qty = 1, Price = 12.99M };

        var stubbedDatabase = new Mock<IHandleTheDatabase>();stubbedDatabase.Setup(b => b.AddShoppingItem(It.IsAny<Item>())).Throws(new Exception());
        var orderProcessor = new OrderProcessor(stubbedDatabase.Object);

        orderProcessor.AddItem(item1);
        orderProcessor.AddItem(item2);

        //Assert.Equal(2, orderProcessor.UnsavedItems.Count);
    }
}
