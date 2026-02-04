namespace CSLLMCapstone.Services
{
    public class UserSessionService
    {
        public int? UserId { get; set; }
        public string? UserEmail { get; set; }
        public string? UserName { get; set; }

        public bool IsLoggedIn => UserId.HasValue;

        public void SetUser(int userId, string email, string name)
        {
            UserId = userId;
            UserEmail = email;
            UserName = name;
        }

        public void ClearUser()
        {
            UserId = null;
            UserEmail = null;
            UserName = null;
        }
    }
}