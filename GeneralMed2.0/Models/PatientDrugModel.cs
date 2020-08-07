using GeneralMed2._0.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralMed2._0
{
    /// <summary>
    /// This will be used to associate the customer with the drug 
    /// </summary>
    public class PatientDrugModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public int PatientId { get; set; }
        [NotNull]
        public string DrugName { get; set; }
        [NotNull]
        public string DrugStrength { get; set; }
        [NotNull]
        public string GeneralPurpose { get; set; }
        [NotNull]
        public string DateAddedToProfile { get; set; }
        [NotNull]
        public string LastUpdate { get; set; }

    }
}
