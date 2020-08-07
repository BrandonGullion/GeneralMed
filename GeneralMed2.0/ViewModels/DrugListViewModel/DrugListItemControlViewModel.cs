using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMed2._0
{
    public class DrugListItemControlViewModel
    {

        #region Public Properties 
        
        /// <summary>
        /// The generic drug name
        /// </summary>
        public string DrugName { get; set; }

        /// <summary>
        /// General uses of the drug 
        /// </summary>
        public string GeneralPurpose { get; set; }

        /// <summary>
        /// Date added to the profile 
        /// </summary>
        public string DateAdded { get; set; }

        /// <summary>
        /// Last date that the instructions were updated 
        /// </summary>
        public string DateModified { get; set; }

        #endregion

    }
}
