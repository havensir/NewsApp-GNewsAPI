using NewsApp.Models;

namespace NewsApp.Pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article article)
	{
		InitializeComponent();
		BindingContext = article;
    }

    private async void OnReadArticleClicked(object sender, EventArgs e)
    {
        var article = BindingContext as Article;

        if (article != null)
        {
            await Launcher.OpenAsync(article.Url);
        }
    }
}