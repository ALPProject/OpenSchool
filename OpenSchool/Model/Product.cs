using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenSchool.Abstract;

namespace OpenSchool.Model
{
    [Table("Products")]
    public class Product : AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }

        public string CatagoryID { set; get; }
        public string Image { set; get; }
        public decimal Prices { set; get; }
        public decimal? PromotionPrices { set; get; }
        public string Descripstion { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CatagoryID")]
        public virtual ProductCatagory ProductCatagory { set; get; }
    }
    
}
