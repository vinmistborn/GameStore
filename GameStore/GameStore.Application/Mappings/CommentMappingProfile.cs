using AutoMapper;
using GameStore.Application.DTOs.Comment;
using GameStore.Application.DTOs.Comment.Base;
using GameStore.Application.DTOs.Comment.SubComment;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.Base;

namespace GameStore.Application.Mappings
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<BaseComment, BaseCommentInfoDto>()
                     .ForMember(dest => dest.CreatedAt,
                                src => src.MapFrom(x => x.CreatedAt.ToString("g")))
                     .ForMember(dest => dest.LastModifiedAt,
                                src => src.MapFrom(x => x.LastModifiedAt.ToString("g"))); ;

            CreateMap<Comment, CommentDto>()
                     .ReverseMap();

            CreateMap<Comment, CommentInfoDto>()
                     .IncludeBase<BaseComment, BaseCommentInfoDto>();
                     

            CreateMap<SubComment, SubCommentDto>()
                     .ReverseMap();

            CreateMap<SubComment, SubCommentInfoDto>()
                    .IncludeBase<BaseComment, BaseCommentInfoDto>();
        }
    }
}
