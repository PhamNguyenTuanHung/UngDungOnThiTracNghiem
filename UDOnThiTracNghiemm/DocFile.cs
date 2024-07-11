using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDOnThiTracNghiemm
{
    internal class DocFile
    {
        public List<CauHoi> DSCauHoi;// Tạo list danh sách câu hỏi



        public void DocFileTXT()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    try
                    {
                        DSCauHoi = new List<CauHoi>();

                        // Mở file để đọc
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        {
                            string line;
                            CauHoi currentQuestion = null;

                            // Đọc từng dòng của file và xử lý
                            while ((line = reader.ReadLine()) != null)
                            {
                                line = line.Trim(); // Xóa các khoảng trắng thừa ở đầu và cuối dòng

                                if (line.StartsWith("Câu hỏi"))
                                {
                                    // Nếu dòng bắt đầu bằng "Câu hỏi", đây là một câu hỏi mới
                                    if (currentQuestion != null)
                                    {
                                        DSCauHoi.Add(currentQuestion); // Thêm câu hỏi trước vào danh sách
                                    }
                                    // Tạo câu hỏi mới
                                    currentQuestion = new CauHoi();
                                    currentQuestion.SetQues(line);
                                }
                                else if (line.StartsWith("A.") || line.StartsWith("B.") || line.StartsWith("C.") || line.StartsWith("D."))
                                {
                                    // Nếu dòng bắt đầu bằng "A.", "B.", "C.", "D.", đây là một đáp án
                                    if (currentQuestion != null)
                                    {
                                        currentQuestion.setAnswers(line);
                                    }
                                }
                                else if (line.StartsWith("Đáp án:"))
                                {
                                    // Nếu dòng bắt đầu bằng "Đáp án:", đây là đáp án của câu hỏi trước
                                    if (currentQuestion != null)
                                    {
                                        line = line.Substring(7);
                                        currentQuestion.setCorrectAns(line);
                                    }
                                }
                            }

                            // Thêm câu hỏi cuối cùng vào danh sách (nếu có)
                            if (currentQuestion != null)
                            {
                                DSCauHoi.Add(currentQuestion);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
                    }
                }
            }    
            
        }
        public void DocFileBF(string SourceFile)
        {
            if(!File.Exists(SourceFile))
            {
                MessageBox.Show("Đường dẫn không tồn tại!","Cảnh báo",MessageBoxButtons.OKCancel);
                return;
            }
            FileStream fileStream = new FileStream(SourceFile, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            while (fileStream.Position < fileStream.Length)
            {
                CauHoi Ques = (CauHoi)bf.Deserialize(fileStream);
                DSCauHoi.Add(Ques);
            }
        }

        public void GhiFileBF(string SourceFile)
        {
            if (File.Exists(SourceFile))
            {
                MessageBox.Show("Đường dẫn không tồn tại!", "Cảnh báo", MessageBoxButtons.OKCancel);
                return;
            }
            FileStream fs = new FileStream(SourceFile, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach(CauHoi cauHoi in DSCauHoi)
            {
                binaryFormatter.Serialize(fs, cauHoi);
            }
        }
    }
}
