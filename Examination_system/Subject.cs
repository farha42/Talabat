using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Subject
    {



        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam Exam { get; set; }
        public Question question { get; set; }
        public Subject() { }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        int TypeOfExam, NumQuestions, TypeOfQuestion;
        int time;

        public void CreateExam()
        {
            do
            {
                Console.Write("Please Enter The Type Of Exam You Want To Create ( 1 for practical and 2 for final):");
            } while (!int.TryParse(Console.ReadLine(), out TypeOfExam) && TypeOfExam < 1 || TypeOfExam > 2);

            do
            {
                Console.Write("Enter The Time Of The Exam: ");
            } while (!int.TryParse(Console.ReadLine(), out time));
            do
            {
                Console.Write("Enter The Number Of Questions: ");
            } while (!int.TryParse(Console.ReadLine(), out NumQuestions));

            Console.Clear();
            Question[] questions = new Question[NumQuestions];

            //practical exam
            if (TypeOfExam == 1)
            {
                Exam = new Practical_Exam(time, NumQuestions);
            }
            else
            {
                //final exam
                Exam = new Final_Exam(time, NumQuestions);
            }

            Console.Clear();

            Exam.CreateListOfQuestions();
        }
    }
}
