using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCFMastek
{
    [Table("Category")]
    class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [Column(TypeName ="varchar(20)")]
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }

    }
}
