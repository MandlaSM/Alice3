@model QuizTakeViewModel
@{
    ViewData["Title"] = Model.QuizTitle;
}

<section class="hero card compact">
    <span class="pill">Final quiz</span>
    <h1>@Model.QuizTitle</h1>
    <p class="lead">@Model.Summary</p>
    <p class="muted">Course: @Model.CourseTitle &middot; Pass mark: @Model.PassMarkPercent%</p>
</section>

<form asp-action="Take" method="post" class="top-gap">
    @Html.AntiForgeryToken()
    <input type="hidden" asp-for="CourseId" />
    <input type="hidden" asp-for="QuizId" />
    <input type="hidden" asp-for="CourseTitle" />
    <input type="hidden" asp-for="QuizTitle" />
    <input type="hidden" asp-for="Summary" />
    <input type="hidden" asp-for="PassMarkPercent" />

    @for (var i = 0; i < Model.Questions.Count; i++)
    {
        <article class="card top-gap-sm">
            <h3>@(i + 1). @Model.Questions[i].QuestionText</h3>
            <input type="hidden" asp-for="Questions[i].Id" />
            <input type="hidden" asp-for="Questions[i].QuestionText" />
            @for (var j = 0; j < Model.Questions[i].Options.Count; j++)
            {
                <input type="hidden" asp-for="Questions[i].Options[j].Id" />
                <input type="hidden" asp-for="Questions[i].Options[j].OptionText" />
                <label class="option-row">
                    <input type="radio" name="Answers[@Model.Questions[i].Id]" value="@Model.Questions[i].Options[j].Id" required />
                    <span>@Model.Questions[i].Options[j].OptionText</span>
                </label>
            }
        </article>
    }

    <div class="row wrap top-gap">
        <a asp-controller="Courses" asp-action="Details" asp-route-id="@Model.CourseId" class="btn ghost">Back to course</a>
        <button type="submit" class="btn">Submit quiz</button>
    </div>
</form>
