using Microsoft.Maui.Controls;

namespace BookReaderApp
{
  public partial class SearchPage : ContentPage
  {
    public SearchPage()
    {
      InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
      await Navigation.PopAsync();
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
