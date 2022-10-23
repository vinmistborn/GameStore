using System;

namespace GameStore.Domain.Entities.Base
{
    public interface IAuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}
