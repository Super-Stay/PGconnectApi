using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PGconnectApi.Models.PGSetUp
{
    public class pg_org_master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PG_ORG_ID { get; set; }
        [Required]
        public int PG_ORG_CODE { get; set; }
        [Required]
        public string? PG_ORG_NAME { get; set;}
        public string? IMAGE {  get; set; }
        [Required]
        public string? PG_ORG_TYPE { get;}
    }
}
