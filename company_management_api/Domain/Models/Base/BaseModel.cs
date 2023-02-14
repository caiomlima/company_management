using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace company_management_api.Domain.Models.Base
{
    public class BaseModel
    {
        [Column("id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public virtual long Id { get; set; }
    }
}
