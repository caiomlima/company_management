using company_management_api.Domain.Models.Base;

namespace company_management_api.Domain.Models
{
    public class Sector : BaseModel
    {
        public Sector()
        {

        }

        public Sector(string name, string description)
        {

        }

        public string Name { get; private set; }
        public string Description { get; private set; }

        public virtual ICollection<EmployeeRole> EmployeeRoles { get; private set; }
    }
}
