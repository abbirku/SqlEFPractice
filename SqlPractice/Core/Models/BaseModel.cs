using System.ComponentModel.DataAnnotations.Schema;

namespace SqlPractice.Core.Models
{
    public class BaseModel
    {
        public virtual int Id { get; set; }
        public virtual DateTime? CreatedTime { get; set; }
        public virtual DateTime? UpdatedTime { get; set; }
        public virtual int? ModifierId { get; set; }
    }
}
