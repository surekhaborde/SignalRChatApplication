using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRChatApplicationDemo.Models
{
    public class SignUp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int id { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public string passwordHash { get; set; }
            public string confirmPassword { get; set; }
        
    }
}
