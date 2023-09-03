namespace LotoApp.Domain.Models
{
    using LotoApp.Domain.Enums;

    public class User : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Username { get; set; }
        public string? Password { get; set; }
        public RoleEnum Role { get; set; }
        public List<int> Numbers { get; set; } = new List<int>();
    }
}
