namespace ToDo
{
    public class ToDoItem
    {
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool IsLate => DueDate < DateTime.Now && !IsCompleted;
        public bool IsCompleted => CompletedDate.HasValue;
    }
}
