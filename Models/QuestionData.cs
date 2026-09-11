namespace IT_ELECTIVE_2_PREFINAL_Karunungan_Eirene.Models
{
    public static class QuestionData
    {
        public static List<Question> All { get; } = new List<Question>
        {
            new Question
                {
                    Number = 1,
                    Text = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "It makes C# code shorter" },
                        { "B", "It prevents the application from restarting" },
                        { "C", "It allows data to persist after the application stops" },
                        { "D", "It removes the need for MVC" }
                    },
                    CorrectAnswer = "C",

                },
                new Question
                    {
                        Number = 2,
                        Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                        Options = new Dictionary<string, string>
                        {
                            { "A", "Code-First" },
                            { "B", "Database-First" },
                            { "C", "Model-First" },
                            { "D", "Controller-First" }
                        },
                        CorrectAnswer = "B",
                    },


            new Question
                {
                    Number = 3,
                    Text = "What is the primary purpose of Entity Framework Core?",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "To create HTML pages automatically" },
                        { "B", "To replace the MVC Controller" },
                        { "C", "To map objects in code to relational database data" },
                        { "D", "To replace the C# compiler" }
                    },
                    CorrectAnswer = "C"
                },

            new Question
                {
                    Number = 4,
                    Text = "Which EF Core component is primarily responsible for communicating with the database?",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "DbContext" },
                        { "B", "DbSetView" },
                        { "C", "ControllerContext" },
                        { "D", "RazorContext" }
                    },
                    CorrectAnswer = "A"
                },
        new Question
                {
                    Number = 5,
                    Text = "What does the following command primarily do?\n\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "Deletes the database" },
                        { "B", "Creates a new MVC project" },
                        { "C", "Generates EF Core models and a DbContext from an existing database" },
                        { "D", "Starts the MVC application" }
                    },
                    CorrectAnswer = "C"
                },

            new Question
                {
                    Number = 6,
                    Text = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "Program.cs only" },
                        { "B", "appsettings.json" },
                        { "C", "Index.cshtml" },
                        { "D", "Student.cs" }
                    },
                    CorrectAnswer = "B"
                },


            new Question
                {
                    Number = 7,
                    Text = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "One-to-One" },
                        { "B", "One-to-Many" },
                        { "C", "Many-to-Many" },
                        { "D", "Many-to-One only" }
                    },
                    CorrectAnswer = "B"
                },

            new Question
                {
                    Number = 8,
                    Text = "In the following example, what is SectionId?\n\npublic int SectionId { get; set; }\npublic Section Section { get; set; }",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "Primary key of Student" },
                        { "B", "Foreign key referencing Section" },
                        { "C", "Navigation property" },
                        { "D", "Database connection string" }
                    },
                    CorrectAnswer = "B"
                },


            new Question
                {
                    Number = 9,
                    Text = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "It stores the database password" },
                        { "B", "It represents a relationship to another entity" },
                        { "C", "It creates a new database" },
                        { "D", "It validates the student's name" }
                    },
                    CorrectAnswer = "B"
                },


            new Question
                {
                    Number = 10,
                    Text = "What does .Include() generally allow EF Core to do?",
                    Options = new Dictionary<string, string>
                    {
                        { "A", "Delete the Section table" },
                        { "B", "Load related Section data together with Students" },
                        { "C", "Create a new Student" },
                        { "D", "Validate Student input" }
                    },
                    CorrectAnswer = "B"
                }

        };
    }
}