using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted => DeletedAt is not null;

        protected void MarkUpdated()
        {
            UpdatedAt = DateTime.UtcNow;
        }

        public void SoftDelete()
        {
            if (IsDeleted) return;
            DeletedAt = DateTime.UtcNow;
            MarkUpdated();
        }
    }
}
