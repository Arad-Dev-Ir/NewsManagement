namespace NewsManagement.Core.News.Contracts;

using Swan.Web.Core.Contract;

public class NewsDetail : IQuery<NewsDetailResult>
{
    public long Id { get; set; }
}