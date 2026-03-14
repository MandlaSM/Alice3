@model CertificateViewModel
@{
    ViewData["Title"] = "Certificate";
}

<section class="certificate-shell">
    <div class="certificate-card">
        <div class="certificate-inner">
            <p class="certificate-label">Certificate of Completion</p>
            <h1>@Model.LearnerName</h1>
            <p class="lead center-text">has successfully completed</p>
            <h2 class="certificate-course">@Model.CourseTitle</h2>
            <p class="center-text">Final quiz score: <strong>@Model.FinalScorePercent%</strong></p>
            <p class="center-text muted">Issued on @Model.IssuedAtUtc.ToLocalTime().ToString("dd MMMM yyyy")</p>
        </div>
    </div>
</section>

<section class="row wrap top-gap">
    <button class="btn" onclick="window.print()">Print certificate</button>
    <a asp-controller="Dashboard" asp-action="Index" class="btn ghost">Back to dashboard</a>
</section>
