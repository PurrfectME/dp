using System.ComponentModel;

namespace dPosit.PrimeTrust.Sdk.RequestModels
{
    public class UserLoginDto
    {
        [DefaultValue("petrsooblev")]
        public string UserName { get; set; }

        [DefaultValue("_Testpassword123")]
        public string Password { get; set; }
    }
}