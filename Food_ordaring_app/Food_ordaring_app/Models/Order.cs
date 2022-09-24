using Food_ordaring_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace food_ordering_app.Models
{
    public class Order
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual List<ProductOrder> ProductOrder { get; set; }

    }
}
