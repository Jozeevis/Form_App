using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valtech_Form_BusinessLogic.Data;
using Valtech_Form_BusinessLogic.Models;

namespace Valtech_Form_BusinessLogic.Managers
{
    public class FormEntryManager
    {
        private FormDbContext _context;

        public FormEntryManager(FormDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all the database entries
        /// </summary>
        /// <returns></returns>
        public List<FormModel> GetAllEntries()
        {
            return _context.FormEntries.ToList();
        }

        /// <summary>
        /// Create a new database entry from the given entry
        /// </summary>
        public void Create(FormModel model)
        {
            if (_context.FormEntries.Count() >= 10)
            {
                throw new InvalidOperationException("Database bevat al 10 entries, er kunnen er geen meer worden toegevoegd tot er eerst een verwijderd wordt.");
            }
            _context.FormEntries.Add(model);
            _context.SaveChanges();
        }

        /// <summary>
        /// Delete the database entry with the given id
        /// </summary>
        public void Delete(int id)
        {
            var entryToDelete = _context.FormEntries.Find(id);
            _context.FormEntries.Remove(entryToDelete);
            _context.SaveChanges();
        }
    }
}
