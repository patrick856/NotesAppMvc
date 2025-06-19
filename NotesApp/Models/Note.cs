using System.ComponentModel.DataAnnotations;

namespace NotesApp.Models;

public class Note
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Title cannot be empty :<")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Note cannot be empty :<")]
    public string Content { get; set; } = string.Empty;
}