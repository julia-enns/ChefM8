namespace ChefM8.Shared
{
    public record LoginInput(string Username, string Password);

    public class UserLoginInfo
    {
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }

        public UserLoginInfo()
        {
            AdminUsername = "adminUser";
            AdminPassword = "adminPass";
            CustomerUsername = "customerUser";
            CustomerPassword = "customerPass";
        }
    }
}