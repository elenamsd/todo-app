namespace ToDoAPP.Models;

public static class TodoItemMapper
{
    public static TodoItemDTO ItemToDto(TodoItem todoItem) =>
        new TodoItemDTO
        {
            Id = todoItem.Id,
            Name = todoItem.Name,
            IsComplete = todoItem.IsComplete
        };   
    
    public static TodoItem DtoToItem(TodoItemDTO todoItemDto) =>
        new TodoItem
        {
            Id = todoItemDto.Id,
            Name = todoItemDto.Name,
            IsComplete = todoItemDto.IsComplete
        };   
}