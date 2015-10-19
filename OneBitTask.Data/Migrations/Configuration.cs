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

        //TODO: Do it right!
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

            //var user2 = new User
            //{
            //    FirstName = "Penka",
            //    LastName = "Loshoto(the ex)",
            //    Sex = SexType.Female,
            //    Telephone = "0897612341",
            //    Status = StatusType.Deleted,
            //    PhotoUrl = "http://wcdn3.dataknet.com/static/resources/icons/set47/790d2343.png",
            //};
            //context.Users.Add(user2);

            //var user3 = new User
            //{
            //    FirstName = "Ivanka",
            //    LastName = "Goshova",
            //    Sex = SexType.Female,
            //    Telephone = "0897456321",
            //    Status = StatusType.Inactive,
            //    PhotoUrl = "http://wcdn3.dataknet.com/static/resources/icons/set47/790d2343.png",
            //};
            //context.Users.Add(user3);

            //context.SaveChanges();
        }
    }
}
