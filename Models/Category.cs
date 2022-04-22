using System.ComponentModel.DataAnnotations;

namespace BulkyBooksWeb.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]

        [System.ComponentModel.DisplayName("Name")]
        public string name { get; set; }

        [System.ComponentModel.DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
