namespace NewsManagement.Core.News.Contracts;

using Swan.Web.Core.Contract;

public interface INewsQueryRepository : IQueryRepository
{
    Task<NewsDetailResult> Query(NewsDetail query);
    Task<PagedData<NewsRecordsResult>> Query(NewsRecords query);
}