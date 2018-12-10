using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CounselorClient.Models;
using CounselorClient.ApiConnections;

namespace CounselorClient.Forms
{
    public partial class UserPersonalityForm : Form ,IApiResponseObserver
    {
        private List<QuizValidateModel> QuizList;
        private UserPerosonalityTypeInfo userPersonality;
        string extractedPersonality = "";
        public UserPersonalityForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            DummyData();
            
        }

        private void DummyData()
        {
            this.QuizList = new List<QuizValidateModel>();

            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 1,
                QuestiontypeId = 1,
                AnswerKeySection = 1,
                QuestionKey = "بد"
            });


            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 2,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            //-----------------------------------------------
            //------------------------------------------------------
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 3,
                QuestiontypeId = 2,
                AnswerKeySection = 1,
                QuestionKey = "حش"
            });


            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 4,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });

            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 5,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 6,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 7,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 8,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 9,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 10,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 11,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 12,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 13,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 14,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 15,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 16,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 17,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 18,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 19,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 20,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 21,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 22,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 23,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 24,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 25,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 26,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 27,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 28,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 29,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 30,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 31,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 32,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 33,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 34,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 35,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 36,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 37,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 38,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 39,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 40,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 41,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 42,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 43,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 44,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 45,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 46,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 47,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 48,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 49,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 50,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 51,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 52,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 53,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 54,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 55,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 56,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 57,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 58,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 59,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 60,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 61,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 62,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 63,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 64,
                QuestiontypeId = 1,
                AnswerKeySection = 2,
                QuestionKey = "بد"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 65,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 66,
                QuestiontypeId = 2,
                AnswerKeySection = 2,
                QuestionKey = "حش"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 67,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 68,
                QuestiontypeId = 3,
                AnswerKeySection = 2,
                QuestionKey = "ما"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 69,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
            QuizList.Add(new QuizValidateModel
            {
                QuestionId = 70,
                QuestiontypeId = 4,
                AnswerKeySection = 2,
                QuestionKey = "قل"
            });
        }

        public UserPersonalityForm(List<QuizValidateModel> QuizList)
        {
            InitializeComponent();
            this.QuizList = new List<QuizValidateModel>();
            this.QuizList.AddRange(QuizList);
            this.userPersonality = new UserPerosonalityTypeInfo();
        }

        private void UserPersonalityForm_Load(object sender, EventArgs e)
        {
            GetPerosnalityType();
        }
        public int ExtractedPersonalityLength()
        {
            QuizValidator quizValidator = new QuizValidator();
            extractedPersonality = quizValidator.DeterminPerosnalityKey(QuizList);
            return extractedPersonality.Length;
        }
        private void GetPerosnalityType()
        {
            QuizValidator quizValidator = new QuizValidator();
            extractedPersonality= quizValidator.DeterminPerosnalityKey(QuizList);
            //------------------------------------------------------------
            GetPerosonalityTypeInfo getPerosonalityTypeInfo = new GetPerosonalityTypeInfo();
            getPerosonalityTypeInfo.Attach(this);
            getPerosonalityTypeInfo.GetPerosnality(new PerosnalityTypeModel { PersonalityTypeKey = extractedPersonality });


        }

        public void OnResponse(object response, RequestCodes requestCode)
        {
            if(requestCode==RequestCodes.GetPersonalityInfo)
            {
                userPersonality = (UserPerosonalityTypeInfo)response;
                lblPersonalityTitle.Text ="تیپ شخصیتی : "+ userPersonality.PersonalityTypeTitle.Trim();
                lblKeyAttribute.Text = "صفات کلیدی : " + userPersonality.PersonalityTypeKeyAttribute;
                lblFamousCharacters.Text = "اشخاص معروف : " + userPersonality.PersonalityTypeFamousCharacters;
                lblStrenghtsPoints.Text = "نقاط قوت : " + userPersonality.PersonalityTypeStrenghtsPoints;
                lblWeakPoints.Text = "نقاط ضعف : " + userPersonality.PersonalityTypeWeakPoints;
                lblRelationsWithOthers.Text = "روابط با دیگران : " + userPersonality.PersonalityTypeRelationsWithOthers;
                lblProperJobs.Text = "مشاغل مربوط : " + userPersonality.PersonalityTypeProperJobs;
                pictureBox1.Image = Image.FromFile(Application.StartupPath+"/Images/"+userPersonality.PersonalityTypeAvatar);
            }
        }

        private void lblFamousCharacters_Click(object sender, EventArgs e)
        {

        }
    }
}
