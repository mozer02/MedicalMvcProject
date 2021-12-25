using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [Table("tblCurrents")]
    public class Currents
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string CurrentNo { get; set; }
        [Required, StringLength(50)]
        public string CurrentName { get; set; }
        [Required, StringLength(50)]
        public string CurrentTitle { get; set; }
        [Required, StringLength(200)]
        public string Adress1 { get; set; }
        [StringLength(200)]
        public string Adress2 { get; set; }
        [Required, StringLength(100)]
        public string TaxOffice { get; set; }
        [Required, StringLength(11)]
        public string Id_TaxNo { get; set; }
        [Required, StringLength(12)]
        public string CurrentPhone { get; set; }
        [Required, StringLength(50)]
        public string CurrentMail { get; set; }
        [Required, StringLength(50)]
        public string AuthorizedName1{ get; set; }
        [StringLength(50)]
        public string AuthorizedName2 { get; set; }
        [StringLength(50)]
        public string AuthorizedName3 { get; set; }
        [Required, StringLength(50)]
        public string AuthorizedDepartment { get; set; }
        [StringLength(50)]
        public string AuthorizedDepartment2 { get; set; }
        [StringLength(50)]
        public string AuthorizedDepartment3 { get; set; }
        [Required,StringLength(12)]
        public string AuthorizedPhone1 { get; set; }
        [StringLength(12)]
        public string AuthorizedPhone2 { get; set; }
        [StringLength(12)]
        public string AuthorizedPhone3 { get; set; }
        [Required, StringLength(12)]
        public string AuthorizedMPhone1 { get; set; }
        [StringLength(12)]
        public string AuthorizedMPhone2 { get; set; }
        [StringLength(12)]
        public string AuthorizedMPhone3 { get; set; }
        [Required, StringLength(50)]
        public string AuthorizedMail1 { get; set; }
        [StringLength(50)]
        public string AuthorizedMail2 { get; set; }
        [StringLength(50)]
        public string AuthorizedMail3 { get; set; }
        public string SaveUserName { get; set; }
        public string UpdateUserName { get; set; }

        [Required]
        public DateTime SaveDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool isActive { get; set; }
        public virtual Citys Citys { get; set; }
        public virtual CurrentGroups CurrentGroups { get; set; }

        public virtual List<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual List<BillEntry> BillEntries { get; set; }
        public virtual List<Product> Products { get; set; }

    }
}
