using System.ComponentModel.DataAnnotations;
using LibraryServiceReference;

namespace LibraryService.WebClient.Models
{

    /// <summary>
    /// Тип поиска
    /// </summary>
    public enum SearchType
    {
        [Display(Name = "Заголовок")]
        Title,
        [Display(Name = "Автор")]
        Author,
        [Display(Name = "Категория")]
        Category
    }
}
