namespace LotoApp.DataAccess
{
    using LotoApp.Domain.Enums;
    using LotoApp.Domain.Models;
    public static class StaticDb
    {
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                FirstName = "Andrew",
                LastName = "Tate",
                Username = "T8",
                Password = "Geeksbruv",
                Role = RoleEnum.Participant,
                Numbers = new List<int> { 2, 5, 14, 24, 22, 29, 30 }
            },

            new User()
            {
                FirstName = "Tristan",
                LastName = "Tate",
                Username = "TheTalisman",
                Password = "Booze",
                Role = RoleEnum.Participant,
                Numbers = new List<int> { 10, 19, 37, 27, 3, 13, 33 }
            },

            new User()
            {
                FirstName = "Justin",
                LastName = "Waller",
                Username = "Justin10",
                Password = "justinjustin",
                Role = RoleEnum.Participant,
                Numbers = new List<int> { 4, 17, 19, 22, 26, 32, 35 }
            },

            new User()
            {
                FirstName = "Luc",
                LastName = "Tate",
                Username = "Luc23",
                Password = "batule123",
                Role = RoleEnum.Participant,
                Numbers = new List<int> { 8, 14, 16, 24, 28, 32, 34 }
            },
        };
    }
}
