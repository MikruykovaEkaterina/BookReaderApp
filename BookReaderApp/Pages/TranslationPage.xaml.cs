using Microsoft.Maui.Controls;

namespace BookReaderApp
{
  public partial class TranslationPage : ContentPage
  {
    public TranslationPage()
    {
      InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
      await Navigation.PopAsync();
    }

    private async void OnTranslateClicked(object sender, EventArgs e)
    {
      // Скрываем выбор языка, показываем прогресс
      LanguageSelectionContainer.IsVisible = false;
      ProgressContainer.IsVisible = true;

      // Имитация процесса перевода
      for (int i = 0; i <= 100; i += 10)
      {
        TranslationProgress.Progress = i / 100.0;
        ProgressLabel.Text = $"{i}%";
        await Task.Delay(500);
      }

      await DisplayAlert("Успех", "Книга успешно переведена. Нажмите, чтобы посмотреть", "OK");
      await Navigation.PopAsync();
    }
  }
}
