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
                    Explanation = "An in-memory collection is wiped out every time the app restarts. A database stores data on disk, so it survives restarts — that persistence is the core reason databases exist."
                }
        };
    }
}