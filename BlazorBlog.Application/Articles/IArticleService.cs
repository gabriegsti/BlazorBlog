using BlazorBlog.Domain.Articles;

namespace BlazorBlog.Application.Articles
{
    public interface IArticleService
    {
        public  Task<List<Article>> GetAllArticlesAsync();
    }
}
