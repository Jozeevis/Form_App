using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Valtech_Form_BusinessLogic.Data;
using Valtech_Form_BusinessLogic.Managers;
using Valtech_Form_BusinessLogic.Models;

namespace Valtech_Form_App.Controllers
{
    public class FormController : Controller
    {
        private FormEntryManager _formEntryManager;

        public FormController(FormDbContext context)
        {
            _formEntryManager = new FormEntryManager(context);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(FormModel model)
        {
            // Return to form if modelstate is not valid
            if (!ModelState.IsValid)
            {
                return View("/Pages/Modules/FormView.cshtml", model);
            }

            try
            {
                _formEntryManager.Create(model);
            }
            catch (InvalidOperationException e)
            {
                TempData["ErrorMessage"] = e.Message;
                return RedirectToAction("Index", "Index");
            }

            // Show a message that the creation of a new entry was succesful
            TempData["Message"] = "Nieuwe entry succesvol aangemaakt.";

            // Return to home screen
            return RedirectToAction("Index", "Index");
        }
    }
}