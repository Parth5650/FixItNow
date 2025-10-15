# FixItNow

## Project Overview
**FixItNow** is a web-based platform developed using **ASP.NET Core MVC**. It helps customers book and manage services efficiently while providing an admin dashboard to manage services, bookings, and users.

---

## Features Implemented
### User Features
- Sign up and log in
- Browse and search services
- Book services and view booking history
- Rate and review completed services

### Admin Features
- Manage services (add, update, delete)
- View all bookings and customer details
- Generate service reports
- Manage users and roles

### Additional Features
- Responsive design for desktop and tablet
- Role-based access control
- Error handling and input validations

---

## Project Setup Instructions

### Option 1: Using Visual Studio
1. Open **Visual Studio**.
2. Click **File → Open → Project/Solution**.
3. Navigate to the project folder `FixItNow` and open `FixItNow.sln`.
4. Restore NuGet packages if prompted.
5. Set **FixItNow** as the startup project.
6. Press **F5** to run the application in **IIS Express**.

### Option 2: Using .NET CLI
1. Open terminal in project folder:
```bash
cd E:\DDU\Sem_5\WAD\FixItNow


Restore dependencies:

dotnet restore


Build the project:

dotnet build


Run the project:

dotnet run


Open your browser and go to:

https://localhost:5001


(or the port shown in the console)

Folder Structure
FixItNow/
│
├── Controllers/      # MVC controllers
├── Data/             # Database context and initial data
├── Migrations/       # EF Core migrations
├── Models/           # Application data models
├── Views/            # Razor pages for UI
├── wwwroot/          # Static files (CSS, JS, images)
├── bin/              # Build output (ignored in Git)
├── obj/              # Temporary build files (ignored in Git)
├── Properties/       # Project properties
├── appsettings.json  # Configuration settings
├── appsettings.Development.json # Development config
├── Program.cs        # Application entry point
├── Startup.cs        # Middleware and services configuration
├── FixItNow.sln      # Solution file
├── FixItNow.csproj   # Project file
└── README.md         # Project documentation

Team Members & Contributions
Name	Contribution
Parth Chandegara :- Project setup, Controllers, Views, Git integration
Dhyey Shah :- Database connection, UI, Models


Commit Guidelines

Use clear and descriptive commit messages, e.g.:
git commit -m "Implemented BookingController and Views"

Keep branches small and focused.

Push frequently to GitHub to avoid conflicts.

License

This project is open for educational purposes. For commercial use, permission must be obtained from the contributors.
