using Model.Enums;

namespace Model
{
    public class AppUser
    {

        public required string PersonCode { get; set; }
        public required string LoginName { get; set; }
        public Grants Grant { get; set; }
        public DateTime? FirstLogOn { get; set; }
        public DateOnly? Deactivated { get; set; }

        public virtual Employee EmployeeCodeNavigation { get; set; }
    }
}
