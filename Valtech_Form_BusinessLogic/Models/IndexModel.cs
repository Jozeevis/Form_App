using System;
using System.Collections.Generic;
using System.Text;

namespace Valtech_Form_BusinessLogic.Models
{
    public class IndexModel
    {
        /// <summary>
        /// List of entries to be shown underneath the form model
        /// </summary>
        public IEnumerable<FormModel> FormEntries { get; set; }
    }
}
