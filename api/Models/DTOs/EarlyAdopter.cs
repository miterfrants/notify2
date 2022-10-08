namespace Homo.AuthApi
{
    public abstract partial class DTOs
    {
        public class EarlyAdopterForm
        {
            public string Email { get; set; }
            public string Phone { get; set; }
            public decimal Fee { get; set; }
        }
    }

}