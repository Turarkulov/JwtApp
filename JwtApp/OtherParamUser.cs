using System.ComponentModel.DataAnnotations;

using JwtApp.Models;

namespace JwtApp
{
    public class OtherParamUser: ParamUser
    {
        public string UserName { get; set; }
        public bool SeniorManager { get; set; }

        [Required]
        public enumProfession Profession { get; set; }
    }
}
