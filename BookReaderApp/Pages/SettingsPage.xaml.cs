using Microsoft.Maui.Controls;

namespace BookReaderApp
{
  public partial class SettingsPage : ContentPage
  {
    private string[] themes = { "Светлая", "Тёмная", "Авто" };
    private int currentThemeIndex = 0;

    private string[] languages = { "Русский", "English" };
    private int currentLanguageIndex = 0;

    private int fontSize = 14;
    private const int MinFontSize = 10;
    private const int MaxFontSize = 20;

    public SettingsPage()
    {
      InitializeComponent();
      UpdateFontButtons();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
      await Navigation.PopAsync();
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
      await Navigation.PopToRootAsync();
    }

    // Тема
    private void OnThemePreviousClicked(object sender, EventArgs e)
    {
      currentThemeIndex = (currentThemeIndex - 1 + themes.Length) % themes.Length;
      ThemeLabel.Text = themes[currentThemeIndex];
    }

    private void OnThemeNextClicked(object sender, EventArgs e)
    {
      currentThemeIndex = (currentThemeIndex + 1) % themes.Length;
      ThemeLabel.Text = themes[currentThemeIndex];
    }

    // Размер шрифта
    private void OnDecreaseFontClicked(object sender, EventArgs e)
    {
      if (fontSize > MinFontSize)
      {
        fontSize--;
        UpdateFontSize();
      }
    }

    private void OnIncreaseFontClicked(object sender, EventArgs e)
    {
      if (fontSize < MaxFontSize)
      {
        fontSize++;
        UpdateFontSize();
      }
    }

    private void UpdateFontSize()
    {
      string size = fontSize == 12 ? "Маленький" :
                    fontSize == 14 ? "Средний" :
                    fontSize >= 16 ? "Большой" : "Средний";
      FontSizeLabel.Text = $"{size} ({fontSize})";
      UpdateFontButtons();
    }

    private void UpdateFontButtons()
    {
      DecreaseButton.IsEnabled = fontSize > MinFontSize;
      IncreaseButton.IsEnabled = fontSize < MaxFontSize;
    }

    // Язык
    private void OnLanguagePreviousClicked(object sender, EventArgs e)
    {
      currentLanguageIndex = (currentLanguageIndex - 1 + languages.Length) % languages.Length;
      LanguageLabel.Text = languages[currentLanguageIndex];
    }

    private void OnLanguageNextClicked(object sender, EventArgs e)
    {
      currentLanguageIndex = (currentLanguageIndex + 1) % languages.Length;
      LanguageLabel.Text = languages[currentLanguageIndex];
    }
  }
}
