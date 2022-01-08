namespace Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string fullName, string email, bool active)
        {
            FullName = fullName;
            Email = email;
            Active = active;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
    }
}
