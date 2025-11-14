using Microsoft.Maui.Controls;

namespace BookReaderApp
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private void OnFilterButtonClicked(object sender, EventArgs e)
    {
      SearchExpander.IsExpanded = !SearchExpander.IsExpanded;
    }

    private async void OnSearchClicked(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new SearchPage());
    }

    private async void OnUploadClicked(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new UploadPage());
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new SettingsPage());
    }

    private void OnResetClicked(object sender, EventArgs e)
    {
      // Здесь будет логика сброса всех полей
      DisplayAlert("Сброс", "Все параметры поиска сброшены", "OK");
    }

    private async void OnShowResultsClicked(object sender, EventArgs e)
    {
      // Здесь будет логика применения фильтров и возврат на главную страницу
      await DisplayAlert("Поиск", "Результаты поиска будут отображены на главном экране", "OK");
      await Navigation.PopAsync();
    }
  }
}
