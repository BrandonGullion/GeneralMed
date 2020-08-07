using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMed2._0
{
    public class DrugListControlViewModel
    {
        // Have to remember that within this is just a view model, not the design information 

        /// <summary>
        /// The chat list items for the list 
        /// </summary>
        public List<DrugListItemControlViewModel> DrugList { get; set; }

    }
}
