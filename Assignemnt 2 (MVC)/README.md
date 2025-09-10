# Ayojon — Event Management (Assignment 2)

Brief: Minimal MVC event-management app for the assignment "Full Stack Web Development with ASP.NET Core — Assignment 2". Implements events and users using in-memory sample data.

## Assignment requirements (as provided)
- Create an MVC web application.
- Header must show a company name and provide 4 navigation links/buttons:
  - Home
  - All Events
  - Upcoming Events
  - Users
- Home page: show "Welcome to [Your_Company_Name]".
- All Events page: list all events (past and future).
- Upcoming Events page: list only upcoming events. (Events strictly after today; e.g. if today is Sept 2, 2025, show events from Sept 3, 2025 forward.)
- Users page: list user info. Show textual user type instead of numeric values:
  - 1 — Admin User
  - 2 — Standard User
  - 3 — External User
  - 4 — Guest User
- Footer: show designer credit (e.g. "This Application is Designed By [Your Name]").
- Default page should be the Upcoming Events page.

## What this project contains / implements
- Models
  - Ayojon/Models/Event.cs — properties: id, name, description, date, address, assignedUser.
  - Ayojon/Models/User.cs — properties: Id, FirstName, LastName, ContactNumber, Email, UserType (int).
- Sample data
  - Ayojon/SampleData.cs — in-memory lists for events and users used by the app.
- Controllers
  - Ayojon/Controllers/HomeController.cs — actions: Index, AllEvents, NextEvents, Users, Error.
    - Note: the default route in Program.cs points to NextEvents so Upcoming Events is the app's default page.
- Views
  - Views/Home/Index.cshtml — Home page.
  - Views/Home/AllEvents.cshtml — All events listing.
  - Views/Home/NextEvents.cshtml — Upcoming events listing (filtered in controller).
  - Views/Home/Users.cshtml — Users listing (converts numeric UserType to text).
  - Views/Shared/_Layout.cshtml — header with nav links and footer (designer name visible).

## How to run
1. Open the solution in Visual Studio 2022.
2. Build the project.
3. Start the app using __Debug > Start Debugging__ (or press __F5__). The app uses the default route configured in Program.cs so the Upcoming Events page opens first.

You can also run from command line:
- dotnet run (from project folder) — .NET 9 target.


