using Microsoft.EntityFrameworkCore;
using Udemy.Domain.MODELS;
using Udemy.Infastucture.Persistants;

namespace Udemy.Api.AllData
{
    public static class SeetDataAll
    {
        public static async Task InitiliazeDataAsync(this IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetRequiredService<AppDbContext>();
            // categories
            if(!db.categories.Any())
            {
                #region Categories
                List<CategoryModel> categories = new List<CategoryModel>()
                {
                    new CategoryModel()
                    {
                        Name="Development",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Business",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Finance and Accounting",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="It and Software",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Office Productivity",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Personal Development",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Design",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Marketing",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Lifestyle",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Photography and Video",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Health and Fitness",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Music",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Teaching and Academics",
                        Description="Description",
                        CategoryPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\categories\\categoryphoto.jpg"
                    }
                };
                #endregion

                await db.categories.AddRangeAsync(categories);
                await db.SaveChangesAsync();
            }
            // topics
            if (!db.topic.Any())
            {
                List<TopicModel> list = new List<TopicModel>()
                {
                    // Development Category
                    new TopicModel()
                    {
                        Name="Web Development",
                        Description="Web development is the work involved in developing a website for the Internet (World Wide Web) or an intranet (a private network).[1] Web development can range from developing a simple single static page of plain text to complex web applications, electronic businesses, and social network services. A more comprehensive list of tasks to which Web development commonly refers, may include Web engineering, Web design, Web content development, client liaison, client-side/server-side scripting, Web server and network security configuration, and e-commerce development.",
                        TopicPhotoPath="https://localhost:7030/images/topics/webdevelopment.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Data Science",
                        Description="Data science combines math and statistics, specialized programming, advanced analytics, artificial intelligence (AI) and machine learning with specific subject matter expertise to uncover actionable insights hidden in an organization’s data. These insights can be used to guide decision making and strategic planning.",
                        TopicPhotoPath="https://localhost:7030/images/topics/datascience.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Mobeile Development",
                        Description="Mobile application development is the process of making software for smartphones, tablets and digital assistants, most commonly for the Android and iOS operating systems.",
                        TopicPhotoPath="https://localhost:7030/images/topics/mobiledevelopment.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Programming Languages",
                        Description="Description",
                        TopicPhotoPath="https://localhost:7030/images/courses/topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Game Development",
                        Description="Description",
                        TopicPhotoPath="https://localhost:7030/images/courses/topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Database Design and Development",
                        Description="Description",
                        TopicPhotoPath="https://localhost:7030/images/courses/topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Software Testing",
                        Description="Description",
                        TopicPhotoPath="https://localhost:7030/images/courses/topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Software Engineering",
                        Description="Description",
                        TopicPhotoPath="https://localhost:7030/images/courses/topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Software Development Tools",
                        Description="Description",
                        TopicPhotoPath="https://localhost:7030/images/courses/topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="No-Code Development",
                        Description="Description",
                        TopicPhotoPath="https://localhost:7030/images/courses/topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },


                };
            }
            // popular topics
            if (!db.popularTopics.Any())
            {

            }
        }
    }
}
