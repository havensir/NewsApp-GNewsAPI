using NewsApp.Services;
using NewsApp.Models;

namespace NewsApp.Pages;

public partial class NewsListPage : ContentPage
{
    public NewsListPage(string categoryName)
    {
        Title = categoryName;
        InitializeComponent();
        BindingContext = this;
        ArticleList = new List<Article>();
        GetNews(categoryName);
    }

    public List<Article> ArticleList;

    private async Task GetNews(string categoryName)
    {
        var apiService = new ApiService();
        var newsResult = await apiService.GetNews(categoryName);
        foreach (var item in newsResult.Articles)
        {
            ArticleList.Add(item);
        }
        CvNews.ItemsSource = ArticleList;
    }

    private void CvNews_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Article;
        if (selectedItem != null)
        {
            Navigation.PushAsync(new NewsDetailPage(selectedItem));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}