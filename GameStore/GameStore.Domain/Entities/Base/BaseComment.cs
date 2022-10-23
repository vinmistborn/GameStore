using System;

namespace GameStore.Domain.Entities.Base
{
    public class BaseComment : BaseEntity, IAuditableEntity
    {
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}
