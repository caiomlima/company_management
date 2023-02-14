using company_management_api.Domain.Models.Base;

namespace company_management_api.Domain.Models
{
    public class EmployeeRole : BaseModel
    {
        public EmployeeRole()
        {

        }

        public EmployeeRole(string name, string description)
        {

        }

        public string Name { get; private set; }
        public string Description { get; private set; }

        public virtual Sector Sector { get; private set; }
        public virtual Employee Employee { get; private set; }
    }
}
