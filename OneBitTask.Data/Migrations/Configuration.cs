namespace OneBitTask.Data.Migrations
{
    using System.Linq;
    using System.Data.Entity.Migrations;

    using Models;
    using Common;

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
            const string MalePictureUrl = "http://www2.psd100.com/ppp/2013/11/2801/user-1128032201.png";
            const string FemalePictureUrl = "http://wcdn3.dataknet.com/static/resources/icons/set47/790d2343.png";

            if (context.Users.Count() == 0)
            {
                IRandomGenerator random = new RandomGenerator();

                for (int i = 0; i < 10; i++)
                {
                    var user = new User
                    {
                        FirstName = random.RandomFirstName(),
                        LastName = random.RandomLastName(),
                        Sex = (SexType)random.RandomNumber(0, 2),
                        Telephone = "0" + random.RandomNumber(897000000, 897999999).ToString(),
                        Status = (StatusType)random.RandomNumber(0, 2),
                        PhotoUrl = random.RandomNumber(0, 1) == 0 ? FemalePictureUrl : MalePictureUrl,
                    };

                    context.Users.Add(user);
                }

                context.SaveChanges();
            }
        }
    }
}
