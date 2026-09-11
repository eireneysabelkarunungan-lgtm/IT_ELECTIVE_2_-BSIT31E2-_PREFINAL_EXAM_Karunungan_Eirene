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
                        
                    }
        };
    }
}