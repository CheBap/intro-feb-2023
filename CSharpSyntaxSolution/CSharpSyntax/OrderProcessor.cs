
namespace CSharpSyntax;

public class OrderProcessor
{
    private readonly IHandleTheDatabase _database;

    public OrderProcessor(IHandleTheDatabase database)
    {
        _database = database;
    }

    public void AddItem(Item itemToAdd)
    {
        _database.AddShoppingItem(itemToAdd);

    }
    public List<Item> UnsavedItems { get; private set; } = new();
}


public interface IHandleTheDatabase
{
    void AddShoppingItem(Item itemToAdd);
}
public class Item
{
    public string Name { get; set; } = string.Empty;

    public int Qty { get; set; }
    public decimal Price { get; set; }
}
