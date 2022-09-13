using SCrud.Data;
using SCrud.Models;
using Microsoft.AspNetCore.Identity;
namespace SCrud.Migrations
{
    public class seeder
    {
        public static void Seed(IApplicationBuilder appBuild)
        {
            using(var scope = appBuild.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<AppDataContext>();
                context.Database.EnsureCreated();
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<Users>{
                        new Users(){
                        Name = "Abderrahmane Aissat",
                        UserName = "Kader",
                        UserPassword = "123456",
                        UserEmail = "abderrahmanekaddour.aissat@gmail.com",
                        UserID = 101010,
                        CreatedDate = new DateTime()},
                        new Users(){
                        Name = " Aissat",
                        UserName = "abderrahmane",
                        UserPassword = "123456",
                        UserEmail = "abderrahmanekaddour.aissat@gmail.com",
                        UserID = 111111,
                        CreatedDate = new DateTime()}
                    });
                    context.SaveChanges();
                }

            }
        }
       
    }
}
