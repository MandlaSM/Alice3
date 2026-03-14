namespace AliceTrainingSystem.Models;

public class QuizOption
{
    public int Id { get; set; }
    public int QuizQuestionId { get; set; }
    public string OptionText { get; set; } = string.Empty;
    public bool IsCorrect { get; set; }
    public int SortOrder { get; set; }

    public QuizQuestion? QuizQuestion { get; set; }
}
