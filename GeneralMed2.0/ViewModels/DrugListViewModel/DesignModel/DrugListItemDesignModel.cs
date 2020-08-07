using GeneralMed2._0.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMed2._0
{
    public class DrugListItemDesignModel : DrugListItemControlViewModel
    {
        public static DrugListItemDesignModel Instance => new DrugListItemDesignModel();

        public DrugListItemDesignModel()
        {
            DrugName = "Metformin";
            GeneralPurpose = "Blood Glucose";
            DateAdded = "20/01/2004";
            DateModified = "12/12/2019";

        }
    }
}
