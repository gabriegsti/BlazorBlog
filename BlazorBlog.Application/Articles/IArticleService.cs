using BlazorBlog.Domain.Articles;

namespace BlazorBlog.Application.Articles
{
    public interface IArticleService
    {
        public List<Article> GetAllArticles();
    }
}
