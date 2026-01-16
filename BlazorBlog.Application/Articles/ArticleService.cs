using BlazorBlog.Domain.Articles;

namespace BlazorBlog.Application.Articles
{
    public class ArticleService : IArticleService
    {
        
        public List<Article> GetAllArticles()
        {
            return new List<Article> 
            { 
                new Article{
                    Id = 1,
                    Title = "Test",
                    Content = "This is my first article",
                },
                new Article{
                    Id = 2,
                    Title = "Test",
                    Content = "This is my second article",
                }
            };
        }
    }
}
