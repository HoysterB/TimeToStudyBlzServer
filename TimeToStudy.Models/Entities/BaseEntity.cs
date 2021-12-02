using System.ComponentModel.DataAnnotations;

namespace TimeToStudy.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? _createAt;
        public DateTime? CreateAt
        {
            get
            {
                return _createAt;
            }
            set
            {
                _createAt = (value == null ? DateTime.UtcNow : value);
            }
        }
        public DateTime? UpdateAt { get; set; }
    }
}
