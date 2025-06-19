using NotesApp.Models;

public interface INoteService
{
    List<Note> GetAllNotes();
    Note? GetSingleNote(int id);
    void CreateNote(Note note);
    void EditNote(Note note);
    void DeleteNote(Note note);
}