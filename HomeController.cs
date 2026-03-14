@model AdminDashboardViewModel
@{
    ViewData["Title"] = "Admin";
}

<section class="hero card compact">
    <div class="row wrap">
        <div>
            <span class="pill">Admin area</span>
            <h1>Course builder</h1>
            <p class="lead">Create and manage the core training structure while keeping the styling close to your original PHP system.</p>
        </div>
        <div class="stats-row">
            <div class="stat card mini"><strong>@Model.CourseCount</strong><span>Courses</span></div>
            <div class="stat card mini"><strong>@Model.ModuleCount</strong><span>Modules</span></div>
            <div class="stat card mini"><strong>@Model.LessonCount</strong><span>Lessons</span></div>
            <div class="stat card mini"><strong>@Model.QuizCount</strong><span>Quizzes</span></div>
        </div>
    </div>
</section>

<section class="grid top-gap admin-actions-grid">
    <a asp-action="CreateCourse" class="card action-card"><h3>Create course</h3><p>Add a new top-level course.</p></a>
    <a asp-action="CreateModule" class="card action-card"><h3>Create module</h3><p>Add a module to an existing course.</p></a>
    <a asp-action="CreateLesson" class="card action-card"><h3>Create lesson</h3><p>Add HTML content and optional video links.</p></a>
    <a asp-action="CreateQuiz" class="card action-card"><h3>Create quiz</h3><p>Add a final quiz to a course.</p></a>
    <a asp-action="CreateQuestion" class="card action-card"><h3>Add question</h3><p>Add four-option quiz questions.</p></a>
</section>

<section class="top-gap">
    <h2>Current courses</h2>
    <div class="card top-gap-sm">
        <table class="table-clean">
            <thead>
                <tr>
                    <th>Course</th>
                    <th>Modules</th>
                    <th>Lessons</th>
                    <th>Quiz</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
            @foreach (var course in Model.Courses)
            {
                <tr>
                    <td>@course.Title</td>
                    <td>@course.ModuleCount</td>
                    <td>@course.LessonCount</td>
                    <td>@(course.HasQuiz ? "Yes" : "No")</td>
                    <td><a asp-controller="Courses" asp-action="Details" asp-route-id="@course.Id" class="btn ghost small">Preview</a></td>
                </tr>
            }
            </tbody>
        </table>
    </div>
</section>
