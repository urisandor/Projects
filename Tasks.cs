public class TodoTask
{
    public int Id { get; set; }
    public string Event { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public TodoTask(int id, string @event, string description)
    {
        Id = id;
        Event = @event;
        Description = description;
        IsCompleted = false;
    }

    public override string ToString()
    {
        return $"{Id}. [{(IsCompleted ? "X" : " ")}] {Event} - {Description}";
    }
}
