namespace KanbanBoard;

public class KanbanStore
{
    private IEnumerable<Column> columns = new List<Column>
    {
        new Column { Id = 1, Name = "Todo" },
        new Column { Id = 2, Name = "Doing" },
        new Column { Id = 3, Name = "Done" },
    };

    private List<Card> cards = new List<Card>()
    {
        new Card { ColumnId = 1, Text = "Create Kanban Board Layout" },
        new Card { ColumnId = 2, Text = "Refactor Card into separate component", Initials = "RW" },
        new Card { ColumnId = 2, Text = "Implement new UI for home page", Initials = "JH" },
    };

    public List<Column> GetBoard(){
        return columns.ToList();
    }

    public List<Card> GetCards(){
        return cards.ToList();
    }
}   

public class Column
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Card
{
    public int ColumnId { get; set; }
    public string Text { get; set; }
    public string Initials { get; set; }
}