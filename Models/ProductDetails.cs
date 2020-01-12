using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class ProductDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductDetailsId { get; set; }
        public string Description { get; set; }
        public Guid? ProductImageId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }

        public Color Color { get; set; }
        public Product Product { get; set; }
        public ProductImage ProductImage { get; set; }
    }
}
