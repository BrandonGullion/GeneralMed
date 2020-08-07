using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMed2._0
{
    public class DrugListControlDesignModel : DrugListControlViewModel
    {

        public static DrugListControlDesignModel Instance => new DrugListControlDesignModel(); 

        public DrugListControlDesignModel()
        {
            DrugList = new List<DrugListItemControlViewModel>
            {
                new DrugListItemControlViewModel
                {
                    DrugName = "Metformin",
                    GeneralPurpose = "Blood Glucose",
                    DateAdded = "01/01/2020",
                    DateModified = "01/01/2020"
                },

                new DrugListItemControlViewModel
                {
                    DrugName = "Atorvastatin",
                    GeneralPurpose = "Cholesterol",
                    DateAdded = "01/01/2020",
                    DateModified = "01/01/2020"
                },

                new DrugListItemControlViewModel
                {
                    DrugName = "Calcium",
                    GeneralPurpose = "Bone Health",
                    DateAdded = "01/01/2020",
                    DateModified = "01/01/2020"
                },
            };
        }
    }
}
