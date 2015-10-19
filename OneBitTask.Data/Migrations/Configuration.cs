namespace OneBitTask.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UsersDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;

            //TODO: Set to false in produciton
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(UsersDbContext context)
        {
            ////Adding sample user to check database creation
            //var user = new User
            //{
            //    FirstName = "Pesho",
            //    LastName = "Goshov",
            //    Sex = SexType.Male,
            //    Telephone = "0897654321",
            //    Status = StatusType.Active,
            //    PhotoUrl = "http://www2.psd100.com/ppp/2013/11/2801/user-1128032201.png",
            //};

            //context.Users.Add(user);
            //context.SaveChanges();
        }
    }
}
