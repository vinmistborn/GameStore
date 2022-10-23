using System;

namespace GameStore.Application.DTOs.Comment.Base
{
    public class BaseCommentInfoDto : BaseCommentDto
    {
        public bool IsDeleted { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedAt { get; set; }
    }
}
