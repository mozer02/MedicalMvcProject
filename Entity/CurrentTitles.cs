using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("CurrentTitles")]
    public class CurrentTitles
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string CompanyName { get; set; }

        public virtual CurrentGroups CurrentGroups { get; set; }
    }
}
