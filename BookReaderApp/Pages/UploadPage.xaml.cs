using Microsoft.Maui.Controls;

namespace BookReaderApp
{
  public partial class UploadPage : ContentPage
  {
    public UploadPage()
    {
      InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
      await Navigation.PopAsync();
    }

    private void OnLanguageSelected(object sender, EventArgs e)
    {
      // Активируем кнопку загрузки после выбора языка
      UploadButton.IsEnabled = LanguagePicker.SelectedIndex >= 0;
    }

    private async void OnUploadClicked(object sender, EventArgs e)
    {
      // Имитация выбора файла и загрузки
      bool answer = await DisplayAlert("Загрузка",
          "Открыть файловый менеджер для выбора книги?", "Да", "Отмена");

      if (answer)
      {
        // Показываем прогресс
        ProgressContainer.IsVisible = true;
        UploadButton.IsVisible = false;

        // Имитация загрузки
        for (int i = 0; i <= 100; i += 10)
        {
          UploadProgress.Progress = i / 100.0;
          ProgressLabel.Text = $"{i}%";
          await Task.Delay(500);
        }

        await DisplayAlert("Успех", "Книга успешно загружена. Нажмите, чтобы открыть", "OK");
        await Navigation.PopAsync();
      }
    }
  }
}
