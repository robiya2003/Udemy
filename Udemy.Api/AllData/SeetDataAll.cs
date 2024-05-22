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
                    #region Development Category
                    new TopicModel()
                    {
                        Name="Web Development",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Data Science",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Mobile Development",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Programming Languages",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Game Development",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Database Design and Development",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Software Testing",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Software Engineering",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="Software Development Tools",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new TopicModel()
                    {
                        Name="No-Code Development",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    #endregion
                    
                    #region Business Category
                    new TopicModel()
                    {
                        Name="Entrepreneurship",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    new TopicModel()
                    {
                        Name="",
                        Description="Communication",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    new TopicModel()
                    {
                        Name="Management",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    new TopicModel()
                    {
                        Name="Sales",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    new TopicModel()
                    {
                        Name="Business strategy",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    new TopicModel()
                    {
                        Name="Operations",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    
                    new TopicModel()
                    {
                        Name="Project Management",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    new TopicModel()
                    {
                        Name="Business Law",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    new TopicModel()
                    {
                        Name="Business Analytics and Intelligence",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    },
                    new TopicModel()
                    {
                        Name="Human Resources",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    }
                    ,
                    new TopicModel()
                    {
                        Name="Industry",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    }
                    ,
                    new TopicModel()
                    {
                        Name="E-Commerce",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    }
                    ,
                    new TopicModel()
                    {
                        Name="Media",
                        Description="Description",
                        TopicPhotoPath="C:\\Users\\LENOVO\\OneDrive\\Desktop\\DockerNew\\Udemy.Api\\Udemy.Api\\wwwroot\\images\\topics\\topic.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==2)
                    }
#endregion


                };
            }
            // popular topics
            if (!db.popularTopics.Any())
            {

            }
        }
    }
}
