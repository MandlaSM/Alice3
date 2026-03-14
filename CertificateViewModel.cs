namespace AliceTrainingSystem.ViewModels;

public class QuizQuestionViewModel
{
    public int Id { get; set; }
    public string QuestionText { get; set; } = string.Empty;
    public List<QuizOptionViewModel> Options { get; set; } = new();
}
