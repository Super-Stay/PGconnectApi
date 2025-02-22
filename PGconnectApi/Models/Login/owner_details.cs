using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PGconnectApi.Models.LoginModels
{
    public class owner_details
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OWNER_ID { get; set; }
        [Required]
        public string? OWNER_NAME { get; set; }
        [Required]
        public string? EMAIL {  get; set; }
        [Required]
        public string? PASSWORD { get; set; }
        [Required]
        public string? REFERAL_CODE { get;}
        [Required]
        public int PG_ID { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? FLAG {  get; set; }
    }
}
