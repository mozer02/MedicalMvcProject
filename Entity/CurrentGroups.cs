using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("tblCurrentGroups")]
    public class CurrentGroups
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string GroupName { get; set; }

        public bool isActive { get; set; }

        public virtual List<Currents> Currents { get; set; }
        public virtual List<Departments> Departments { get; set; }

        public virtual List<CurrentTitles> CurrentTitles { get; set; }


    }
}
