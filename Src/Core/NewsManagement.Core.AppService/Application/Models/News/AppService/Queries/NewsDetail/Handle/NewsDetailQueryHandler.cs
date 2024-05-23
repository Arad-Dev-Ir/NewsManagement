namespace NewsManagement.Core.News.AppServices;

using Swan.Web.Core.AppService;
using Swan.Web.Core.Contract;
using Contracts;

public class NewsDetailQueryHandler : QueryHandler<NewsDetail, NewsDetailResult>
{
    private readonly INewsQueryRepository _repo;

    public NewsDetailQueryHandler(INewsQueryRepository repo)
    => _repo = repo;

    public override async Task<QueryResponse<NewsDetailResult>> ExecuteAsync(NewsDetail query)
    {
        var data = await _repo.Query(query);
        var result = await SetAsync(data);
        return result;
    }
}