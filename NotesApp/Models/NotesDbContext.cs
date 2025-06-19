using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace NotesApp.Models;

public class NotesDbContext : DbContext
{
    public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) { }

    public DbSet<Note> notes => Set<Note>();
}