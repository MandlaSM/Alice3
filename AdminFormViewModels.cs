namespace AliceTrainingSystem.ViewModels;

public class QuizResultViewModel
{
    public int CourseId { get; set; }
    public string CourseTitle { get; set; } = string.Empty;
    public string QuizTitle { get; set; } = string.Empty;
    public int ScorePercent { get; set; }
    public int PassMarkPercent { get; set; }
    public bool Passed { get; set; }
    public DateTime AttemptedAtUtc { get; set; }
}
