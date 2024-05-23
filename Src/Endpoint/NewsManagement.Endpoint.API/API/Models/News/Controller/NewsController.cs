namespace NewsManagement.Endpoint.News.APIs;

using Microsoft.AspNetCore.Mvc;
using Swan.Web.Endpoint.API;
using Swan.Web.Core.Contract;
using Core.News.Contracts;

[Route("api/[controller]")]
public class NewsController : ApiController
{
    [HttpPost("register-news")]
    public async Task<IActionResult> Post(RegisterNews command)
    => await Create<RegisterNews, long>(command);

    [HttpGet("get-news-detail/{id}")]
    public async Task<IActionResult> Get([FromRoute] long id)
    => await ExcecuteQuery<NewsDetail, NewsDetailResult>(new NewsDetail { Id = id });

    [HttpGet("get-news-list")]
    public async Task<IActionResult> Get([FromQuery] NewsRecords query)
    => await ExcecuteQuery<NewsRecords, PagedData<NewsRecordsResult>>(query);
}