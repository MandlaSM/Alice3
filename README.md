# Alice Training System - C# Milestone 1

This package is the first C# / ASP.NET Core MVC version of your training system, based on the structure and look-and-feel of the uploaded PHP platform.

## Included in Milestone 1
- Login / register / logout
- Learner dashboard
- Course catalogue
- Course details with modules and lessons
- Lesson page
- Lesson completion tracking
- SQLite database with seed data

## Not yet included
- Quizzes
- Certificates
- Admin course builder
- Japanese support
- Events / resources / news modules

## Tech stack
- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQLite
- Cookie authentication

## First run
1. Create a new empty folder on your machine.
2. Copy the contents of this project into it.
3. Run:
   - `dotnet restore`
   - `dotnet run`
4. The SQLite database file will be created automatically on first launch.

## Demo users
- Learner
  - Email: `learner@alice.local`
  - Password: `Learner123!`
- Admin
  - Email: `admin@alice.local`
  - Password: `Admin123!`

## Notes
- Password hashing here is intentionally lightweight for prototype speed. Before production, move to ASP.NET Core Identity or a stronger production-ready auth setup.
- The CSS keeps the visual rhythm of your PHP system: dark header, simple cards, rounded buttons, muted background, and clean content spacing.
