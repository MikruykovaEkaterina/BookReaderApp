using Microsoft.Maui.Controls;

namespace BookReaderApp
{
  public partial class ReadingPage : ContentPage
  {
    public ReadingPage()
    {
      InitializeComponent();
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
      await Navigation.PopToRootAsync();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
      await Navigation.PopAsync();
    }

    private void OnContentsClicked(object sender, EventArgs e)
    {
      ContentsPanel.IsVisible = !ContentsPanel.IsVisible;
    }

    private void OnTextSettingsClicked(object sender, EventArgs e)
    {
      TextSettingsPanel.IsVisible = !TextSettingsPanel.IsVisible;
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new SettingsPage());
    }

    private void OnNotesClicked(object sender, EventArgs e)
    {
      NotesPanel.IsVisible = !NotesPanel.IsVisible;
    }

    private void OnChapterClicked(object sender, EventArgs e)
    {
      // Переход к главе
      ContentsPanel.IsVisible = false;
      DisplayAlert("Переход", "Переход к выбранной главе", "OK");
    }

    private void OnCloseTextSettingsClicked(object sender, EventArgs e)
    {
      TextSettingsPanel.IsVisible = false;
    }

    private void OnCloseNotesClicked(object sender, EventArgs e)
    {
      NotesPanel.IsVisible = false;
    }

    private void OnAddNoteClicked(object sender, EventArgs e)
    {
      DisplayAlert("Заметка", "Здесь будет окно добавления новой заметки", "OK");
    }

    private void OnFontSizeClicked(object sender, EventArgs e)
    {
      DisplayAlert("Размер текста", "Выбор размера текста", "OK");
    }

    private void OnBackgroundColorClicked(object sender, EventArgs e)
    {
      DisplayAlert("Цвет фона", "Выбор цвета фона", "OK");
    }

    private void OnTextColorClicked(object sender, EventArgs e)
    {
      DisplayAlert("Цвет текста", "Выбор цвета текста", "OK");
    }

    private void OnMarginsClicked(object sender, EventArgs e)
    {
      DisplayAlert("Размер полей", "Выбор размера полей", "OK");
    }

    private void OnAlignmentClicked(object sender, EventArgs e)
    {
      DisplayAlert("Выравнивание", "Выбор выравнивания текста", "OK");
    }

    private void OnOrientationClicked(object sender, EventArgs e)
    {
      DisplayAlert("Ориентация", "Изменение ориентации листания", "OK");
    }
  }
}
