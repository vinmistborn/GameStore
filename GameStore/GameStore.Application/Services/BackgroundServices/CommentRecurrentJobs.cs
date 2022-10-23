using GameStore.Application.Contracts.Services;
using Hangfire;

namespace GameStore.Application.Services.BackgroundJobs
{
    public static class CommentRecurrentJobs
    {
        public static void RegisterCommentRecurrentJobs()
        {
            RecurringJob.AddOrUpdate<ICommentService>(recurringJobId: "dailyCommentDelete", x => x.DeleteCommentsAsync(), Cron.Daily);
            RecurringJob.AddOrUpdate<ISubCommentService>(recurringJobId: "dailySubCommentDelete", x => x.DeleteCommentsAsync(), Cron.Daily);
        }
    }
}
