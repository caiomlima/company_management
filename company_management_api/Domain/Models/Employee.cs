using company_management_api.Domain.Models.Base;
using static company_management_api.Commons.Enumerators;

namespace company_management_api.Domain.Models
{
    public class Employee : BaseModel
    {
        public Employee()
        {

        }

        public Employee(string name, string cpf, Gender gender, Sector sector, EmployeeRole role)
        {
                
        }

        public string Name { get; private set; }
        public string CPF { get; private set; }
        public Gender Gender { get; private set; }

        public virtual Sector Sector { get; private set; }
        public virtual EmployeeRole Role { get; private set; }
    }
}
