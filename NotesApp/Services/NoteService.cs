using NotesApp.Models;

public class NoteService : INoteService
{
    private readonly NotesDbContext _context;

    public NoteService(NotesDbContext context) => _context = context;

    public List<Note> GetAllNotes() => _context.notes.ToList();

    public Note? GetSingleNote(int id) => _context.notes.Find(id);

    public void CreateNote(Note note)
    {
        _context.notes.Add(note);
        _context.SaveChanges();
    }

    public void EditNote(Note note)
    {
        _context.notes.Update(note);
        _context.SaveChanges();
    }

    public void DeleteNote(Note note)
    {
        _context.notes.Remove(note);
        _context.SaveChanges();
    }
}