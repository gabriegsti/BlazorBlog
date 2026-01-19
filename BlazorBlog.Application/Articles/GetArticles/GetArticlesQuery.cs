using BlazorBlog.Domain.Articles;
using MediatR;

namespace BlazorBlog.Application.Articles.GetArticles
{
    public class GetArticlesQuery : IRequest<List<Article>>
    {
    }
}
