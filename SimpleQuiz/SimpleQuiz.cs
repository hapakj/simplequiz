using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace SimpleQuiz
{
    public partial class SimpleQuiz : Form
    {
        const String problems_filename = "problems.txt";

        List<Problem> problems;
        Problem last_problem;

        public SimpleQuiz()
        {
            InitializeComponent();
        }

        private void SimpleQuiz_Load(object sender, EventArgs e)
        {
            QuestionTextLabel.Text = "";
            AnswerTextLabel.Text = "";

            Init();

            bool s = NextProblem();

            if (!s)
            {
                MessageBox.Show("Nincsenek feladatok. Kilépés.", "Info");
                Close();
            }
        }

        bool NextProblem()
        {
            if (problems.Count == 0) return false;

            last_problem = problems[0];
            problems.Remove(last_problem);

            QuestionTextLabel.Text = last_problem.question;
            AnswerTextLabel.Text = "";

            return true;
        }

        void Init()
        {
            var ser = new DataContractJsonSerializer(typeof(List<Problem>));

            try
            {
                var problems_file = new System.IO.StreamReader(problems_filename);
                problems = (List<Problem>)ser.ReadObject(problems_file.BaseStream);
                problems_file.Close();
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                String msg = "Error during serializing problems. Exit.";
                Console.WriteLine(msg);
                MessageBox.Show(msg, "Error");
                Close();
                return;
            }
            catch (System.IO.FileNotFoundException)
            {
                // create init problems
                String msg = "Problems file not found. Create new problems.";
                Console.WriteLine(msg);
                MessageBox.Show(msg, "Info");

                var init_problems = new List<Problem>();
                init_problems.Add(new Problem("apple", "alma"));
                init_problems.Add(new Problem("peach", "barack"));

                var problems_file_out = new System.IO.StreamWriter(problems_filename);
                ser.WriteObject(problems_file_out.BaseStream, init_problems);
                problems_file_out.Close();

                problems = init_problems;
            }

            Console.WriteLine("Problems count: " + problems.Count.ToString() );

            
        }

        private void ShowAnswerBtn_Click(object sender, EventArgs e)
        {
            ShowAnswerBtn.Enabled = false;
            NextProblemBtn.Enabled = true;

            AnswerTextLabel.Text = last_problem.answer;
        }

        private void NextProblemBtn_Click(object sender, EventArgs e)
        {
            ShowAnswerBtn.Enabled = true;
            NextProblemBtn.Enabled = false;

            bool s = NextProblem();
            if (!s)
            {
                MessageBox.Show("Elfogytak a feladatok. Kilépés.", "Info");
                Close();
            }
        }
    }

    [DataContract]
    public class Problem
    {
        public Problem(String question, String answer)
        {
            this.question = question;
            this.answer = answer;
        }

        [DataMember]
        public String question;

        [DataMember]
        public String answer;
    }
}
