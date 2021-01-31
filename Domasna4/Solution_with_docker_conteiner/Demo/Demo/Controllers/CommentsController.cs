using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo.Data;
using Demo.Models;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Controllers
{
    [Authorize]
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Comments
        //This action is returning the index view of the Comments Controller. 
        //The index view is showing the list of all comments about our app.
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comment.ToListAsync());
        }

       

        // GET: Comments/Create
        //This action is returning the create view of the Comments controller.
        //The create view is showing a form for creating a comment.
        public IActionResult Create()
        {
            return View();
        }

        // POST: Comments/Create
        //This is the post action for creating the comment. 
        //This action is checking if the comment from user is in a valid state and adds the comment in the database.
        //Then we are redirected to the index action of this controller.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,komentar")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comment);
        }

     
    }
}
