using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Developer_Documentation_Reader.Models
{
    [Table("Documents")]
    public class Document
    {
        [Key]
        public int DocumentID { get; set; }
        [Display(Name = "Document Name")]
        [DataType(DataType.Text)]
        public string DocumentName { get; set; }
        [Display(Name = "File Path")]
        public string FilePath { get; set; }
        [Display(Name = "Document Length")]
        public int DocLength { get; set; }
    }

    public class DocumentDbContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }

    }
}