using System;
using SQLite;

namespace GeneralMed2._0.Models
{
    
    public class PatientModel : BasePropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50), NotNull]
        public string FirstName { get; set; }

        [MaxLength(50), NotNull]
        public string LastName { get; set; }

        [NotNull]
        public string DOB { get; set; }

        public string Address { get; set; }

        public string DateCreated { get; set; }

        public string LastUpdate { get; set; }


    }
}
