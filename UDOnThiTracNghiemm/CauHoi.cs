using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDOnThiTracNghiemm
{
    internal class CauHoi
    {
        private string Question { get; set; }

        private List<string> Answers { get; set; }
        private string CorrectAns { get; set; }//

        // Chỉnh câu hỏi
        public void SetQues(string Ques)
        {
            this.Question = Ques;
        }

        public string getQues()
        {
            return this.Question;
        }


        public void setAnswers(string Ans)
        {
            Answers.Add(Ans);
        }
        public List<String> getAns()
        {
            return this.Answers;
        }

        public void setCorrectAns(string correctAns)
        {
            this.CorrectAns= correctAns;
        }

        public  string getCorAns()
        {
            return this.CorrectAns;
        }
        public CauHoi()
        {
            Answers = new List<string>(4);
        }
        public CauHoi(string Ques,List<string> ans,string CorrectAns)
        {
            this.Question= Ques;
            this.Answers = ans;
            this.CorrectAns = CorrectAns;
        }



    }
}
