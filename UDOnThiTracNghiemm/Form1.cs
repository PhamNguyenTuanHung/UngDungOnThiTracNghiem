using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDOnThiTracNghiemm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        

        List<CauHoi> OldQues;
        List<string> DSCauTraLoi;// Danh sach các câu trả lời
        int ViTriCauTraLoi;
        List<CauHoi> DSCauHoi;


        bool isAnswer()
        {
            if (rdA.Checked == rdB.Checked == rdC.Checked == rdD.Checked == false)
                return false;
            return true;
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            OldQues = new List<CauHoi>();
            DocFile DocFile = new DocFile();
            DocFile.DocFileTXT();
            DSCauHoi = new List<CauHoi>();
            DSCauHoi=DocFile.DSCauHoi;
            DSCauTraLoi = new List<string>(new string[DSCauHoi.Count]);
            DisplayQuestion();

            ViTriCauTraLoi = 0;
            rdA.Checked = rdB.Checked = rdC.Checked = rdD.Checked = false;
        }

        private void DisplayQuestion()
        {
            if (ViTriCauTraLoi < 0 || ViTriCauTraLoi >= DSCauHoi.Count) return;

            var currentQuestion = DSCauHoi[ViTriCauTraLoi];
            groupBox1.Text = currentQuestion.getQues();
            rdA.Text = currentQuestion.getAns()[0];
            rdB.Text = currentQuestion.getAns()[1];
            rdC.Text = currentQuestion.getAns()[2];
            rdD.Text = currentQuestion.getAns()[3];
            // Đặt lại trạng thái các RadioButton
            rdA.Checked = rdB.Checked = rdC.Checked = rdD.Checked = false;
            // Kiểm tra câu trả lời của người dùng nếu đã có
            if (DSCauTraLoi[ViTriCauTraLoi] == "A") rdA.Checked = true;
            if (DSCauTraLoi[ViTriCauTraLoi] == "B") rdB.Checked = true;
            if (DSCauTraLoi[ViTriCauTraLoi] == "C") rdC.Checked = true;
            if (DSCauTraLoi[ViTriCauTraLoi] == "D") rdD.Checked = true;
        }

            
        private void SaveAnswer()
        {
            if (rdA.Checked) DSCauTraLoi[ViTriCauTraLoi] = "A";
            if (rdB.Checked) DSCauTraLoi[ViTriCauTraLoi] = "B";
            if (rdC.Checked) DSCauTraLoi[ViTriCauTraLoi] = "C";
            if (rdD.Checked) DSCauTraLoi[ViTriCauTraLoi] = "D";
        }
        private void btn_TrangDau_Click(object sender, EventArgs e)
        { 
            SaveAnswer();
            ViTriCauTraLoi = 0;
            groupBox1.Text = DSCauHoi[ViTriCauTraLoi].getQues();// Hiển thị câu hỏi
            rdA.Text = DSCauHoi[ViTriCauTraLoi].getAns()[0];// Hiện thị câu trả lời cho rdA
            rdB.Text = DSCauHoi[ViTriCauTraLoi].getAns()[1];// Hiện thị câu trả lời cho rdB
            rdC.Text = DSCauHoi[ViTriCauTraLoi].getAns()[2];// Hiện thị câu trả lời cho rdC
            rdD.Text = DSCauHoi[ViTriCauTraLoi].getAns()[3];// Hiện thị câu trả lời cho rdD
            DisplayQuestion();
        }

        private void btn_TrangTiep_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (ViTriCauTraLoi >= DSCauHoi.Count) return;
            if (ViTriCauTraLoi < DSCauHoi.Count()-1) ViTriCauTraLoi++;
            groupBox1.Text = DSCauHoi[ViTriCauTraLoi].getQues();// Hiển thị câu hỏi
            rdA.Text = DSCauHoi[ViTriCauTraLoi].getAns()[0];// Hiện thị câu trả lời cho rdA
            rdB.Text = DSCauHoi[ViTriCauTraLoi].getAns()[1];// Hiện thị câu trả lời cho rdB
            rdC.Text = DSCauHoi[ViTriCauTraLoi].getAns()[2];// Hiện thị câu trả lời cho rdC
            rdD.Text = DSCauHoi[ViTriCauTraLoi].getAns()[3];// Hiện thị câu trả lời cho rdD
            DisplayQuestion();
        }

        private void btn_TrangTruoc_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            if (ViTriCauTraLoi <=0 ) return;
            ViTriCauTraLoi--;
            groupBox1.Text = DSCauHoi[ViTriCauTraLoi].getQues();// Hiển thị câu hỏi
            rdA.Text = DSCauHoi[ViTriCauTraLoi].getAns()[0];// Hiện thị câu trả lời cho rdA
            rdB.Text = DSCauHoi[ViTriCauTraLoi].getAns()[1];// Hiện thị câu trả lời cho rdB
            rdC.Text = DSCauHoi[ViTriCauTraLoi].getAns()[2];// Hiện thị câu trả lời cho rdC
            rdD.Text = DSCauHoi[ViTriCauTraLoi].getAns()[3];// Hiện thị câu trả lời cho rdD
            DisplayQuestion();
        }

        private void btn_TrangCuoi_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            ViTriCauTraLoi = DSCauHoi.Count - 1; ;
            groupBox1.Text = DSCauHoi[ViTriCauTraLoi].getQues();// Hiển thị câu hỏi
            rdA.Text = DSCauHoi[ViTriCauTraLoi].getAns()[0];// Hiện thị câu trả lời cho rdA
            rdB.Text = DSCauHoi[ViTriCauTraLoi].getAns()[1];// Hiện thị câu trả lời cho rdB
            rdC.Text = DSCauHoi[ViTriCauTraLoi].getAns()[2];// Hiện thị câu trả lời cho rdC
            rdD.Text = DSCauHoi[ViTriCauTraLoi].getAns()[3];// Hiện thị câu trả lời cho rdD
            DisplayQuestion();
        }
/*        private void rdC_CheckedChanged(object sender, EventArgs e)
        {
            DSCauTraLoi[ViTriCauTraLoi] = CheckTraLoi();
        }

        private void rdA_CheckedChanged(object sender, EventArgs e)
        {
            DSCauTraLoi[ViTriCauTraLoi] = CheckTraLoi();
        }

        private void rdB_CheckedChanged(object sender, EventArgs e)
        {
            DSCauTraLoi[ViTriCauTraLoi] = CheckTraLoi();
        }

        private void rdD_CheckedChanged(object sender, EventArgs e)
        {
            DSCauTraLoi[ViTriCauTraLoi] = CheckTraLoi();
        }*/

        private void btn_NopBai_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            int score = 0;
            for (int i = 0; i < DSCauHoi.Count; i++)
            {
                if (DSCauTraLoi[i].Trim() == DSCauHoi[i].getCorAns().Trim()) score++;
            }
            MessageBox.Show($"Bạn đã trả lời đúng {score} trên {DSCauHoi.Count} câu.", "Kết quả");
        }
    }
}
