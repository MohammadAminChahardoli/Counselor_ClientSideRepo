namespace CounselorClient.Models
{
    public class QuizValidateModel
    {
        public int QuestionId { get; set; }
        public int QuestiontypeId { get; set; }
        public string QuestionKey { get; set; }
        public int AnswerKeySection { get; set; }
    }
}
