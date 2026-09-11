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
            }
        };
    }
}