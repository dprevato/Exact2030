using System.Collections.ObjectModel;

namespace Model
{
    /// <summary>
    /// Personale addetto
    /// </summary>
    public partial class Employee
    {
        public required string Id { get; set; }
        public required string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? FirstName { get; set; }
        public DateOnly Hired { get; set; }
        public DateOnly? Retired { get; set; }
        /// <summary>
        /// persona da cui dipende
        /// </summary>
        public string? BossId { get; set; }       // Id del superiore gerarchico
        /// <summary>
        /// area di competenza
        /// </summary>
        public string? AreaCode { get; set; }

        public virtual Area? Area { get; set; }
        public virtual Employee? Boss { get; set; }
        public virtual ObservableCollection<AppUser> AppUser { get; set; } = [];
        public virtual ObservableCollection<Employee> InverseBossNavigation { get; set; } = [];
        public virtual ObservableCollection<Personplant> Keepers { get; set; } = [];
    }
}
