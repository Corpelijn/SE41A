namespace FireBee.Domain
{
    public class Account
    {
        public static bool IsLoggedIn { get; set; }

        static Account()
        {
            IsLoggedIn = false;
        }
    }
}