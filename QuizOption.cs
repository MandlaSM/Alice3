namespace AliceTrainingSystem.Models;

public class QuizQuestion
{
    public int Id { get; set; }
    public int CourseQuizId { get; set; }
    public string QuestionText { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    public CourseQuiz? CourseQuiz { get; set; }
    public ICollection<QuizOption> Options { get; set; } = new List<QuizOption>();
}
