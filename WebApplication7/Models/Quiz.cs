using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a quiz name.")]
        public string QuizName { get; set; }

        [Required(ErrorMessage = "Please enter a quiz time.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid quiz time.")]
        public int QuizTime { get; set; }

        public List<Question> Questions { get; set; }

        public Question NewQuestion { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the question text.")]
        public string Text { get; set; }

        public ChoiceType QuestionType { get; set; }

        public List<Answer> Answers { get; set; }

        public int QuestionNumber { get; set; }

        public int Score { get; set; }

        public void UpdateQuestion(Question updatedQuestion)
        {
            this.Text = updatedQuestion.Text;
            this.QuestionType = updatedQuestion.QuestionType;
            this.Answers = updatedQuestion.Answers;
            this.Score = updatedQuestion.Score;
        }
    }

    public class Answer
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }

    public enum ChoiceType
    {
        SelectOne,
        SelectMultiple
    }
}
