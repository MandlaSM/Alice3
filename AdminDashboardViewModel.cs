using System.ComponentModel.DataAnnotations;

namespace AliceTrainingSystem.ViewModels;

public class QuizTakeViewModel
{
    public int CourseId { get; set; }
    public int QuizId { get; set; }
    public string CourseTitle { get; set; } = string.Empty;
    public string QuizTitle { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public int PassMarkPercent { get; set; }
    public List<QuizQuestionViewModel> Questions { get; set; } = new();
    public Dictionary<int, int> Answers { get; set; } = new();
}
