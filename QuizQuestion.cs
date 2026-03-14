namespace AliceTrainingSystem.Models;

public class CourseQuiz
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public int PassMarkPercent { get; set; } = 70;
    public bool IsPublished { get; set; } = true;

    public Course? Course { get; set; }
    public ICollection<QuizQuestion> Questions { get; set; } = new List<QuizQuestion>();
    public ICollection<QuizAttempt> Attempts { get; set; } = new List<QuizAttempt>();
}
