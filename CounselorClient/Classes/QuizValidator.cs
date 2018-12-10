using System.Collections.Generic;
using System.Linq;

namespace CounselorClient.Models
{
    public class QuizValidator
    {
        public string DeterminPerosnalityKey(List<QuizValidateModel>quizList)
        {
            string mypersnality = "";
            for (int i = 1; i <= 4; ++i)
            {
                //-----------------------------
                var firstStates = quizList.Where(b => b.QuestiontypeId == i && b.AnswerKeySection == 1).Select(c => new { c.AnswerKeySection, c.QuestionKey }).ToList();
                var secoundStates = quizList.Where(b => b.QuestiontypeId == i && b.AnswerKeySection == 2).Select(c => new { c.AnswerKeySection, c.QuestionKey }).ToList();
                if (firstStates.Count > secoundStates.Count)
                {
                    mypersnality += firstStates[0].QuestionKey[0].ToString();
                }
                else if (secoundStates.Count > firstStates.Count)
                {
                    mypersnality += secoundStates[0].QuestionKey[1].ToString();
                }
                //--------------------------------------------------
            }
            return mypersnality;
        }
    }
}
