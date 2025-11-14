using System;
using System.Collections.ObjectModel;

namespace BookReaderApp.Models
{
  // Модель книги
  public class Book
  {
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string CoverImageUrl { get; set; }
    public int PageCount { get; set; }
    public int CurrentPage { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime? LastOpened { get; set; }
    public string Language { get; set; }
    public string Description { get; set; }
    public BookStatus Status { get; set; }
    public Reaction Reaction { get; set; }

    // Вычисляемое свойство - процент прочтения
    public int ReadingProgress => PageCount > 0 ? (CurrentPage * 100 / PageCount) : 0;

    // Версии перевода
    public ObservableCollection<Book> Translations { get; set; }

    public Book()
    {
      Id = Guid.NewGuid().ToString();
      DateAdded = DateTime.Now;
      Translations = new ObservableCollection<Book>();
      Status = BookStatus.New;
      Reaction = Reaction.NotRated;
    }
  }

  // Статус книги
  public enum BookStatus
  {
    New,        // Новая
    InProgress, // В процессе
    Completed   // Прочитана
  }

  // Реакция на книгу
  public enum Reaction
  {
    NotRated,  // Не оценено
    Like       // Нравится
  }

  // Модель заметки
  public class Note
  {
    public string Id { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string BookId { get; set; }
    public int PageNumber { get; set; }
    public string FirstSentence { get; set; }

    public Note()
    {
      Id = Guid.NewGuid().ToString();
    }
  }

  // Параметры текста
  public class TextSettings
  {
    public int FontSize { get; set; } = 16;
    public string BackgroundColor { get; set; } = "#FFFFFF";
    public string TextColor { get; set; } = "#000000";
    public int Margin { get; set; } = 20;
    public TextAlignment Alignment { get; set; } = TextAlignment.Left;
    public ScrollOrientation Orientation { get; set; } = ScrollOrientation.Vertical;
    public string TranslationLanguage { get; set; } = "English";
  }

  // Выравнивание текста
  public enum TextAlignment
  {
    Left,
    Center,
    Right,
    Justify
  }

  // Настройки интерфейса
  public class AppSettings
  {
    public AppTheme Theme { get; set; } = AppTheme.Light;
    public int InterfaceFontSize { get; set; } = 14;
    public string InterfaceLanguage { get; set; } = "Russian";
  }

  // Тема приложения
  public enum AppTheme
  {
    Light,
    Dark,
    Auto
  }
}
