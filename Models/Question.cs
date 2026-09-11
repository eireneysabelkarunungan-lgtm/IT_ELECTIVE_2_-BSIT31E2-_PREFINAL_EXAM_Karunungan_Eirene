namespace IT_ELECTIVE_2_PREFINAL_Karunungan_Eirene.Models
{
    public class Question
    {
        public int Number { get; set; }
        public string Text { get; set; } = string.Empty;

        public Dictionary<string, string> Options { get; set; } = new();


        public string CorrectAnswer { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }
}