using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PGconnectApi.Models.LoginModels
{
    public class login_master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LOGIN_ID { get; set; }
        [Required]
        public int USER_ID { get; set; }
        [Required]
        public string? USER_NAME { get; set; }
        [Required]
        public string? EMAIL { get; set; }
        [Required]
        public string? PASSWORD { get; set; }
        [Required]
        public string? STATUS { get; set; }
        public int PG_ID { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public DateTime UPDATED_TIME { get; set; }
        public string? FLAG {  get; set; } 
    }
}
