using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotesApp.Models;

namespace NotesApp.Controllers;

public class NotesController : Controller
{
    private readonly INoteService _noteService;

    public NotesController(INoteService noteService)
    {
        _noteService = noteService;
    }

    public IActionResult Index()
    {
        var notes = _noteService.GetAllNotes();
        return View(notes);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Note note)
    {
        if (!ModelState.IsValid)
            return View(note);

        _noteService.CreateNote(note);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var note = _noteService.GetSingleNote(id);
        if (note is null)
            return NotFound();

        return View(note);
    }

    [HttpPost]
    public IActionResult Edit(Note note)
    {
        if (!ModelState.IsValid)
            return View(note);

        _noteService.EditNote(note);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(Note note)
    {
        _noteService.DeleteNote(note);
        return RedirectToAction("Index");
    }
}