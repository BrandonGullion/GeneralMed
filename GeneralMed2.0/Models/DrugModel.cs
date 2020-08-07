using SQLite;
using System;

namespace GeneralMed2._0.Models
{
    public class DrugModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public string DrugName { get; set; }
        [NotNull]
        public string GeneralUse { get; set; }
        [NotNull]
        public DateTime DateAdded { get; set; }
        [NotNull]
        public DateTime LastUpdated { get; set; }
    }
}
