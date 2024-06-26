﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Udemy.Domain.DTOS;
using Udemy.Domain.MODELS;
using Udemy.Infastucture.Persistants;

namespace Udemy.Api.AllData
{
    public static class SeetDataAll
    {
        public static async Task InitiliazeDataAsync(this IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<UserModel>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var db = serviceProvider.GetRequiredService<AppDbContext>();
            if(!db.Users.Any()) 
            {
                var user1 = new UserModel()
                {
                    UserName = "robiya2003",
                    Email = "robiyahakimova2003@gmail.com",
                    FirstName = "Robiya",
                    LastName = "Hakimova",
                    Role = "Admin"
                };
                var result1 = await userManager.CreateAsync(user1, "Qwerty12!@");
                await userManager.AddToRoleAsync(user1, "Admin");
                
                
            }
            if(!db.categories.Any())
            {
                List<CategoryModel> categories = new List<CategoryModel>()
                {
                    #region
                    new CategoryModel()
                    {
                        Name="Development",
                        Description="Development is defined as a process that results in growth, progress, positive change, or the addition of physical, economic, environmental, social, and demographic components to an existing system or environment. A process of transition from one qualitative state to another, more perfect one.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/development.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Business",
                        Description="The term business refers to an organization or enterprising entity engaged in commercial, industrial, or professional activities. The purpose of a business is to organize some sort of economic production of goods or services.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/business.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Finance and Accounting",
                        Description="Financial accounting is a specific branch of accounting involving a process of recording, summarizing, and reporting the myriad of transactions resulting from business operations over a period of time. These transactions are summarized in the preparation of financial statements—including the balance sheet, income statement, and cash flow statement—that record a company’s operating performance over a specified period.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/financeandaccounting.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="It and Software",
                        Description="Even for people who have an understanding of the space, drawing a line between the two can be confusing. They’re even lumped together in common statistics. For example, according to CompTIA, there are more than 525,000 software and IT services companies in the United States alone. ",
                        CategoryPhotoPath="https://localhost:7030/images/categories/itandsoftware.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Office Productivity",
                        Description="Productivity has a lot to do with the physical office, but it can be affected by management as well. Workers not only need spaces that are high performing, but they also need supportive management.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/officeproductivity.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Personal Development",
                        Description="Personal development is a lifelong process. It is a way for people to assess their skills and qualities, consider their aims in life and set goals in order to realise and maximise their potential.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/personaldevelopment.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Design",
                        Description="A design is the concept of or proposal for an object, process, or system. Design refers to something that is or has been intentionally created by a thinking agent, though it is sometimes used to refer to the nature of something – its design.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/design.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Marketing",
                        Description="Marketing is the process of getting the public educated on and excited about an organization's products and services. A marketing team's efforts in market research and consumer trends guides the strategy behind other aspects of the business and helps companies to consistently meet the needs of consumers.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/marketing.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Lifestyle",
                        Description="Lifestyle is the interests, opinions, behaviours, and behavioural orientations of an individual, group, or culture.[1][2] The term was introduced by Austrian psychologist Alfred Adler in his 1929 book, The Case of Miss R., with the meaning of \"a person's basic character as established early in childhood\".[3] The broader sense of lifestyle as a \"way or style of living\" has been documented since 1961.[3] Lifestyle is a combination of determining intangible or tangible factors. Tangible factors relate specifically to demographic variables, i.e. an individual's demographic profile, whereas intangible factors concern the psychological aspects of an individual such as personal values, preferences, and outlooks.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/lifestyle.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Photography and Video",
                        Description="What Is Photography And Videography? Photographers and videographers work to capture still and moving moments respectively for a wide number of applications. Videography is used to create video content, and use audio equipment and video cameras to sound and capture moving scenes and document events.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/photographyvideo.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Health and Fitness",
                        Description="Health is a state of complete physical, mental and social well-being and not merely absence of disease [1]. Fitness is an ability to execute daily functional activities with optimal performance, endurance, and strength to manage minimalist of disease, fatigue, stress and reduced sedentary behavior",
                        CategoryPhotoPath="https://localhost:7030/images/categories/fitness.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Music",
                        Description="Music is an ancient art form that began during prehistoric times and carries with it a history for each human culture throughout the world. Characteristics of music include: sound, melody, harmony, rhythm or the driving beats in a measure or section of music, structure or form, texture, and expression.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/music.jpg"
                    },
                    new CategoryModel()
                    {
                        Name="Teaching and Academics",
                        Description="In the last decade, several classifications of the ways in whichacademics conceptualise teaching and learning have been proposed,including our scheme (Samuelowicz and Bain 1992). This paper reassessesthe framework described in our earlier paper, evaluates the adequacy ofthe belief dimensions and categories in that framework and considerswhether there is a `transitional'' orientation to teaching and learningas argued by Kember (1997a) in his recent synthesis of the domain.",
                        CategoryPhotoPath="https://localhost:7030/images/categories/teaching.jpg"
                    }
                    #endregion
                };
                await db.categories.AddRangeAsync(categories);
                await db.SaveChangesAsync();
            }
            if (!db.topic.Any())
            {
                List<TopicModel> list = new List<TopicModel>()
                {
                    #region
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
                        Description="A programming language is a system of notation for writing computer programs.[1]\r\n\r\nProgramming languages are described in terms of their syntax (form) and semantics (meaning), usually defined by a formal language. Languages usually provide features such as a type system, variables and mechanisms for error handling. An implementation of a programming language in the form of a compiler or interpreter allows programs to be executed, either directly or by producing what's known in programming as an executable.",
                        TopicPhotoPath="https://localhost:7030/images/topics/programminglanguages.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Game Development",
                        Description="Game Development is the art of creating games and describes the design, development and release of a game. It may involve concept generation, design, build, test and release. While you create a game, it is important to think about the game mechanics, rewards, player engagement and level design.\r\n\r\nA game developer could be a programmer, a sound designer, an artist, a designer or many other roles available in the industry.\r\n\r\nGame Development can be undertaken by a large Game Development Studio or by a single individual. It can be as small or large as you like. As long as it lets the player interact with content and is able to manipulate the game’s elements, you can call it a ‘game’.",
                        TopicPhotoPath="https://localhost:7030/images/topics/gamedevelopment.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Database Design and Development",
                        Description="Database development is designing, creating a database or data model, and analyzing requirements and their intents as raw data. Database development aims to create a structure that will allow for the efficient storage and retrieval of data. Being a blueprint for the database, it should meet the needs of business.",
                        TopicPhotoPath="https://localhost:7030/images/topics/databasedesignanddevelopment.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Software Testing",
                        Description="Software testing is the process of evaluating and verifying that a software product or application does what it's supposed to do. The benefits of good testing include preventing bugs and improving performance. Verify and validate application quality to ensure it meets user requirements.",
                        TopicPhotoPath="https://localhost:7030/images/topics/softwaretesting.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Software Engineering",
                        Description="Software engineering is the branch of computer science that deals with the design, development, testing, and maintenance of software applications. Software engineers apply engineering principles and knowledge of programming languages to build software solutions for end users.",
                        TopicPhotoPath="https://localhost:7030/images/topics/softwareengineering.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="Software Development Tools",
                        Description="Software developer tools are specialized software or applications to help the developers. In making or testing software, these tools help the developer a lot. Suppose you are an experienced programmer or just starting your journey. In that case, these software development tools act as a helping hand. It will help find the complex things of coding and debug them. \r\n\r\nThis blog will discuss one of the two main aspects of Software development tools. First are the key reasons to use software development tools, and we will share the best software development tool list. ",
                        TopicPhotoPath="https://localhost:7030/images/topics/softwaredevelopmenttools.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                   new TopicModel()
                    {
                        Name="No-Code Development",
                        Description="No-code development platforms (NCDPs) allow creating application software through graphical user interfaces and configuration instead of traditional computer programming based on writing code.\r\n\r\nNo-code development platforms are closely related to low-code development platforms as both are designed to expedite the application development process.[1] However, unlike low-code, no-code development platforms require no code writing at all, generally offering prebuilt templates that businesses can build apps with.[2] In the 2010s, these platforms have both increased in popularity as companies deal with a limited supply of competent software developers",
                        TopicPhotoPath="https://localhost:7030/images/topics/nocodedevelopment.jpg",
                        Category=await db.categories.FirstOrDefaultAsync(x=>x.Id==1)
                    },

                    #endregion
                };
                await db.topic.AddRangeAsync(list);
                await db.SaveChangesAsync();
            }
            if (!db.popularTopics.Any())
            {
                List<PopularTopicModel> popularTopicModels = new List<PopularTopicModel>()
                {
                    #region
                    new PopularTopicModel()
                    {
                        Name="JavaScript",
                        Description="JavaScript is a scripting or programming language that allows you to implement complex features on web pages — every time a web page does more than just sit there and display static information for you to look at — displaying timely content updates, interactive maps, animated 2D/3D graphics, scrolling video jukeboxes, etc. — you can bet that JavaScript is probably involved. It is the third layer of the layer cake of standard web technologies, two of which (HTML and CSS) we have covered in much more detail in other parts of the Learning Area.",
                        PopularTopicPhotoPath="https://localhost:7030/images/populartopics/javascript.jpg",
                        Topic=await db.topic.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new PopularTopicModel()
                    {
                        Name="React JS",
                        Description="React.js is an open-source JavaScript library, crafted with precision by Facebook, that aims to simplify the intricate process of building interactive user interfaces. Imagine a user interface built with React as a collection of components, each responsible for outputting a small, reusable piece of HTML code.",
                        PopularTopicPhotoPath="https://localhost:7030/images/populartopics/reactjs.jpg",
                        Topic=await db.topic.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new PopularTopicModel()
                    {
                        Name="Angular",
                        Description="Angular is a web framework that empowers developers to build fast, reliable applications.\r\nMaintained by a dedicated team at Google, Angular provides a broad suite of tools, APIs, and libraries to simplify and streamline your development workflow. Angular gives you a solid platform on which to build fast, reliable applications that scale with both the size of your team and the size of your codebase.\r\n\r\nWant to see some code? Jump over to our Essentials for a quick overview of what it's like to use Angular, or get started in the Tutorial if you prefer following step-by-step instructions.",
                        PopularTopicPhotoPath="https://localhost:7030/images/populartopics/angular.jpg",
                        Topic=await db.topic.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new PopularTopicModel()
                    {
                        Name="Next.js",
                        Description="Next.js is an open-source web development framework created by the private company Vercel providing React-based web applications with server-side rendering and static website generation.\r\n\r\nReact documentation mentions Next.js among \"Recommended Toolchains\" advising it to developers when \"building a server-rendered website with Node.js\".[6] Where traditional React apps can only render their content in the client-side browser, Next.js extends this functionality to include applications rendered on the server-side.",
                        PopularTopicPhotoPath="https://localhost:7030/images/populartopics/nextjs.jpg",
                        Topic=await db.topic.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new PopularTopicModel()
                    {
                        Name="CSS",
                        Description="Cascading Style Sheets (CSS) is a style sheet language used for specifying the presentation and styling of a document written in a markup language such as HTML or XML (including XML dialects such as SVG, MathML or XHTML).[1] CSS is a cornerstone technology of the World Wide Web, alongside HTML and JavaScript.[2]\r\n\r\nCSS is designed to enable the separation of content and presentation, including layout, colors, and fonts.[3] This separation can improve content accessibility;[further explanation needed] provide more flexibility and control in the specification of presentation characteristics; enable multiple web pages to share formatting by specifying the relevant CSS in a separate .css file, which reduces complexity and repetition in the structural content; and enable the .css file to be cached to improve the page load speed between the pages that share the file and its formatting.",
                        PopularTopicPhotoPath="https://localhost:7030/images/populartopics/css.jpg",
                        Topic=await db.topic.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new PopularTopicModel()
                    {
                        Name="HTML",
                        Description="HyperText Markup Language (HTML) is the standard markup language for documents designed to be displayed in a web browser. It defines the content and structure of web content. It is often assisted by technologies such as Cascading Style Sheets (CSS) and scripting languages such as JavaScript.\r\n\r\nWeb browsers receive HTML documents from a web server or from local storage and render the documents into multimedia web pages. HTML describes the structure of a web page semantically and originally included cues for its appearance.",
                        PopularTopicPhotoPath="https://localhost:7030/images/populartopics/html.jpg",
                        Topic=await db.topic.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new PopularTopicModel()
                    {
                        Name="ASP.NET Core",
                        Description="ASP.NET Core is designed to allow runtime components, APIs, compilers, and languages evolve quickly, while still providing a stable and supported platform to keep apps running.\r\n\r\nMultiple versions of ASP.NET Core can exist side by side on the same server. Meaning one app can adopt the latest version, while other apps keep running on the version they were tested on.\r\n\r\nASP.NET Core provides various support lifecycle options to meet the needs of your app. You can choose a long-term support release or run with the latest release if you commit to upgrade more often. See our support policy for more details.",
                        PopularTopicPhotoPath="https://localhost:7030/images/populartopics/aspnetcore.jpg",
                        Topic=await db.topic.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    new PopularTopicModel()
                    {
                        Name="Node.Js",
                        Description="As an asynchronous event-driven JavaScript runtime, Node.js is designed to build scalable network applications. In the following \"hello world\" example, many connections can be handled concurrently. Upon each connection, the callback is fired, but if there is no work to be done, Node.js will sleep. This is in contrast to today's more common concurrency model, in which OS threads are employed. Thread-based networking is relatively inefficient and very difficult to use. Furthermore, users of Node.js are free from worries of dead-locking the process, since there are no locks. Almost no function in Node.js directly performs I/O, so the process never blocks except when the I/O is performed using synchronous methods of Node.js standard library. Because nothing blocks, scalable systems are very reasonable to develop in Node.js.",
                        PopularTopicPhotoPath="https://localhost:7030/images/populartopics/nodejs.jpg",
                        Topic=await db.topic.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    #endregion
                };
                await db.popularTopics.AddRangeAsync(popularTopicModels);
                await db.SaveChangesAsync();
            }
            if (!db.authers.Any())
            {
                List<AutherModel> authers = new List<AutherModel>()
                {
                    #region
                    new AutherModel()
                    {
                        FullName="Robiya Hakimova",
                        Exprince="Soha boyicha 8 yillik tajriba dars otish boyicha 3 yillik",
                        About=".Net FullStack Developer",
                        Gmail="robiyahakimova2003@gmail.com",
                        AutherPhotoPath="https://localhost:7030/images/authers/robiya.jpg"
                    },
                    new AutherModel()
                    {
                        FullName="Solijova Zuxra",
                        Exprince="Soha boyicha 5 yillik tajriba dars otish boyicha 1 yillik",
                        About="NodeJs FullStack Developer",
                        Gmail="solijonovazuhra@gmail.com",
                        AutherPhotoPath="https://localhost:7030/images/authers/zuhra.jpg"
                    },
                    new AutherModel()
                    {
                        FullName="Ehtiromxon Dumaboyeva",
                        Exprince="Soha boyicha 18 yillik tajriba dars otish boyicha 13 yillik",
                        About="Nextjs FullStack Developer",
                        Gmail="ehtiromxondumaboyeva@gmail.com",
                        AutherPhotoPath="https://localhost:7030/images/authers/ehtiromxon.jpg"
                    },
                    new AutherModel()
                    {
                        FullName="Baxtiyorova Dilnura",
                        Exprince="Soha boyicha 9 yillik tajriba dars otish boyicha 5 yillik",
                        About="Go FullStack Developer",
                        Gmail="baxtiyorovadilnura@gmail.com",
                        AutherPhotoPath="https://localhost:7030/images/authers/dilnura.jpg"
                    },
                    new AutherModel()
                    {
                        FullName="Baxtiniso Mirzayeva",
                        Exprince="Soha boyicha 15 yillik tajriba dars otish boyicha 2 yillik",
                        About="C++ Developer",
                        Gmail="baxtinisomirzayeva@gmail.com",
                        AutherPhotoPath="https://localhost:7030/images/authers/baxtiniso.jpg"
                    },
                    new AutherModel()
                    {
                        FullName="Sitora Farmonova",
                        Exprince="Soha boyicha 20 yillik tajriba dars otish boyicha 10 yillik",
                        About="Software Developer",
                        Gmail="sitorafarmonova@gmail.com",
                        AutherPhotoPath="https://localhost:7030/images/authers/sitora.jpg"
                    },
                    new AutherModel()
                    {
                        FullName="Ozoda Hakimova",
                        Exprince="Soha boyicha 17 yillik tajriba dars otish boyicha 7 yillik",
                        About="Frontend Developer",
                        Gmail="ozodahaakimova@gmail.com",
                        AutherPhotoPath="https://localhost:7030/images/authers/ozoda.jpg"
                    },
                    new AutherModel()
                    {
                        FullName="Abdug'apporova Omina",
                        Exprince="Soha boyicha 13 yillik tajriba dars otish boyicha 3 yillik",
                        About="Java FullStack Developer",
                        Gmail="ominaabdugapporova@gmail.com",
                        AutherPhotoPath="https://localhost:7030/images/authers/omina.jpg"
                    },
                    #endregion

                };
                await db.authers.AddRangeAsync(authers);
                await db.SaveChangesAsync();
            }
            if (!db.courses.Any())
            {
                List<CourseModel> courses = new List<CourseModel>()
                { 
                    #region
                    // 1
                    new CourseModel()
                    {
                        name="JavaScript asoslari",
                        description="JavaScript kursi dasturchilikni o‘rganmoqchi bo‘lganlar uchun muhim qadamdir. Ushbu kurslar JavaScriptni noldan boshlab o‘rganish uchun mo‘ljallangan va dasturchilikda zarur bo‘lgan ko‘nikmalarni shakllantiradi.lash Konsepsiyalari**\r\n  Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tugatgandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"Eloquent JavaScript\", \"JavaScript: The Good Parts\".\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub.\r\nJavaScript kurslari dasturlashda birinchi qadamni qo‘yish yoki mavjud bilimlarni rivojlantirish uchun ajoyib imkoniyatdir. Kursni tamomlaganingizdan so‘ng, veb-ishlanmalar bo‘yicha kuchli poydevorga ega bo‘lasiz.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript1.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==1),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //2
                    new CourseModel()
                    {
                        name="JavaScript va TypeScript",
                         description="JavaScript va TypeScript kurslari dasturchilar uchun muhim o‘quv dasturlaridir. Ular nafaqat veb-dasturlash asoslarini o‘rganish, balki kompleks ilovalarni yaratish uchun zarur bo‘lgan ko‘nikmalarni rivojlantirishga yordam beradi. Quyida JavaScript va TypeScript kurslarining umumiy mazmuni haqida batafsil ma'lumot keltirilgan. Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tamomlagandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"Eloquent JavaScript\", \"JavaScript: The Good Parts\", \"Pro TypeScript\".\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub.\r\nJavaScript va TypeScript kurslari dasturchilikda kuchli poydevor yaratishga yordam beradi, va bu til va texnologiyalarni o‘zlashtirish orqali ko‘plab yangi imkoniyatlarga ega bo‘lish mumkin.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript2.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==2),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //3
                    new CourseModel()
                    {
                        name="HTML CSS JavaScript",
                         description="Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tamomlagandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"HTML & CSS: Design and Build Websites\" (Jon Duckett), \"Eloquent JavaScript\" (Marijn Haverbeke).\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub. HTML, CSS va JavaScript kurslari veb-dasturlashning asosiy texnologiyalarini o‘rganish uchun muhimdir. Bu kurslar veb-sahifalar yaratish va ularni dinamik va interaktiv qilish imkonini beradi. Quyida HTML, CSS va JavaScript kurslarining umumiy mazmuni haqida ma'lumot keltirilgan.HTML, CSS va JavaScript kurslari dasturchilikda birinchi qadamni qo‘yish yoki mavjud bilimlarni rivojlantirish uchun ajoyib imkoniyatdir. Bu til va texnologiyalarni o‘zlashtirish orqali ko‘plab yangi imkoniyatlarga ega bo‘lish mumkin.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript3.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==3),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //4
                    new CourseModel()
                    {
                        name="Frontend asoslari",
                        description="Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tamomlagandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"HTML & CSS: Design and Build Websites\" (Jon Duckett), \"Eloquent JavaScript\" (Marijn Haverbeke).\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub. HTML, CSS va JavaScript kurslari veb-dasturlashning asosiy texnologiyalarini o‘rganish uchun muhimdir. Bu kurslar veb-sahifalar yaratish va ularni dinamik va interaktiv qilish imkonini beradi. Quyida HTML, CSS va JavaScript kurslarining umumiy mazmuni haqida ma'lumot keltirilgan.HTML, CSS va JavaScript kurslari dasturchilikda birinchi qadamni qo‘yish yoki mavjud bilimlarni rivojlantirish uchun ajoyib imkoniyatdir. Bu til va texnologiyalarni o‘zlashtirish orqali ko‘plab yangi imkoniyatlarga ega bo‘lish mumkin.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript4.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==4),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //5
                    new CourseModel()
                    {
                        name="React Js va JavaScript",
                        description="React.js va JavaScript kursi veb-dasturlashning old qismi bilan ishlashni o‘rgatadi. Ushbu kurslar orqali dasturchilar foydalanuvchilar bilan o‘zaro aloqada bo‘ladigan veb-sahifalar va ilovalarni yaratish uchun zarur bo‘lgan ko‘nikmalarga ega bo‘ladilar. Quyida React.js va JavaScript kurslarining umumiy mazmuni va qamrovini ko‘rsatadigan batafsil ma'lumotlar keltirilgan. Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tamomlagandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"Eloquent JavaScript\" (Marijn Haverbeke), \"JavaScript: The Good Parts\" (Douglas Crockford), \"React Up & Running\" (Stoyan Stefanov).\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub.\r\nReact.js va JavaScript kurslari dasturlashni o‘rganmoqchi bo‘lganlar uchun juda muhimdir. Bu kurslar orqali dasturchilar zamonaviy veb-saytlar va ilovalarni yaratish uchun zarur bo‘lgan bilim va ko‘nikmalarga ega bo‘ladilar.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript5.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==5),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //6
                    new CourseModel()
                    {
                        name="Vue Js va JavaScript",
                        description="Vue.js va JavaScript kursi veb-dasturlashning old qismi bilan ishlashni o‘rgatadi. Ushbu kurslar orqali dasturchilar foydalanuvchilar bilan o‘zaro aloqada bo‘ladigan veb-sahifalar va ilovalarni yaratish uchun zarur bo‘lgan ko‘nikmalarga ega bo‘ladilar. Quyida Vue.js va JavaScript kurslarining umumiy mazmuni va qamrovini ko‘rsatadigan batafsil ma'lumotlar keltirilgan. Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tamomlagandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"Eloquent JavaScript\" (Marijn Haverbeke), \"JavaScript: The Good Parts\" (Douglas Crockford), \"Vue.js Up & Running\" (Callum Macrae).\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub.\r\nVue.js va JavaScript kurslari dasturlashni o‘rganmoqchi bo‘lganlar uchun juda muhimdir. Bu kurslar orqali dasturchilar zamonaviy veb-saytlar va ilovalarni yaratish uchun zarur bo‘lgan bilim va ko‘nikmalarga ega bo‘ladilar.\r\n\r\n\r\n\r\n\r\n\r\n\r\n",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript6.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==6),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //7
                    new CourseModel()
                    {
                        name="JavaScript toliq kurs",
                        description="Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tugatgandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"Eloquent JavaScript\", \"JavaScript: The Good Parts\".\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub.\r\nJavaScript kurslari dasturlashda birinchi qadamni qo‘yish yoki mavjud bilimlarni rivojlantirish uchun ajoyib imkoniyatdir. Kursni tamomlaganingizdan so‘ng, veb-ishlanmalar bo‘yicha kuchli poydevorga ega bo‘lasiz.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript7.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==7),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //8
                    new CourseModel()
                    {
                        name="HTML CSS JAVASCRIPT",
                        description="Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tamomlagandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"HTML & CSS: Design and Build Websites\" (Jon Duckett), \"Eloquent JavaScript\" (Marijn Haverbeke).\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub. HTML, CSS va JavaScript kurslari veb-dasturlashning asosiy texnologiyalarini o‘rganish uchun muhimdir. Bu kurslar veb-sahifalar yaratish va ularni dinamik va interaktiv qilish imkonini beradi. Quyida HTML, CSS va JavaScript kurslarining umumiy mazmuni haqida ma'lumot keltirilgan.HTML, CSS va JavaScript kurslari dasturchilikda birinchi qadamni qo‘yish yoki mavjud bilimlarni rivojlantirish uchun ajoyib imkoniyatdir. Bu til va texnologiyalarni o‘zlashtirish orqali ko‘plab yangi imkoniyatlarga ega bo‘lish mumkin.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript8.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==8),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //9
                    new CourseModel()
                    {
                        name="JavaScript asoslari",
                        description="Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tugatgandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"Eloquent JavaScript\", \"JavaScript: The Good Parts\".\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub.\r\nJavaScript kurslari dasturlashda birinchi qadamni qo‘yish yoki mavjud bilimlarni rivojlantirish uchun ajoyib imkoniyatdir. Kursni tamomlaganingizdan so‘ng, veb-ishlanmalar bo‘yicha kuchli poydevorga ega bo‘lasiz.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript9.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==1),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    //10
                    new CourseModel()
                    {
                        name="Boshlang'ich Frontend kurs",
                        description="Kursning Afzalliklari\r\nInteraktiv Darslar: Amaliy mashqlar va loyihalar yordamida nazariy bilimlarni mustahkamlash.\r\nQo‘llab-quvvatlash: O‘qituvchi yoki mentorlar tomonidan yordam.\r\nHamjamiyat: Boshqa talabalarga savollar berish va tajriba almashish.\r\nSertifikatlar: Kursni muvaffaqiyatli tamomlagandan so‘ng sertifikat olish imkoniyati.\r\nTavsiya Qilinadigan Resurslar\r\nOnline Platformalar: Coursera, Udemy, Codecademy, freeCodeCamp.\r\nKitoblar: \"HTML & CSS: Design and Build Websites\" (Jon Duckett), \"Eloquent JavaScript\" (Marijn Haverbeke).\r\nForumlar va Hamjamiyatlar: Stack Overflow, Reddit, GitHub. HTML, CSS va JavaScript kurslari veb-dasturlashning asosiy texnologiyalarini o‘rganish uchun muhimdir. Bu kurslar veb-sahifalar yaratish va ularni dinamik va interaktiv qilish imkonini beradi. Quyida HTML, CSS va JavaScript kurslarining umumiy mazmuni haqida ma'lumot keltirilgan.HTML, CSS va JavaScript kurslari dasturchilikda birinchi qadamni qo‘yish yoki mavjud bilimlarni rivojlantirish uchun ajoyib imkoniyatdir. Bu til va texnologiyalarni o‘zlashtirish orqali ko‘plab yangi imkoniyatlarga ega bo‘lish mumkin.",
                        CoursePhotoPath="https://localhost:7030/images/courses/javascript10.jpg",
                        auther=await db.authers.FirstOrDefaultAsync(x=>x.id==2),
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1)
                    },
                    #endregion

                };
                await db.courses.AddRangeAsync(courses);
                await db.SaveChangesAsync();
            }
            if (!db.lessons.Any())
            {
                
                List<LessonModel> list = new List<LessonModel>()
                {
                    // course 1 image
                    #region
                    new LessonModel()
                    {
                         name="Kirish va Asoslar",
                         description="JavaScript nima?: Tarixi va qo‘llanilishi.\r\nMuhitni sozlash: Brauzerlar, kod muharrirlari (VS Code, Sublime Text).\r\nHello, World!: Birinchi JavaScript dasturini yozish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson1.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    new LessonModel()
                    {
                         name="Asosiy Dasturlash Konsepsiyalari",
                         description="O‘zgaruvchilar va Ma'lumot Turlari: let, const, raqamlar, satrlar, massivlar, ob’ektlar.\r\nOperatorlar va Ifodalar: Matematik, mantiqiy va taqqoslash operatorlari.\r\nShartli Operatsiyalar: if, else if, else, switch bayonotlari.\r\nTsykllar: for, while, do while tsikllari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson2.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    new LessonModel()
                    {
                         name="Funksiyalar",
                         description="Funksiya E’lon qilish: Oddiy funksiyalar, anonim funksiyalar, o‘zgaruvchan funksiyalar.\r\nFunksional Programmalar: Callbacklar, arrow funksiyalar (=>).",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson3.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    new LessonModel()
                    {
                         name="DOM (Document Object Model) bilan Ishlash",
                         description="DOM Nima?: HTML tarkibini JavaScript orqali o‘zgartirish.\r\nElementlarni Tanlash: getElementById, querySelector, va boshqalar.\r\nHodisalarni Boshqarish: Eventlar, hodisalar bilan ishlash (addEventListener).",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson4.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    new LessonModel()
                    {
                         name="Asinxron JavaScript",
                         description="Timerlar: setTimeout, setInterval.\r\nCallbacks: Asinxron jarayonlarni boshqarish.\r\nPromises: Asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: Asinxron kodni soddalashtirish.\r\n",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson5.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    new LessonModel()
                    {
                         name="JavaScript Kutubxona va Ramkalari",
                         description="jQuery: JavaScriptni yengillashtiruvchi kutubxona.\r\nReact.js: Foydalanuvchi interfeysi yaratish uchun kutubxona.\r\nVue.js va Angular: Kompleks ilovalar uchun boshqa mashhur ramkalar.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson6.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    new LessonModel()
                    {
                         name="Server Tomoni JavaScript",
                         description="Node.js: Server tomonida JavaScriptni ishlatish.\r\nExpress.js: Node.js uchun ramka.\r\nAPIs va RESTful Servislar: Backend bilan o‘zaro aloqa.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson7.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    new LessonModel()
                    {
                         name="Amaliy Loyihalar",
                         description="Kichik Loyihalar: Oddiy veb-sahifalar va o‘yinlar.\r\nKatta Loyihalar: Kompleks veb-ilovalar va foydalanuvchi interfeyslari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson8.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    #endregion

                    // course 7 image
                    #region
                    new LessonModel()
                    {
                         name="Kirish va Asoslar",
                         description="JavaScript nima?: Tarixi va qo‘llanilishi.\r\nMuhitni sozlash: Brauzerlar, kod muharrirlari (VS Code, Sublime Text).\r\nHello, World!: Birinchi JavaScript dasturini yozish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson9.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                    new LessonModel()
                    {
                         name="Asosiy Dasturlash Konsepsiyalari",
                         description="O‘zgaruvchilar va Ma'lumot Turlari: let, const, raqamlar, satrlar, massivlar, ob’ektlar.\r\nOperatorlar va Ifodalar: Matematik, mantiqiy va taqqoslash operatorlari.\r\nShartli Operatsiyalar: if, else if, else, switch bayonotlari.\r\nTsykllar: for, while, do while tsikllari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson10.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                    new LessonModel()
                    {
                         name="Funksiyalar",
                         description="Funksiya E’lon qilish: Oddiy funksiyalar, anonim funksiyalar, o‘zgaruvchan funksiyalar.\r\nFunksional Programmalar: Callbacklar, arrow funksiyalar (=>).",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson1.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                    new LessonModel()
                    {
                         name="DOM (Document Object Model) bilan Ishlash",
                         description="DOM Nima?: HTML tarkibini JavaScript orqali o‘zgartirish.\r\nElementlarni Tanlash: getElementById, querySelector, va boshqalar.\r\nHodisalarni Boshqarish: Eventlar, hodisalar bilan ishlash (addEventListener).",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson2.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                    new LessonModel()
                    {
                         name="Asinxron JavaScript",
                         description="Timerlar: setTimeout, setInterval.\r\nCallbacks: Asinxron jarayonlarni boshqarish.\r\nPromises: Asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: Asinxron kodni soddalashtirish.\r\n",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson3.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                    new LessonModel()
                    {
                         name="JavaScript Kutubxona va Ramkalari",
                         description="jQuery: JavaScriptni yengillashtiruvchi kutubxona.\r\nReact.js: Foydalanuvchi interfeysi yaratish uchun kutubxona.\r\nVue.js va Angular: Kompleks ilovalar uchun boshqa mashhur ramkalar.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson4.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                    new LessonModel()
                    {
                         name="Server Tomoni JavaScript",
                         description="Node.js: Server tomonida JavaScriptni ishlatish.\r\nExpress.js: Node.js uchun ramka.\r\nAPIs va RESTful Servislar: Backend bilan o‘zaro aloqa.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson5.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                    new LessonModel()
                    {
                         name="Amaliy Loyihalar",
                         description="Kichik Loyihalar: Oddiy veb-sahifalar va o‘yinlar.\r\nKatta Loyihalar: Kompleks veb-ilovalar va foydalanuvchi interfeyslari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson6.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                    #endregion

                    // course 9 image
                    #region
                    new LessonModel()
                    {
                         name="Kirish va Asoslar",
                         description="JavaScript nima?: Tarixi va qo‘llanilishi.\r\nMuhitni sozlash: Brauzerlar, kod muharrirlari (VS Code, Sublime Text).\r\nHello, World!: Birinchi JavaScript dasturini yozish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson7.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                    new LessonModel()
                    {
                         name="Asosiy Dasturlash Konsepsiyalari",
                         description="O‘zgaruvchilar va Ma'lumot Turlari: let, const, raqamlar, satrlar, massivlar, ob’ektlar.\r\nOperatorlar va Ifodalar: Matematik, mantiqiy va taqqoslash operatorlari.\r\nShartli Operatsiyalar: if, else if, else, switch bayonotlari.\r\nTsykllar: for, while, do while tsikllari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson8.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                    new LessonModel()
                    {
                         name="Funksiyalar",
                         description="Funksiya E’lon qilish: Oddiy funksiyalar, anonim funksiyalar, o‘zgaruvchan funksiyalar.\r\nFunksional Programmalar: Callbacklar, arrow funksiyalar (=>).",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson9.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                    new LessonModel()
                    {
                         name="DOM (Document Object Model) bilan Ishlash",
                         description="DOM Nima?: HTML tarkibini JavaScript orqali o‘zgartirish.\r\nElementlarni Tanlash: getElementById, querySelector, va boshqalar.\r\nHodisalarni Boshqarish: Eventlar, hodisalar bilan ishlash (addEventListener).",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson10.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                    new LessonModel()
                    {
                         name="Asinxron JavaScript",
                         description="Timerlar: setTimeout, setInterval.\r\nCallbacks: Asinxron jarayonlarni boshqarish.\r\nPromises: Asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: Asinxron kodni soddalashtirish.\r\n",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson1.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                    new LessonModel()
                    {
                         name="JavaScript Kutubxona va Ramkalari",
                         description="jQuery: JavaScriptni yengillashtiruvchi kutubxona.\r\nReact.js: Foydalanuvchi interfeysi yaratish uchun kutubxona.\r\nVue.js va Angular: Kompleks ilovalar uchun boshqa mashhur ramkalar.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson2.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                    new LessonModel()
                    {
                         name="Server Tomoni JavaScript",
                         description="Node.js: Server tomonida JavaScriptni ishlatish.\r\nExpress.js: Node.js uchun ramka.\r\nAPIs va RESTful Servislar: Backend bilan o‘zaro aloqa.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson3.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                    new LessonModel()
                    {
                         name="Amaliy Loyihalar",
                         description="Kichik Loyihalar: Oddiy veb-sahifalar va o‘yinlar.\r\nKatta Loyihalar: Kompleks veb-ilovalar va foydalanuvchi interfeyslari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson4.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                    #endregion

                    // course3 image
                    #region
                    new LessonModel()
                    {
                         name="1. HTML (HyperText Markup Language)\r\nHTML veb-sahifaning tuzilishini yaratish uchun ishlatiladi.",
                         description="Kirish va Asoslar:\r\n\r\nHTML nima va nima uchun kerak?\r\nHTML fayl tuzilishi (doctype, html, head, body teglar).\r\nElementlar va Teglar:\r\n\r\nAsosiy teglar: <!DOCTYPE html>, <html>, <head>, <body>, <title>, <h1>-<h6>, <p>, <a>, <img>, <ul>, <ol>, <li>, <div>, <span>, va hokazo.\r\nFormalar va kiritish elementlari: <form>, <input>, <textarea>, <button>, <select>, <option>.\r\nMatnni Formatlash:\r\n\r\nMatn teglar: <strong>, <em>, <br>, <hr>, <blockquote>, <code>.\r\nMultimedia Elementlar:\r\n\r\nRasmlar: <img>.\r\nVideo va audio: <video>, <audio>.\r\nSemantik HTML:\r\n\r\nSemantik teglar: <header>, <nav>, <section>, <article>, <footer>.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson5.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==3)
                    },
                    new LessonModel()
                    {
                         name="2. CSS (Cascading Style Sheets)\r\nCSS veb-sahifalarning ko‘rinishini va tuzilishini boshqarish uchun ishlatiladi.",
                         description="\r\nHTML, CSS va JavaScript kurslari veb-dasturlashning asosiy texnologiyalarini o‘rganish uchun muhimdir. Bu kurslar veb-sahifalar yaratish va ularni dinamik va interaktiv qilish imkonini beradi. Quyida HTML, CSS va JavaScript kurslarining umumiy mazmuni haqida ma'lumot keltirilgan.\r\n\r\nKursning Tuzilishi\r\n1. HTML (HyperText Markup Language)\r\nHTML veb-sahifaning tuzilishini yaratish uchun ishlatiladi.\r\n\r\nMavzular:\r\nKirish va Asoslar:\r\n\r\nHTML nima va nima uchun kerak?\r\nHTML fayl tuzilishi (doctype, html, head, body teglar).\r\nElementlar va Teglar:\r\n\r\nAsosiy teglar: <!DOCTYPE html>, <html>, <head>, <body>, <title>, <h1>-<h6>, <p>, <a>, <img>, <ul>, <ol>, <li>, <div>, <span>, va hokazo.\r\nFormalar va kiritish elementlari: <form>, <input>, <textarea>, <button>, <select>, <option>.\r\nMatnni Formatlash:\r\n\r\nMatn teglar: <strong>, <em>, <br>, <hr>, <blockquote>, <code>.\r\nMultimedia Elementlar:\r\n\r\nRasmlar: <img>.\r\nVideo va audio: <video>, <audio>.\r\nSemantik HTML:\r\n\r\nSemantik teglar: <header>, <nav>, <section>, <article>, <footer>.\r\n2. CSS (Cascading Style Sheets)\r\nCSS veb-sahifalarning ko‘rinishini va tuzilishini boshqarish uchun ishlatiladi.\r\n\r\nMavzular:\r\nKirish va Asoslar:\r\n\r\nCSS nima va nima uchun kerak?\r\nCSS fayllarni HTML bilan bog‘lash: <style> teglar va <link> elementi.\r\nSintaksis va Selektorlar:\r\n\r\nCSS sintaksisi: selektor, property, value.\r\nAsosiy selektorlar: element, class, id, attribute selektorlar.\r\nRanglar va Fonlar:\r\n\r\nRanglar: rang nomlari, HEX, RGB, RGBA, HSL.\r\nFonlar: background-color, background-image, background-repeat, background-position, background-size.\r\nMatnni Stilizatsiya qilish:\r\n\r\nMatn stilizatsiyasi: color, font-family, font-size, font-weight, line-height, text-align.\r\nLayout va Positioning:\r\n\r\nBox model: margin, border, padding, content.\r\nPositioning: static, relative, absolute, fixed, sticky.\r\nDisplay: block, inline, inline-block, none.\r\nFlexbox va Grid layoutlari.\r\nResponsive Design:\r\n\r\nMedia queries.\r\nResponsive dizayn prinsiplari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson6.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==3)
                    },
                    new LessonModel()
                    {
                         name="3. JavaScript\r\nJavaScript veb-sahifalarga interaktivlik qo‘shish uchun ishlatiladi.",
                         description="Kirish va Asoslar:\r\n\r\nJavaScript nima va nima uchun kerak?\r\nJavaScriptni HTML bilan bog‘lash: <script> tegi.\r\nSintaksis va Asosiy Konsepsiyalar:\r\n\r\nO‘zgaruvchilar va Ma'lumot Turlari: let, const, raqamlar, satrlar, massivlar, ob’ektlar.\r\nOperatorlar va Ifodalar: matematik, mantiqiy, taqqoslash operatorlari.\r\nShartli Operatsiyalar: if, else if, else, switch.\r\nTsykllar: for, while, do while.\r\nFunksiyalar:\r\n\r\nFunksiya e’lon qilish: oddiy funksiyalar, anonim funksiyalar, arrow funksiyalar.\r\nFunksional programmalar: callbacklar, higher-order functions.\r\nDOM (Document Object Model) bilan Ishlash:\r\n\r\nDOM nima? HTML tarkibini JavaScript orqali o‘zgartirish.\r\nElementlarni tanlash: getElementById, querySelector, va boshqalar.\r\nHodisalarni boshqarish: eventlar, hodisalar bilan ishlash (addEventListener).\r\nAsinxron JavaScript:\r\n\r\nTimerlar: setTimeout, setInterval.\r\nCallbacks: asinxron jarayonlarni boshqarish.\r\nPromises: asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: asinxron kodni soddalashtirish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson7.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==4)
                    },
                    #endregion


                    // course 4 image
                    #region
                    new LessonModel()
                    {
                         name="1. HTML (HyperText Markup Language)\r\nHTML veb-sahifaning tuzilishini yaratish uchun ishlatiladi.",
                         description="Kirish va Asoslar:\r\n\r\nHTML nima va nima uchun kerak?\r\nHTML fayl tuzilishi (doctype, html, head, body teglar).\r\nElementlar va Teglar:\r\n\r\nAsosiy teglar: <!DOCTYPE html>, <html>, <head>, <body>, <title>, <h1>-<h6>, <p>, <a>, <img>, <ul>, <ol>, <li>, <div>, <span>, va hokazo.\r\nFormalar va kiritish elementlari: <form>, <input>, <textarea>, <button>, <select>, <option>.\r\nMatnni Formatlash:\r\n\r\nMatn teglar: <strong>, <em>, <br>, <hr>, <blockquote>, <code>.\r\nMultimedia Elementlar:\r\n\r\nRasmlar: <img>.\r\nVideo va audio: <video>, <audio>.\r\nSemantik HTML:\r\n\r\nSemantik teglar: <header>, <nav>, <section>, <article>, <footer>.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson8.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==4)
                    },
                    new LessonModel()
                    {
                         name="2. CSS (Cascading Style Sheets)\r\nCSS veb-sahifalarning ko‘rinishini va tuzilishini boshqarish uchun ishlatiladi.",
                         description="\r\nHTML, CSS va JavaScript kurslari veb-dasturlashning asosiy texnologiyalarini o‘rganish uchun muhimdir. Bu kurslar veb-sahifalar yaratish va ularni dinamik va interaktiv qilish imkonini beradi. Quyida HTML, CSS va JavaScript kurslarining umumiy mazmuni haqida ma'lumot keltirilgan.\r\n\r\nKursning Tuzilishi\r\n1. HTML (HyperText Markup Language)\r\nHTML veb-sahifaning tuzilishini yaratish uchun ishlatiladi.\r\n\r\nMavzular:\r\nKirish va Asoslar:\r\n\r\nHTML nima va nima uchun kerak?\r\nHTML fayl tuzilishi (doctype, html, head, body teglar).\r\nElementlar va Teglar:\r\n\r\nAsosiy teglar: <!DOCTYPE html>, <html>, <head>, <body>, <title>, <h1>-<h6>, <p>, <a>, <img>, <ul>, <ol>, <li>, <div>, <span>, va hokazo.\r\nFormalar va kiritish elementlari: <form>, <input>, <textarea>, <button>, <select>, <option>.\r\nMatnni Formatlash:\r\n\r\nMatn teglar: <strong>, <em>, <br>, <hr>, <blockquote>, <code>.\r\nMultimedia Elementlar:\r\n\r\nRasmlar: <img>.\r\nVideo va audio: <video>, <audio>.\r\nSemantik HTML:\r\n\r\nSemantik teglar: <header>, <nav>, <section>, <article>, <footer>.\r\n2. CSS (Cascading Style Sheets)\r\nCSS veb-sahifalarning ko‘rinishini va tuzilishini boshqarish uchun ishlatiladi.\r\n\r\nMavzular:\r\nKirish va Asoslar:\r\n\r\nCSS nima va nima uchun kerak?\r\nCSS fayllarni HTML bilan bog‘lash: <style> teglar va <link> elementi.\r\nSintaksis va Selektorlar:\r\n\r\nCSS sintaksisi: selektor, property, value.\r\nAsosiy selektorlar: element, class, id, attribute selektorlar.\r\nRanglar va Fonlar:\r\n\r\nRanglar: rang nomlari, HEX, RGB, RGBA, HSL.\r\nFonlar: background-color, background-image, background-repeat, background-position, background-size.\r\nMatnni Stilizatsiya qilish:\r\n\r\nMatn stilizatsiyasi: color, font-family, font-size, font-weight, line-height, text-align.\r\nLayout va Positioning:\r\n\r\nBox model: margin, border, padding, content.\r\nPositioning: static, relative, absolute, fixed, sticky.\r\nDisplay: block, inline, inline-block, none.\r\nFlexbox va Grid layoutlari.\r\nResponsive Design:\r\n\r\nMedia queries.\r\nResponsive dizayn prinsiplari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson9.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==4)
                    },
                    new LessonModel()
                    {
                         name="3. JavaScript\r\nJavaScript veb-sahifalarga interaktivlik qo‘shish uchun ishlatiladi.",
                         description="Kirish va Asoslar:\r\n\r\nJavaScript nima va nima uchun kerak?\r\nJavaScriptni HTML bilan bog‘lash: <script> tegi.\r\nSintaksis va Asosiy Konsepsiyalar:\r\n\r\nO‘zgaruvchilar va Ma'lumot Turlari: let, const, raqamlar, satrlar, massivlar, ob’ektlar.\r\nOperatorlar va Ifodalar: matematik, mantiqiy, taqqoslash operatorlari.\r\nShartli Operatsiyalar: if, else if, else, switch.\r\nTsykllar: for, while, do while.\r\nFunksiyalar:\r\n\r\nFunksiya e’lon qilish: oddiy funksiyalar, anonim funksiyalar, arrow funksiyalar.\r\nFunksional programmalar: callbacklar, higher-order functions.\r\nDOM (Document Object Model) bilan Ishlash:\r\n\r\nDOM nima? HTML tarkibini JavaScript orqali o‘zgartirish.\r\nElementlarni tanlash: getElementById, querySelector, va boshqalar.\r\nHodisalarni boshqarish: eventlar, hodisalar bilan ishlash (addEventListener).\r\nAsinxron JavaScript:\r\n\r\nTimerlar: setTimeout, setInterval.\r\nCallbacks: asinxron jarayonlarni boshqarish.\r\nPromises: asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: asinxron kodni soddalashtirish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson10.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==4)
                    },
                    #endregion

                    // course 8 image
                    #region
                    new LessonModel()
                    {
                         name="1. HTML (HyperText Markup Language)\r\nHTML veb-sahifaning tuzilishini yaratish uchun ishlatiladi.",
                         description="Kirish va Asoslar:\r\n\r\nHTML nima va nima uchun kerak?\r\nHTML fayl tuzilishi (doctype, html, head, body teglar).\r\nElementlar va Teglar:\r\n\r\nAsosiy teglar: <!DOCTYPE html>, <html>, <head>, <body>, <title>, <h1>-<h6>, <p>, <a>, <img>, <ul>, <ol>, <li>, <div>, <span>, va hokazo.\r\nFormalar va kiritish elementlari: <form>, <input>, <textarea>, <button>, <select>, <option>.\r\nMatnni Formatlash:\r\n\r\nMatn teglar: <strong>, <em>, <br>, <hr>, <blockquote>, <code>.\r\nMultimedia Elementlar:\r\n\r\nRasmlar: <img>.\r\nVideo va audio: <video>, <audio>.\r\nSemantik HTML:\r\n\r\nSemantik teglar: <header>, <nav>, <section>, <article>, <footer>.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson1.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==8)
                    },
                    new LessonModel()
                    {
                         name="2. CSS (Cascading Style Sheets)\r\nCSS veb-sahifalarning ko‘rinishini va tuzilishini boshqarish uchun ishlatiladi.",
                         description="\r\nHTML, CSS va JavaScript kurslari veb-dasturlashning asosiy texnologiyalarini o‘rganish uchun muhimdir. Bu kurslar veb-sahifalar yaratish va ularni dinamik va interaktiv qilish imkonini beradi. Quyida HTML, CSS va JavaScript kurslarining umumiy mazmuni haqida ma'lumot keltirilgan.\r\n\r\nKursning Tuzilishi\r\n1. HTML (HyperText Markup Language)\r\nHTML veb-sahifaning tuzilishini yaratish uchun ishlatiladi.\r\n\r\nMavzular:\r\nKirish va Asoslar:\r\n\r\nHTML nima va nima uchun kerak?\r\nHTML fayl tuzilishi (doctype, html, head, body teglar).\r\nElementlar va Teglar:\r\n\r\nAsosiy teglar: <!DOCTYPE html>, <html>, <head>, <body>, <title>, <h1>-<h6>, <p>, <a>, <img>, <ul>, <ol>, <li>, <div>, <span>, va hokazo.\r\nFormalar va kiritish elementlari: <form>, <input>, <textarea>, <button>, <select>, <option>.\r\nMatnni Formatlash:\r\n\r\nMatn teglar: <strong>, <em>, <br>, <hr>, <blockquote>, <code>.\r\nMultimedia Elementlar:\r\n\r\nRasmlar: <img>.\r\nVideo va audio: <video>, <audio>.\r\nSemantik HTML:\r\n\r\nSemantik teglar: <header>, <nav>, <section>, <article>, <footer>.\r\n2. CSS (Cascading Style Sheets)\r\nCSS veb-sahifalarning ko‘rinishini va tuzilishini boshqarish uchun ishlatiladi.\r\n\r\nMavzular:\r\nKirish va Asoslar:\r\n\r\nCSS nima va nima uchun kerak?\r\nCSS fayllarni HTML bilan bog‘lash: <style> teglar va <link> elementi.\r\nSintaksis va Selektorlar:\r\n\r\nCSS sintaksisi: selektor, property, value.\r\nAsosiy selektorlar: element, class, id, attribute selektorlar.\r\nRanglar va Fonlar:\r\n\r\nRanglar: rang nomlari, HEX, RGB, RGBA, HSL.\r\nFonlar: background-color, background-image, background-repeat, background-position, background-size.\r\nMatnni Stilizatsiya qilish:\r\n\r\nMatn stilizatsiyasi: color, font-family, font-size, font-weight, line-height, text-align.\r\nLayout va Positioning:\r\n\r\nBox model: margin, border, padding, content.\r\nPositioning: static, relative, absolute, fixed, sticky.\r\nDisplay: block, inline, inline-block, none.\r\nFlexbox va Grid layoutlari.\r\nResponsive Design:\r\n\r\nMedia queries.\r\nResponsive dizayn prinsiplari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson2.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==8)
                    },
                    new LessonModel()
                    {
                         name="3. JavaScript\r\nJavaScript veb-sahifalarga interaktivlik qo‘shish uchun ishlatiladi.",
                         description="Kirish va Asoslar:\r\n\r\nJavaScript nima va nima uchun kerak?\r\nJavaScriptni HTML bilan bog‘lash: <script> tegi.\r\nSintaksis va Asosiy Konsepsiyalar:\r\n\r\nO‘zgaruvchilar va Ma'lumot Turlari: let, const, raqamlar, satrlar, massivlar, ob’ektlar.\r\nOperatorlar va Ifodalar: matematik, mantiqiy, taqqoslash operatorlari.\r\nShartli Operatsiyalar: if, else if, else, switch.\r\nTsykllar: for, while, do while.\r\nFunksiyalar:\r\n\r\nFunksiya e’lon qilish: oddiy funksiyalar, anonim funksiyalar, arrow funksiyalar.\r\nFunksional programmalar: callbacklar, higher-order functions.\r\nDOM (Document Object Model) bilan Ishlash:\r\n\r\nDOM nima? HTML tarkibini JavaScript orqali o‘zgartirish.\r\nElementlarni tanlash: getElementById, querySelector, va boshqalar.\r\nHodisalarni boshqarish: eventlar, hodisalar bilan ishlash (addEventListener).\r\nAsinxron JavaScript:\r\n\r\nTimerlar: setTimeout, setInterval.\r\nCallbacks: asinxron jarayonlarni boshqarish.\r\nPromises: asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: asinxron kodni soddalashtirish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson3.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==8)
                    },
                    #endregion

                    // course 10 iamge
                    #region
                    new LessonModel()
                    {
                         name="1. HTML (HyperText Markup Language)\r\nHTML veb-sahifaning tuzilishini yaratish uchun ishlatiladi.",
                         description="Kirish va Asoslar:\r\n\r\nHTML nima va nima uchun kerak?\r\nHTML fayl tuzilishi (doctype, html, head, body teglar).\r\nElementlar va Teglar:\r\n\r\nAsosiy teglar: <!DOCTYPE html>, <html>, <head>, <body>, <title>, <h1>-<h6>, <p>, <a>, <img>, <ul>, <ol>, <li>, <div>, <span>, va hokazo.\r\nFormalar va kiritish elementlari: <form>, <input>, <textarea>, <button>, <select>, <option>.\r\nMatnni Formatlash:\r\n\r\nMatn teglar: <strong>, <em>, <br>, <hr>, <blockquote>, <code>.\r\nMultimedia Elementlar:\r\n\r\nRasmlar: <img>.\r\nVideo va audio: <video>, <audio>.\r\nSemantik HTML:\r\n\r\nSemantik teglar: <header>, <nav>, <section>, <article>, <footer>.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson4.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==10)
                    },
                    new LessonModel()
                    {
                         name="2. CSS (Cascading Style Sheets)\r\nCSS veb-sahifalarning ko‘rinishini va tuzilishini boshqarish uchun ishlatiladi.",
                         description="\r\nHTML, CSS va JavaScript kurslari veb-dasturlashning asosiy texnologiyalarini o‘rganish uchun muhimdir. Bu kurslar veb-sahifalar yaratish va ularni dinamik va interaktiv qilish imkonini beradi. Quyida HTML, CSS va JavaScript kurslarining umumiy mazmuni haqida ma'lumot keltirilgan.\r\n\r\nKursning Tuzilishi\r\n1. HTML (HyperText Markup Language)\r\nHTML veb-sahifaning tuzilishini yaratish uchun ishlatiladi.\r\n\r\nMavzular:\r\nKirish va Asoslar:\r\n\r\nHTML nima va nima uchun kerak?\r\nHTML fayl tuzilishi (doctype, html, head, body teglar).\r\nElementlar va Teglar:\r\n\r\nAsosiy teglar: <!DOCTYPE html>, <html>, <head>, <body>, <title>, <h1>-<h6>, <p>, <a>, <img>, <ul>, <ol>, <li>, <div>, <span>, va hokazo.\r\nFormalar va kiritish elementlari: <form>, <input>, <textarea>, <button>, <select>, <option>.\r\nMatnni Formatlash:\r\n\r\nMatn teglar: <strong>, <em>, <br>, <hr>, <blockquote>, <code>.\r\nMultimedia Elementlar:\r\n\r\nRasmlar: <img>.\r\nVideo va audio: <video>, <audio>.\r\nSemantik HTML:\r\n\r\nSemantik teglar: <header>, <nav>, <section>, <article>, <footer>.\r\n2. CSS (Cascading Style Sheets)\r\nCSS veb-sahifalarning ko‘rinishini va tuzilishini boshqarish uchun ishlatiladi.\r\n\r\nMavzular:\r\nKirish va Asoslar:\r\n\r\nCSS nima va nima uchun kerak?\r\nCSS fayllarni HTML bilan bog‘lash: <style> teglar va <link> elementi.\r\nSintaksis va Selektorlar:\r\n\r\nCSS sintaksisi: selektor, property, value.\r\nAsosiy selektorlar: element, class, id, attribute selektorlar.\r\nRanglar va Fonlar:\r\n\r\nRanglar: rang nomlari, HEX, RGB, RGBA, HSL.\r\nFonlar: background-color, background-image, background-repeat, background-position, background-size.\r\nMatnni Stilizatsiya qilish:\r\n\r\nMatn stilizatsiyasi: color, font-family, font-size, font-weight, line-height, text-align.\r\nLayout va Positioning:\r\n\r\nBox model: margin, border, padding, content.\r\nPositioning: static, relative, absolute, fixed, sticky.\r\nDisplay: block, inline, inline-block, none.\r\nFlexbox va Grid layoutlari.\r\nResponsive Design:\r\n\r\nMedia queries.\r\nResponsive dizayn prinsiplari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson5.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==10)
                    },
                    new LessonModel()
                    {
                         name="3. JavaScript\r\nJavaScript veb-sahifalarga interaktivlik qo‘shish uchun ishlatiladi.",
                         description="Kirish va Asoslar:\r\n\r\nJavaScript nima va nima uchun kerak?\r\nJavaScriptni HTML bilan bog‘lash: <script> tegi.\r\nSintaksis va Asosiy Konsepsiyalar:\r\n\r\nO‘zgaruvchilar va Ma'lumot Turlari: let, const, raqamlar, satrlar, massivlar, ob’ektlar.\r\nOperatorlar va Ifodalar: matematik, mantiqiy, taqqoslash operatorlari.\r\nShartli Operatsiyalar: if, else if, else, switch.\r\nTsykllar: for, while, do while.\r\nFunksiyalar:\r\n\r\nFunksiya e’lon qilish: oddiy funksiyalar, anonim funksiyalar, arrow funksiyalar.\r\nFunksional programmalar: callbacklar, higher-order functions.\r\nDOM (Document Object Model) bilan Ishlash:\r\n\r\nDOM nima? HTML tarkibini JavaScript orqali o‘zgartirish.\r\nElementlarni tanlash: getElementById, querySelector, va boshqalar.\r\nHodisalarni boshqarish: eventlar, hodisalar bilan ishlash (addEventListener).\r\nAsinxron JavaScript:\r\n\r\nTimerlar: setTimeout, setInterval.\r\nCallbacks: asinxron jarayonlarni boshqarish.\r\nPromises: asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: asinxron kodni soddalashtirish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson6.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==10)
                    },
                    #endregion


                    // course 2 image
                    #region
                    new LessonModel()
                    {
                         name="Kirish va Asoslar",
                         description="JavaScript nima?: Tarixi va qo‘llanilishi.\r\nMuhitni sozlash: Brauzerlar, kod muharrirlari (VS Code, Sublime Text).\r\nHello, World!: Birinchi JavaScript dasturini yozish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson7.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                    {
                         name="Asosiy Dasturlash Konsepsiyalari",
                         description="O‘zgaruvchilar va Ma'lumot Turlari: let, const, raqamlar, satrlar, massivlar, ob’ektlar.\r\nOperatorlar va Ifodalar: Matematik, mantiqiy va taqqoslash operatorlari.\r\nShartli Operatsiyalar: if, else if, else, switch bayonotlari.\r\nTsykllar: for, while, do while tsikllari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson8.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                     {
                          name="Funksiyalar",
                          description="Funksiya E’lon qilish: Oddiy funksiyalar, anonim funksiyalar, o‘zgaruvchan funksiyalar.\r\nFunksional Programmalar: Callbacklar, arrow funksiyalar (=>).",
                          LessonPhotoPath="https://localhost:7030/images/lessons/lesson9.jpg",
                          VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                          Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                     },
                      new LessonModel()
                    {
                         name="DOM (Document Object Model) bilan Ishlash",
                         description="DOM Nima?: HTML tarkibini JavaScript orqali o‘zgartirish.\r\nElementlarni Tanlash: getElementById, querySelector, va boshqalar.\r\nHodisalarni Boshqarish: Eventlar, hodisalar bilan ishlash (addEventListener).\r\n",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson10.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                    {
                         name="Asinxron JavaScript",
                         description="Timerlar: setTimeout, setInterval.\r\nCallbacks: Asinxron jarayonlarni boshqarish.\r\nPromises: Asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: Asinxron kodni soddalashtirish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson1.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                     {
                          name="JavaScript Kutubxona va Ramkalari",
                          description="jQuery: JavaScriptni yengillashtiruvchi kutubxona.\r\nReact.js: Foydalanuvchi interfeysi yaratish uchun kutubxona.\r\nVue.js va Angular: Kompleks ilovalar uchun boshqa mashhur ramkalar.",
                          LessonPhotoPath="https://localhost:7030/images/lessons/lesson2.jpg",
                          VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                          Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                     },
                      new LessonModel()
                    {
                         name="Server Tomoni JavaScript",
                         description="Node.js: Server tomonida JavaScriptni ishlatish.\r\nExpress.js: Node.js uchun ramka.\r\nAPIs va RESTful Servislar: Backend bilan o‘zaro aloqa.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson3.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                     {
                          name="Amaliy Loyihalar",
                          description="Kichik Loyihalar: Oddiy veb-sahifalar va o‘yinlar.\r\nKatta Loyihalar: Kompleks veb-ilovalar va foydalanuvchi interfeyslari.",
                          LessonPhotoPath="https://localhost:7030/images/lessons/lesson4.jpg",
                          VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                          Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                     },
                      new LessonModel()
                    {
                         name="TypeScript Kirish va Asoslar",
                         description="TypeScript nima?: Tarixi, maqsadi, imkoniyatlari.\r\nMuhitni sozlash: TypeScript kompilyatori, kod muharrirlari.\r\nBirinci dastur: \"Hello, World!\" dasturi TypeScriptda.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson5.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                    {
                         name=" Asosiy Konsepsiyalar",
                         description="Tiplar: Asosiy va murakkab turlar (string, number, boolean, array, tuple, enum).\r\nInterfeyslar va Turlar: TypeScriptning asosiy interfeyslari va ulardan foydalanish.\r\nKlasslar va Ob'ektlar: Ob'ektga yo‘naltirilgan dasturlash (OOP), klasslar, meros olish, interfeyslar.\r\nFunksiyalar: Tiplangan funksiyalar, funksiya turlari, arrow funksiyalar.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson6.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                     {
                          name=" Advanced TypeScript",
                          description="Generics: Generik turlar bilan ishlash.\r\nDekoratorlar: Klass va usul dekoratorlari.\r\nModullar va Namespaces: TypeScriptda modullarni yaratish va ulardan foydalanish.",
                          LessonPhotoPath="https://localhost:7030/images/lessons/lesson7.jpg",
                          VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                          Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                     },
                      new LessonModel()
                    {
                         name=". Asinxron Dasturlash",
                         description="Promises: Asinxron operatsiyalarni yengillashtirish.\r\nAsync/Await: Asinxron kodni soddalashtirish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson8.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                    {
                         name=" TypeScript va JavaScript Bilan Integratsiya",
                         description="JavaScript Kodini Migratsiya qilish: Mavjud JavaScript loyihasini TypeScriptga o‘tkazish.\r\nJavaScript Kutubxonalari bilan Ishlash: TypeScriptda JavaScript kutubxonalarini ishlatish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson9.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                     new LessonModel()
                     {
                          name=". Amaliy Loyihalar",
                          description="Kichik Loyihalar: Oddiy TypeScript ilovalari.\r\nKatta Loyihalar: Kompleks TypeScript ilovalari va JavaScript bilan integratsiyalashgan loyihalar.",
                          LessonPhotoPath="https://localhost:7030/images/lessons/lesson10.jpg",
                          VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                          Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                     },
                    #endregion

                    // course 5 image
                    #region
                    new LessonModel()
                    {
                         name=" Kirish va Asoslar",
                         description="React.js nima?: Tarixi va maqsadi.\r\nReact muhiti: Create React App, Next.js, Vite bilan boshlash.\r\nReactning asosiy komponentlari: Funksional va klass komponentlari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson1.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                        new LessonModel()
                    {
                         name="JSX (JavaScript XML)",
                         description="JSX nima?: JSX bilan ishlash.\r\nJSX Sintaksisi: HTML va JavaScriptni birlashtirish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson2.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                          new LessonModel()
                    {
                         name=" Komponentlar",
                         description="Komponentlar yaratish: Funksional va klass komponentlari.\r\nProps va State: Komponentlar o‘rtasida ma'lumot uzatish.\r\nLifecycle metodlari: Klass komponentlarining lifecycle metodlari.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson3.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                            new LessonModel()
                    {
                         name="Hooks",
                         description="useState va useEffect: Funksional komponentlarda davlat va lifecycle boshqaruvi.\r\nBoshqa asosiy hooks: useContext, useReducer, useMemo, useCallback.\r\nCustom hooks: Maxsus hooks yaratish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson4.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                              new LessonModel()
                    {
                         name="Router",
                         description="React Router: Navigatsiya va sahifalar orasida o‘tish.\r\nDynamic routing: Dinamik marshrutlash.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson5.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                                new LessonModel()
                    {
                         name=" State Management",
                         description="Context API: Kontekst orqali davlat boshqaruvi.\r\nRedux: State management uchun kutubxona.\r\nRedux Toolkit: Reduxni soddalashtirish uchun toolkit.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson6.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                                  new LessonModel()
                    {
                         name=" Asinxron Operatsiyalar",
                         description="Fetch API: Ma'lumotlarni serverdan olish.\r\nAxios: Ma'lumotlarni olish va yuborish uchun kutubxona.\r\nReact Query: Server state boshqaruvi.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson7.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                                    new LessonModel()
                    {
                         name="Styling",
                         description="Fetch API: Ma'lumotlarni serverdan olish.\r\nAxios: Ma'lumotlarni olish va yuborish uchun kutubxona.\r\nReact Query: Server state boshqaruvi.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson8.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                                      new LessonModel()
                    {
                         name="Testing",
                         description="Jest: React ilovalarini test qilish.\r\nReact Testing Library: Komponentlarni test qilish uchun kutubxona.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson10.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                                        new LessonModel()
                    {
                         name="Amaliy Loyihalar",
                         description="Amaliy loyihalar orqali nazariy bilimlarni mustahkamlash va real loyihalarda qo‘llash imkonini beradi.\r\n\r\nOddiy Veb-sahifalar: HTML, CSS va JavaScriptdan foydalanib oddiy veb-sahifalar yaratish.\r\nMurakkab Ilovalar: React va boshqa kutubxonalardan foydalanib kompleks va interaktiv ilovalar yaratish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson1.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                    #endregion

                    //course 6
                    #region
                    new LessonModel()
                    {
                         name=" Kirish va Asoslar",
                         description="Vue.js nima?: Tarixi va maqsadi.\r\nVue muhiti: Vue CLI bilan boshlash.\r\nVue komponentlari: Yagona fayl komponentlari (Single File Components).",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson2.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                        new LessonModel()
                    {
                         name="Vue Syntax va Template'lar\r\n",
                         description="Templates: HTML bilan ishlash.\r\nDirektivlar: v-bind, v-model, v-if, v-for, va boshqalar.\r\nEventlar: v-on bilan hodisalarni boshqarish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson3.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                          new LessonModel()
                    {
                         name="Komponentlar",
                         description="Komponentlar yaratish: Yagona fayl komponentlari.\r\nProps va State: Komponentlar o‘rtasida ma'lumot uzatish.\r\nEmit va Custom Events: Maxsus hodisalarni uzatish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson4.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                            new LessonModel()
                    {
                         name=" Reaktivlik",
                         description="Reaktiv ma'lumotlar: Vue reaktivlik tizimi.\r\nComputed properties: Hisoblangan xususiyatlar.\r\nWatchers: Kuzatuvchilar bilan ma'lumotlar o‘zgarishini kuzatish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson5.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                              new LessonModel()
                    {
                         name="Router",
                         description="Vue Router: Navigatsiya va sahifalar orasida o‘tish.\r\nDynamic routing: Dinamik marshrutlash.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson6.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                                new LessonModel()
                    {
                         name="State Management",
                         description="Vuex: Vue ilovalari uchun davlat boshqaruvi.\r\nModullar: Vuex modullari bilan ishlash.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson7.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                                  new LessonModel()
                    {
                         name="Asinxron Operatsiyalar",
                         description="Axios: Ma'lumotlarni olish va yuborish uchun kutubxona.\r\nVue Resource: Asinxron operatsiyalarni boshqarish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson8.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                                    new LessonModel()
                    {
                         name=" Styling",
                         description="CSS-in-JS: Scoped CSS bilan stilizatsiya qilish.\r\nSass/SCSS: SASS preprocessor bilan ishlash.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson9.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                                      new LessonModel()
                    {
                         name=" Testing",
                         description="Test: Vue ilovalarini test qilish.\r\nVue Test Utils: Komponentlarni test qilish uchun kutubxona.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson10.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                                        new LessonModel()
                    {
                         name="Amaliy Loyihalar",
                         description="Amaliy loyihalar orqali nazariy bilimlarni mustahkamlash va real loyihalarda qo‘llash imkonini beradi.\r\n\r\nOddiy Veb-sahifalar: HTML, CSS va JavaScriptdan foydalanib oddiy veb-sahifalar yaratish.\r\nMurakkab Ilovalar: Vue va boshqa kutubxonalardan foydalanib kompleks va interaktiv ilovalar yaratish.",
                         LessonPhotoPath="https://localhost:7030/images/lessons/lesson1.jpg",
                         VideoPath="https://localhost:7030/images/LessonVideoPath/lesson.mp4",
                         Courses=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                    #endregion
                };
                await db.lessons.AddRangeAsync(list);
                await db.SaveChangesAsync();    
            }
            if (!db.answers.Any())
            {
                List<AnswerModel> list = new List<AnswerModel>()
                {
                    #region
                    // course 1
                    new AnswerModel()
                    {
                        Title="JavaScript nima?",
                        Body=" JavaScript – bu veb-sahifalar uchun interaktivlik qo‘shish uchun ishlatiladigan dasturlash tili. Bu til dastlab faqat veb-brauzerlar uchun ishlab chiqilgan, ammo hozirda server tomonida ham (masalan, Node.js yordamida) ishlatiladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                    new AnswerModel()
                    {
                        Title="JavaScript qanday ma'lumot turlariga ega?\r\n\r\n",
                        Body="JavaScriptda quyidagi asosiy ma'lumot turlari mavjud:\r\nNumber (raqamlar)\r\nString (satrlar)\r\nBoolean (mantiqiy qiymatlar: true yoki false)\r\nUndefined\r\nNull\r\nObject (ob’ektlar)\r\nSymbol (simvollar, ES6’dan boshlab)\r\nBigInt (katta raqamlar, ES2020’dan boshlab)",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                     new AnswerModel()
                    {
                        Title="var, let, va const o‘zgaruvchilari orasidagi farqlar nima?\r\n\r\n",
                        Body="var: Funksiya blokida ko‘rinish doirasi (function scope) mavjud. O‘zgaruvchini qayta e'lon qilishga ruxsat beradi.\r\nlet: Blok doirasida ko‘rinish (block scope) mavjud. O‘zgaruvchini qayta e'lon qilishga ruxsat bermaydi.\r\nconst: Blok doirasida ko‘rinish (block scope) mavjud. O‘zgaruvchini qayta e'lon qilishga va qayta o‘zgartirishga ruxsat bermaydi (lekin ob’ektlarning xossalarini o‘zgartirish mumkin).",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                     // course 7
                      new AnswerModel()
                    {
                        Title="JavaScriptda funksiyalar qanday e'lon qilinadi?",
                        Body="const myFunction = function() {\r\n  console.log(\"Hello World\");\r\n}; function myFunction() {\r\n  console.log(\"Hello World\");\r\n}",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                       new AnswerModel()
                    {
                        Title="== va === operatorlari orasidagi farq nima?",
                        Body="== (tenglik operatori): Ma'lumot turlarini avtomatik tarzda kasting qilish (type coercion) va keyin qiymatlarni solishtiradi. Masalan, \"5\" == 5 true qaytaradi.\r\n=== (qat'iy tenglik operatori): Ma'lumot turlarini solishtirmaydi, faqat qiymatlarni solishtiradi. Masalan, \"5\" === 5 false qaytaradi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                        new AnswerModel()
                    {
                        Title="JavaScriptda null va undefined orasidagi farq nima?",
                        Body="null: Qo‘lda qiymat sifatida hech nima (bo‘sh qiymat) o‘rnatilgan.\r\nundefined: O‘zgaruvchi qiymatiga hech nima o‘rnatilmagan yoki mavjud bo‘lmagan xossaga kirishga urinishda qaytariladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==7)
                    },
                        // course 9
                         new AnswerModel()
                    {
                        Title="JavaScriptda yopilishlar (Closures) nima?",
                        Body="Yopilish (closure) bu funktsiya va uning leksik doirasi (lexical environment) ning kombinatsiyasidir. Yopilishlar tashqi funktsiyaning o‘zgaruvchilariga kirish imkonini beradi, hatto tashqi funktsiya bajarilishi tugagan bo‘lsa ham.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                          new AnswerModel()
                    {
                        Title="JavaScriptda Promises nima va qanday ishlaydi?",
                        Body="Promise bu asinxron operatsiyalarni bajarishni osonlashtiradigan obyekt bo‘lib, operatsiya muvaffaqiyatli bajarilgan yoki muvaffaqiyatsizlikka uchraganligini bildiradi. Promise uchta holatdan birida bo‘lishi mumkin: pending (kutish), fulfilled (bajarilgan), yoki rejected (rad etilgan).",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                           new AnswerModel()
                    {
                        Title="JavaScriptda this kalit so‘zi nima?",
                        Body="this kalit so‘zi hozirgi kontekstga ishora qiladi. U funktsiya qanday chaqirilganiga qarab turli xil qiymatlarga ega bo‘lishi mumkin.\r\nGlobal kontekstda (brauzerda): this - global obyekt (window).\r\nMetodda: this - metodni chaqirgan obyekt.\r\nYopilishlarda (closures): this - tashqi funksiya konteksti.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==9)
                    },
                           // course 3 
                            new AnswerModel()
                    {
                        Title="Frontend va backend dasturlash o'rtasidagi asosiy farq nima?",
                        Body="Frontend dasturlash foydalanuvchilar bilan bevosita o'zaro aloqada bo'ladigan veb-sahifalar va ilovalar yaratishga qaratilgan. Bu HTML, CSS va JavaScript kabi texnologiyalarni o'z ichiga oladi. Backend dasturlash esa server tomonidagi jarayonlar, ma'lumotlar bazasi bilan ishlash va server-logika yaratishga qaratilgan bo'lib, bu uchun PHP, Python, Ruby va Node.js kabi texnologiyalar ishlatiladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==3)
                    },
                             new AnswerModel()
                    {
                        Title="HTML nima va nima uchun ishlatiladi?",
                        Body="HTML (HyperText Markup Language) veb-sahifalarning tuzilishini yaratish uchun ishlatiladi. U turli elementlar va teglardan iborat bo'lib, sahifaning mazmuni va tarkibini belgilashga yordam beradi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==3)
                    },
                              new AnswerModel()
                    {
                        Title="CSS nima va nima uchun ishlatiladi?",
                        Body="CSS (Cascading Style Sheets) veb-sahifalarning ko'rinishini va stilini belgilash uchun ishlatiladi. U HTML elementlarini uslublashga yordam beradi, shu jumladan ranglar, shriftlar, maket va tartibni boshqaradi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==3)
                    },
                              // 4
                               new AnswerModel()
                    {
                        Title="Responsive dizayn nima va qanday amalga oshiriladi?",
                        Body="Responsive dizayn turli ekran o'lchamlariga mos keladigan veb-sahifalarni yaratishga qaratilgan. Bu CSS media queries, foizlar va flexible layout (flexbox va grid) yordamida amalga oshiriladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==4)
                    },
                                 new AnswerModel()
                    {
                        Title="CSS Flexbox va Grid tizimlari o'rtasidagi farq nima?",
                        Body="Flexbox bir yo'nalishda (qator yoki ustun) moslashuvchan maketlar yaratish uchun ishlatiladi, Grid esa ikkita yo'nalishda (qator va ustun) moslashuvchan maketlar yaratishga imkon beradi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==4)
                    },
                                 // 8
                                  new AnswerModel()
                    {
                        Title="Single Page Application (SPA) nima va uning afzalliklari nimada?",
                        Body="SPA (Single Page Application) — bu foydalanuvchi sahifani yangilamasdan turib yangi tarkibni yuklaydigan veb-ilova. Afzalliklari: tezkor yuklanish, yaxshiroq foydalanuvchi tajribasi va server bilan minimal o'zaro aloqa.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==8)
                    },
                                   new AnswerModel()
                    {
                        Title="AJAX nima va u qanday ishlaydi?",
                        Body="AJAX (Asynchronous JavaScript and XML) sahifani qayta yuklamasdan turib server bilan ma'lumot almashish imkonini beradi. Bu XMLHttpRequest yoki Fetch API yordamida amalga oshiriladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==8)
                    },
                                     new AnswerModel()
                    {
                        Title="Frontend ramkalar (frameworks) va kutubxonalar (libraries) o'rtasidagi farq nima?",
                        Body="avob: Ramkalar dastur tuzilmasini boshqaradi va aniq me'yorlarga rioya qilishni talab qiladi (masalan, Angular, Vue.js). Kutubxonalar esa muayyan vazifalar uchun kod taqdim etadi va dasturchi uni qachon va qanday ishlatishni o'zi hal qiladi (masalan, React.js, jQuery).",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==8)
                    },
                                     //10
                             new AnswerModel()
                    {
                        Title="Component-based arxitektura nima va uning afzalliklari?",
                        Body="Component-based arxitektura dasturiy ta'minotni mustaqil, qayta foydalanish mumkin bo'lgan komponentlarga ajratadi. Afzalliklari: qayta foydalanish imkoniyati, modul tuzilma, sinov (testing) qulayligi va kodni boshqarish osonligi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==10)
                    },
                              new AnswerModel()
                    {
                        Title="React.js va Vue.js orasidagi asosiy farqlar nima?",
                        Body="React.js komponentlar kutubxonasi bo'lib, faqat View qismiga qaratilgan, va unda JSX ishlatiladi. Vue.js esa to'liq freymvork bo'lib, uning sintaksisi HTML-ga o'xshash va ishlatish uchun osonroq. Vue.js reaktivlikni asosiy tizimiga o'rnatilgan holda taqdim etadi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==10)
                    },
                               new AnswerModel()
                    {
                        Title="CSS preprocessors nima va ular qanday ishlatiladi?",
                        Body="CSS preprocessors (masalan, Sass, LESS) CSS yozishni soddalashtirish uchun ishlatiladi. Ular o'zgaruvchilar, aralashmalar (mixins), nested rules va boshqa xususiyatlarni qo'shib beradi. Preprotsessor kodini oddiy CSS ga kompilyatsiya qilish kerak bo'ladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==10)
                    },
                                new AnswerModel()
                    {
                        Title="",
                        Body="",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==1)
                    },
                                // 2
                                 new AnswerModel()
                    {
                        Title="TypeScript nima va u nimaga xizmat qiladi?",
                        Body="TypeScript bu Microsoft tomonidan yaratilgan JavaScript ning superto‘plami bo‘lib, unga statik tiplash va boshqa qo‘shimcha imkoniyatlar qo‘shadi. TypeScript kompilyatsiya qilingach, oddiy JavaScript kodinga aylanadi. U kodning ishonchliligini oshiradi va rivojlantirish jarayonida xatolarni aniqlashni osonlashtiradi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                                  new AnswerModel()
                    {
                        Title="TypeScript qanday fayl kengaytmasiga ega?",
                        Body="TypeScript fayllari .ts kengaytmasiga ega. Agar fayl JSX (React) kodini o‘z ichiga olsa, .tsx kengaytmasidan foydalaniladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                                   new AnswerModel()
                    {
                        Title="TypeScriptda type va interface orasidagi farq nima?",
                        Body="type va interface ikkalasi ham obyekt turlarini belgilash uchun ishlatiladi, lekin ularning ba'zi farqlari mavjud:\r\ninterface: Ko‘proq sinflar va obyektlar tuzilishini belgilash uchun ishlatiladi va kengaytirilishi (extends) mumkin.\r\ntype: Har qanday turlarni belgilash uchun ishlatiladi, shu jumladan primitivlar, birlashmalar va typlarni o‘zgartirish mumkin emas.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==2)
                    },
                                   // 5
                                     new AnswerModel()
                    {
                        Title="React.js nima va nima uchun ishlatiladi?",
                        Body="React.js – bu Facebook tomonidan ishlab chiqilgan va dastlab veb-ilovalar uchun foydalanuvchi interfeyslarini yaratish uchun mo‘ljallangan JavaScript kutubxonasi. U komponentga asoslangan arxitektura va virtual DOM kabi imkoniyatlarga ega bo‘lib, ilovalarning tezkor va samarali ishlashini ta’minlaydi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                             new AnswerModel()
                    {
                        Title="React komponenti nima?",
                        Body="React komponenti foydalanuvchi interfeysining mustaqil, qayta foydalaniladigan qismini ifodalaydi. Ular JavaScript funksiyalari yoki sinflari sifatida e'lon qilinishi mumkin va o‘z xossalari (props) va holati (state) bilan boshqariladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                              new AnswerModel()
                    {
                        Title="Props va State o'rtasidagi farq nima?",
                        Body="Props (properties) komponentga tashqaridan uzatiladigan ma'lumotlar bo‘lib, ularni o‘zgartirish mumkin emas. State esa komponent ichida boshqariladigan va o‘zgarishi mumkin bo‘lgan ma'lumotlar.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                               new AnswerModel()
                    {
                        Title="React-da funksional va klass komponentlari o'rtasidagi farq nima?",
                        Body="Funksional komponentlar oddiy JavaScript funksiyalaridan iborat bo‘lib, ular props qabul qiladi va JSX ni qaytaradi. Klass komponentlari esa ES6 sinflaridan foydalanadi va qo‘shimcha ravishda hayotiy sikl metodlariga ega bo‘lishi mumkin.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                                new AnswerModel()
                    {
                        Title="React-da hayotiy sikl (lifecycle) metodlari nima?",
                        Body="Hayotiy sikl metodlari React komponentining turli bosqichlarida chaqiriladigan metodlar bo‘lib, komponentni yaratish, yangilash va yo‘q qilish jarayonlarini boshqarishga yordam beradi. Klass komponentlarida mavjud bo‘lgan ba'zi hayotiy sikl metodlari:\r\ncomponentDidMount()\r\ncomponentDidUpdate(prevProps, prevState)\r\ncomponentWillUnmount()",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==5)
                    },
                                // 6
                                 new AnswerModel()
                    {
                        Title="Vue.js nima va nima uchun ishlatiladi?",
                        Body="Vue.js bu foydalanuvchi interfeyslarini yaratish uchun ishlatiladigan JavaScript frameworki. U reaktiv va komponentga asoslangan arxitekturaga ega bo‘lib, oddiy va murakkab ilovalarni ishlab chiqish uchun qulaydir.\r\n",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                                  new AnswerModel()
                    {
                        Title="Vue komponenti nima?",
                        Body="Vue komponenti foydalanuvchi interfeysining qayta foydalaniladigan, mustaqil qismi bo‘lib, ular Vue komponent sinfi sifatida e'lon qilinadi. Har bir komponent o‘ziga xos HTML, CSS va JavaScript kodini o‘z ichiga oladi.",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    },
                                   new AnswerModel()
                    {
                        Title="Props va data o'rtasidagi farq nima?",
                        Body="Props (properties) komponentga tashqaridan uzatiladigan ma'lumotlar bo‘lib, o‘zgartirilishi mumkin emas. Data esa komponent ichida boshqariladigan va o‘zgarishi mumkin bo‘lgan holatdir",
                        Course=await db.courses.FirstOrDefaultAsync(x=>x.id==6)
                    }
                    #endregion
                };

                db.answers.AddRangeAsync(list);
                db.SaveChangesAsync();
            }
            if (!db.news.Any())
            {
                List<NewsModel> list = new List<NewsModel>()
                {
                    new NewsModel()
                    {
                        Title=".NET 9 yangiliklar va imkoniyatlari",
                        About=".NET 9-ning asosiy yangiliklari va afzalliklarini o'z ichiga olgan maqola keltirilgan:\r\n\r\n---\r\n\r\n### .NET 9: Yangi Talqin Va Imkoniyatlar\r\n\r\nMicrosoft'ning eng so'nggi yirik dasturiy ta'minot platformasi bo'lgan .NET 9 chiqdi va dasturchilar uchun ko'plab yangi imkoniyatlar va yaxshilanishlarni taqdim etmoqda. Quyida .NET 9-ning asosiy yangiliklari va uning dasturchilarga nimalar olib kelishi haqida batafsil ma'lumotlar keltirilgan.\r\n\r\n#### Ishlash Samarasini Oshirish\r\n\r\n.NET 9 ish faoliyatini sezilarli darajada yaxshilash uchun bir qator optimallashtirishlarni o'z ichiga oladi:\r\n- **Just-In-Time (JIT) kompilyatsiyasi** yaxshilandi, bu esa kodning tezroq bajarilishini ta'minlaydi.\r\n- **Garbage collection** va xotira boshqaruvi optimallashtirildi, bu esa xotira ishlatilishini kamaytiradi va dasturiy ta'minotning ishlash tezligini oshiradi.\r\n- **Yuqori tezlikda ishga tushirish** va kechikishlarni kamaytirish bilan dasturlar tezroq yuklanadi va ishga tushadi.\r\n\r\n#### Yangi Til Imkoniyatlari\r\n\r\n.NET 9 yangi til imkoniyatlari va yaxshilanishlarni o'z ichiga oladi:\r\n- **C# 12** qo'llab-quvvatlanadi, bu yangi til konstruktsiyalari va funksiyalarini o'z ichiga oladi.\r\n- **F# 8** yangilanishlari bilan yuqori samaradorlik va yangi funksional dasturlash imkoniyatlari taqdim etiladi.\r\n- **Visual Basic** uchun konservativ o'zgarishlar bilan yaxshilanishlar qo'shildi.\r\n\r\n#### Kross-platform Dasturlash\r\n\r\n.NET 9 kross-platform imkoniyatlariga katta e'tibor qaratmoqda, bu esa dasturchilarga Windows, Linux va macOS operatsion tizimlarida ishlaydigan dasturlar yaratishga imkon beradi:\r\n- **ARM64 va Apple Silicon (M1/M2)** arxitekturalari uchun yaxshilangan qo'llab-quvvatlash.\r\n- **Bitta ramka** ostida ishlash, .NET Core, .NET Framework va Xamarin ni birlashtirish davom ettirilmoqda.\r\n\r\n#### Blazor Yaxshilanishlari\r\n\r\nBlazor-ning yangi versiyalari quyidagi yaxshilanishlarni taqdim etadi:\r\n- **Blazor WebAssembly** ishlashini yaxshilash.\r\n- Yangi Blazor komponentlari va yaxshiroq vosita qo'llab-quvvatlash.\r\n- **Blazor Hybrid** dasturlari uchun yaxshilangan qo'llab-quvvatlash.\r\n\r\n#### Bulut-Tabiiy Va Kontenerizatsiya\r\n\r\n.NET 9 bulutli dasturlar va konteyner texnologiyalari bilan yanada yaxshiroq integratsiya qiladi:\r\n- Kubernetes va boshqa konteyner orkestratsiya platformalari bilan yaxshilangan integratsiya.\r\n- Mikroxizmatlar va bulutli dasturlar yaratish uchun yaxshilangan qo'llab-quvvatlash.\r\n- Bulutli dasturlar uchun yaxshilangan diagnostika va monitoring vositalari.\r\n\r\n#### Xavfsizlik\r\n\r\nXavfsizlik .NET 9-ning asosiy yo'nalishlaridan biridir:\r\n- Zamonaviy xavfsizlik standartlariga muvofiq yaxshilangan xavfsizlik funksiyalari.\r\n- Xavfsiz kod yozish amaliyotlarini va avtomatlashtirilgan zaifliklarni skanerlashni qo'llab-quvvatlash.\r\n\r\n#### Asboblar Va IDE Qo'llab-quvvatlashi\r\n\r\n.NET 9 yangilangan va yaxshilangan asboblar va IDE qo'llab-quvvatlashi bilan birga keladi:\r\n- Yangilangan Visual Studio yangi funksiyalar va .NET 9 qo'llab-quvvatlashi bilan.\r\n- Visual Studio Code va JetBrains Rider kabi boshqa IDElarda yaxshilangan qo'llab-quvvatlash.\r\n- Yaxshilangan nosozliklarni tuzatish va profiling vositalari.\r\n\r\n#### Kutubxonalar Va APIlar\r\n\r\n.NET 9 yangi kutubxonalar va APIlar bilan dasturchilarning unumdorligini oshirish uchun qo'shimcha imkoniyatlar taqdim etadi:\r\n- Zamonaviy ilovalar uchun yangi kutubxonalar.\r\n- Oddiy vazifalarni soddalashtirish va ishlab chiquvchilarning mahsuldorligini oshirish uchun kengaytirilgan APIlar.\r\n\r\n#### Orqaga Moslik\r\n\r\n.NET 9 oldingi versiyalar bilan orqaga moslikni ta'minlashga harakat qiladi, bu esa mavjud ilovalarni yangilash jarayonini osonlashtiradi.\r\n\r\n.NET 9 o'zidan oldingi versiyalarning mustahkam va ko'p tomonlama asosiga asoslangan holda, keng ko'lamli ilovalarni ishlab chiqish uchun kuchli muhit yaratishda davom etmoqda. Bu yangi platforma dasturchilarga ilg'or funksiyalar va yaxshilanishlar orqali yanada keng imkoniyatlar ochib beradi.\r\n\r\n---",
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1),
                        NewsPhotoPath="https://localhost:7030/images/news/news.jpg"
                    },
                    new NewsModel()
                    {
                        Title="Dasturchilar uchun foydali top 10 ta sayt va ularning imkoniyatlari",
                        About="Dasturchilar uchun foydali bo'lgan eng yaxshi veb-saytlar va ularning imkoniyatlari haqida qisqacha ma'lumot keltirilgan:\r\n\r\n### 1. [Stack Overflow](https://stackoverflow.com)\r\n- **Imkoniyatlari**: Dasturchilar uchun savol-javob platformasi bo'lib, turli dasturlash tillari va texnologiyalarga oid savollarga javob topish mumkin.\r\n- **Foydasi**: Tez-tez duch keladigan muammolarni hal qilish va tajribali dasturchilardan maslahat olish uchun juda foydali.\r\n\r\n### 2. [GitHub](https://github.com)\r\n- **Imkoniyatlari**: Kodlar uchun versiya nazorati va hamkorlik platformasi. Loyihalarni boshqarish, saqlash va kodlarni baham ko'rish imkonini beradi.\r\n- **Foydasi**: Ochiq manba loyihalarida ishtirok etish, o'zingizning loyihalaringizni saqlash va boshqalar bilan hamkorlik qilish uchun muhim vosita.\r\n\r\n### 3. [Reddit (r/programming)](https://www.reddit.com/r/programming/)\r\n- **Imkoniyatlari**: Dasturlashga oid yangiliklar, maqolalar va muhokamalar.\r\n- **Foydasi**: Eng so'nggi yangiliklar va texnologik yangiliklar haqida bilib olish, hamda tajribali dasturchilar bilan muloqot qilish.\r\n\r\n### 4. [MDN Web Docs](https://developer.mozilla.org)\r\n- **Imkoniyatlari**: Veb dasturlashga oid hujjatlar va qo'llanmalar. HTML, CSS, JavaScript va boshqa veb texnologiyalari haqida batafsil ma'lumotlar.\r\n- **Foydasi**: Veb dasturchilar uchun asosiy manba bo'lib, keng qamrovli ma'lumotlarni taqdim etadi.\r\n\r\n### 5. [HackerRank](https://www.hackerrank.com)\r\n- **Imkoniyatlari**: Kod yozish va algoritmik muammolarni hal qilish uchun mashqlar.\r\n- **Foydasi**: Kod yozish ko'nikmalarini oshirish va texnik intervyular uchun tayyorgarlik ko'rish.\r\n\r\n### 6. [LeetCode](https://leetcode.com)\r\n- **Imkoniyatlari**: Kod muammolarini hal qilish va texnik intervyular uchun tayyorlanish platformasi.\r\n- **Foydasi**: Algoritmlar va ma'lumotlar tuzilmalari bo'yicha ko'nikmalarni oshirish uchun keng qamrovli muammolar bazasi.\r\n\r\n### 7. [Coursera](https://www.coursera.org)\r\n- **Imkoniyatlari**: Turli mavzularda, shu jumladan dasturlash va kompyuter fanlari bo'yicha onlayn kurslar.\r\n- **Foydasi**: Dunyoning eng yaxshi universitetlari va kompaniyalaridan sifatli ta'lim olish imkoniyati.\r\n\r\n### 8. [edX](https://www.edx.org)\r\n- **Imkoniyatlari**: Onlayn kurslar va dasturlar, shu jumladan kompyuter fanlari va dasturlash bo'yicha kurslar.\r\n- **Foydasi**: Dunyodagi yetakchi universitetlar va muassasalar tomonidan taqdim etilgan kurslar orqali bilim olish.\r\n\r\n### 9. [FreeCodeCamp](https://www.freecodecamp.org)\r\n- **Imkoniyatlari**: Keng qamrovli va bepul dasturlash kurslari. \r\n- **Foydasi**: Boshlang'ich darajadan tortib ilg'or darajagacha bo'lgan dasturlash bilimlarini oshirish uchun ajoyib manba.\r\n\r\n### 10. [CodePen](https://codepen.io)\r\n- **Imkoniyatlari**: Veb rivojlantirish uchun onlayn kod muharriri va hamjamiyat.\r\n- **Foydasi**: Veb loyihalarni sinab ko'rish, o'rganish va boshqalar bilan o'z kodlaringizni baham ko'rish.\r\n\r\nBu saytlar dasturchilar uchun juda ko'p foydali manbalar va imkoniyatlar taqdim etadi. Ular orqali siz o'z bilim va ko'nikmalaringizni oshirishingiz, muammolarni hal qilishingiz va texnologik yangiliklardan xabardor bo'lib turishingiz mumkin.",
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1),
                        NewsPhotoPath="https://localhost:7030/images/news/news1.jpg"
                    },
                    new NewsModel()
                    {
                        Title="JavaScript imkoniyatlari va tarixi",
                        About="JavaScript dasturlash tilining tarixi va imkoniyatlari juda boy va murakkab. Bu til dastlab faqat oddiy vazifalarni bajarish uchun mo'ljallangan bo'lsa-da, hozirgi kunda u veb rivojlantirishning ajralmas qismiga aylangan. Quyida JavaScript'ning tarixi va uning imkoniyatlari haqida batafsil ma'lumot keltirilgan:\r\n\r\n### JavaScript Tarixi\r\n\r\n#### 1995: JavaScript'ning Yaratilishi\r\n- **Yaratilish**: JavaScript dastlab Netscape Communications korporatsiyasida Brendan Eich tomonidan yaratildi va dastlab \"Mocha\" deb nomlangan.\r\n- **Nomi**: Bir necha nom o'zgartirishlaridan so'ng, til \"JavaScript\" deb nomlandi, bu esa o'sha paytdagi mashhur Java dasturlash tiliga bog'liq bo'lib tuyuldi.\r\n- **Maqsadi**: JavaScript dastlab veb-sahifalarda oddiy o'zaro ta'sirlarni ta'minlash uchun mo'ljallangan edi.\r\n\r\n#### 1996: ECMA Standartlari\r\n- **Standartlashuv**: 1996-yilda Netscape JavaScript'ni ECMA International'ga topshirdi, natijada ECMA-262 standarti paydo bo'ldi, bu standart tilning rasmiy nomi \"ECMAScript\" deb ataladi.\r\n\r\n#### 1997-1999: ES1, ES2 va ES3\r\n- **Birlik**: ECMAScript 1 (ES1) 1997-yilda chiqarildi.\r\n- **Yangi versiyalar**: ES2 (1998) va ES3 (1999) tilda yangi imkoniyatlar qo'shdi va mavjud funksiyalarni yaxshiladi.\r\n\r\n#### 2005: AJAX\r\n- **AJAX**: Asynchronous JavaScript and XML (AJAX) texnologiyasi joriy qilindi, bu veb-sahifalarning server bilan asinxron muloqot qilishiga imkon berdi va foydalanuvchi tajribasini sezilarli darajada yaxshiladi.\r\n\r\n#### 2009: ES5\r\n- **Yangi imkoniyatlar**: ECMAScript 5 (ES5) ko'plab yangi imkoniyatlar qo'shdi, jumladan, strict mode, JSON, Object.yechirib kirish, va Array metodlari.\r\n\r\n#### 2015: ES6 / ECMAScript 2015\r\n- **Katta yangilanish**: ECMAScript 6 (ES6) yoki ECMAScript 2015 JavaScript tilida eng katta yangilanishlardan biri bo'lib, yangi sinf tuzilmalari, arrow funksiyalar, let va const o'zgaruvchilari, promises, va modullar kabi ko'plab yangi imkoniyatlar qo'shildi.\r\n\r\n#### 2016-hozirgi kunga qadar: Yillik yangilanishlar\r\n- **Davom etayotgan rivojlanish**: ECMAScript 2016 (ES7), ECMAScript 2017 (ES8) va undan keyingi versiyalar yillik yangilanishlar orqali tilda yangi imkoniyatlar va yaxshilanishlarni taqdim etib kelmoqda.\r\n- **Yangi imkoniyatlar**: Async/await, generator funksiyalar, String va Array metodlari kabi imkoniyatlar qo'shildi.\r\n\r\n### JavaScript Imkoniyatlari\r\n\r\nJavaScript tilining hozirgi imkoniyatlari juda keng va quyidagi asosiy yo'nalishlarda qo'llaniladi:\r\n\r\n#### 1. Veb-Rivojlantirish\r\n- **Front-End**: JavaScript veb-sahifalarga dinamiklik qo'shish uchun ishlatiladi. HTML va CSS bilan birgalikda, u foydalanuvchi interfeyslarini yaratishning asosiy qismiga aylangan.\r\n- **Back-End**: Node.js orqali server tomonda ishlash imkonini beradi, bu esa JavaScript'ni to'liq stack rivojlantirish tiliga aylantiradi.\r\n\r\n#### 2. Mobil Ilovalar\r\n- **React Native** va **Ionic** kabi platformalar orqali JavaScript yordamida mobil ilovalar yaratish mumkin.\r\n\r\n#### 3. Veb Ilovalar\r\n- **Electron** yordamida JavaScript yordamida kross-platforma ish stoli ilovalari yaratish mumkin.\r\n\r\n#### 4. O'yin Rivojlantirish\r\n- **Phaser** va **Three.js** kabi kutubxonalar yordamida brauzer o'yinlari yaratish uchun JavaScript ishlatiladi.\r\n\r\n#### 5. Ma'lumotlar Bilan Ishlash\r\n- JavaScript asinxron operatsiyalarni qo'llab-quvvatlaydi, bu esa ma'lumotlarni olish va qayta ishlash uchun qulaydir.\r\n\r\n#### 6. Reaktiv Dasturlash\r\n- **React** va **Vue.js** kabi reaktiv kutubxonalar yordamida foydalanuvchi interfeyslarini yaratish uchun ishlatiladi.\r\n\r\nJavaScript dasturlash tilining imkoniyatlari va tarixi uni veb-rivojlantirishning ajralmas qismiga aylantiradi. Har yili yangi versiyalar va imkoniyatlar qo'shilishi bilan til yanada kuchliroq va ko'p tomonlama bo'lib bormoqda.",
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1),
                        NewsPhotoPath="https://localhost:7030/images/news/news2.jpg"
                    },
                    new NewsModel()
                    {
                        Title="Angular tarixi va imkoniyatlari",
                        About="### Angular Tarixi\r\n\r\n#### 1. AngularJS (Angular 1)\r\n- **Yaratilishi**: AngularJS dastlab 2009-yilda Misko Hevery va Adam Abrons tomonidan yaratildi. Google tomonidan ishlab chiqilgan bo'lib, u birinchi navbatda bir sahifalik veb-ilovalarni (SPA) yaratish uchun mo'ljallangan edi.\r\n- **Asosiy Konseptsiyalar**: AngularJS MVC (Model-View-Controller) arxitekturasiga asoslangan bo'lib, ikki tomonlama ma'lumotlar bog'lanishi (two-way data binding) va deklarativ dasturlashga katta e'tibor qaratdi.\r\n\r\n#### 2. Angular (Angular 2+)\r\n- **Rebrending va Yangi Versiya**: 2016-yilda Google Angular 2-ni chiqardi, bu AngularJS'dan tubdan farq qiladigan yangi va qayta yozilgan ramka edi. Shu vaqtdan boshlab, Angular (versiya 2 va undan keyingi versiyalar) AngularJS'dan farqlanadi va an'anaviy Angular deb ataladi.\r\n- **Asosiy Yaxshilanishlar**:\r\n  - **Komponentlar Arxitekturasi**: Angular 2 komponentga asoslangan arxitekturani qo'llab-quvvatlaydi, bu esa modullar va qayta foydalanish imkoniyatlarini oshiradi.\r\n  - **TypeScript**: Angular 2 va undan keyingi versiyalar TypeScript yordamida yozilgan, bu statik tahlil va kuchli tip tizimini ta'minlaydi.\r\n  - **O'rnatilgan Asinxron Ko'mak**: RxJS kutubxonasi yordamida reaktiv dasturlashni qo'llab-quvvatlaydi.\r\n\r\n#### 3. Angular 4, 5, 6 va Hozirgi Versiyalar\r\n- **Yillik Yangi Versiyalar**: Angular komandasi yillik yangilanishlarni joriy qildi. Har bir yangi versiya oldingi versiyalarni yaxshilab, yangi funksiyalar va optimallashtirishlarni qo'shadi.\r\n- **Angular CLI**: Angular dasturlarini yaratish, ishlab chiqish va boshqarish uchun kuchli buyruq qatori interfeysi (CLI) taqdim etildi.\r\n- **Ivy Renderer**: Angular 9-dan boshlab, yangi Ivy renderer joriy etildi, bu esa dasturning yuklanish vaqtini qisqartiradi va ishlash samaradorligini oshiradi.\r\n\r\n### Angular Imkoniyatlari\r\n\r\n#### 1. Komponentga Asoslangan Arxitektura\r\n- **Modullik**: Angular komponentlar va modullarga asoslangan bo'lib, bu kodni qayta ishlatishni osonlashtiradi va dasturni modullar shaklida tashkil qilish imkonini beradi.\r\n\r\n#### 2. TypeScript\r\n- **Statik Tahlil**: TypeScript yordamida yozilganligi sababli, Angular dasturchilarga kodni yozish va tahlil qilishda ko'maklashadi, bu esa kamroq xatoliklar va yanada ishonchli kod yozishga yordam beradi.\r\n\r\n#### 3. Ikki Tomonlama Ma'lumotlar Bog'lanishi\r\n- **Soddalashtirilgan Interfeyslar**: Model va view o'rtasida avtomatik sinxronlashni ta'minlaydi, bu esa foydalanuvchi interfeyslarini yaratishni soddalashtiradi.\r\n\r\n#### 4. Dependency Injection (DI)\r\n- **Modullik Va Qayta Ishlatish**: DI yordamida Angular komponentlar, xizmatlar va boshqa obyektlar o'rtasidagi bog'liqlikni boshqaradi va ularni osongina o'zgartirish va qayta ishlatish imkonini beradi.\r\n\r\n#### 5. RxJS Va Reaktiv Dasturlash\r\n- **Asinxron Ko'mak**: RxJS kutubxonasi yordamida reaktiv dasturlashni qo'llab-quvvatlaydi, bu esa asinxron operatsiyalarni boshqarishni osonlashtiradi.\r\n\r\n#### 6. Angular CLI\r\n- **Standartlashgan Loyihalar**: Angular CLI yordamida yangi loyihalarni yaratish, kodni yig'ish va ishlab chiqish jarayonlarini boshqarish osonlashadi. Bu dasturchilarga standartlashgan va toza kod bazalarini yaratishga yordam beradi.\r\n\r\n#### 7. Router\r\n- **SPA Yaratish**: Angular routeri yordamida bir sahifalik ilovalar yaratish va ularni boshqarish osonlashadi, bu esa foydalanuvchi tajribasini yaxshilaydi.\r\n\r\n#### 8. Formalar Va Validatsiya\r\n- **Interaktiv Formalar**: Angular'da reaktiv va shablon asosidagi formalarning kuchli qo'llab-quvvatlovi mavjud bo'lib, murakkab formalarga ishlov berishni va ularni validatsiya qilishni osonlashtiradi.\r\n\r\n#### 9. Performance Optimizations\r\n- **Yuklanish Vaqtlarini Qisqartirish**: Ivy renderer va boshqa optimallashtirishlar yordamida Angular ilovalari tezroq yuklanadi va samarali ishlaydi.\r\n\r\n### Xulosa\r\n\r\nAngular o'zining kuchli komponentga asoslangan arxitekturasi, TypeScript bilan integratsiyasi va keng qamrovli funksiyalari bilan veb-ilovalar yaratishda juda samarali va qulay vosita hisoblanadi. U dasturchilarga katta va murakkab ilovalarni tuzishda yordam berish uchun mo'ljallangan va yildan-yilga yaxshilanib, yangi imkoniyatlar qo'shilib bormoqda.",
                        popularTopic=await db.popularTopics.FirstOrDefaultAsync(x=>x.Id==1),
                       NewsPhotoPath="https://localhost:7030/images/news/news3.jpg"
                    },
                };

                await db.news.AddRangeAsync(list);
                await db.SaveChangesAsync();
            }
        }
    }
}
