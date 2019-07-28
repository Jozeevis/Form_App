using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Valtech_Form_BusinessLogic.Data;
using Valtech_Form_BusinessLogic.Managers;
using Valtech_Form_BusinessLogic.Models;

namespace Valtech_Form_App.Controllers
{
    public class IndexController : Controller
    {
        /// <summary>
        /// Handler for database actions
        /// </summary>
        private FormEntryManager _formEntryManager;

        public IndexController(FormDbContext context)
        {
            _formEntryManager = new FormEntryManager(context);
        }

        public IActionResult Index()
        {
            // Get all the entries saved in the database
            IndexModel model = new IndexModel();
            model.FormEntries = _formEntryManager.GetAllEntries();

            return View("/Pages/Index.cshtml", model);
        }

        public IActionResult Delete(int id)
        {
            // Delete the entry from the database
            _formEntryManager.Delete(id);

            // Show a message that the delete was succesful
            TempData["Message"] = $"Entry met id {id} was succesvol verwijderd.";
            
            return RedirectToAction("Index");
        }
    }
}