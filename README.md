# Student Management API – CQRS & MediatR (In-Memory Storage)

This project is a **.NET Web API** developed using the **CQRS (Command Query Responsibility Segregation)** pattern along with the **MediatR** library.  
The application manages student records completely **in memory**, without using any database.

---

## 📌 Objective

The goal of this assignment is to implement a clean and scalable architecture by separating:

- **Commands** → Write operations (Create, Update, Delete)  
- **Queries** → Read operations (Get All Students)

MediatR is used to centralize request handling, improving maintainability and structure.

---

## 📂 Folder Structure

```plaintext
CQRS/
 ├── Behaviors/              # Validation pipeline using FluentValidation
 ├── Command/
 │     ├── CreateStudent/    # Create command + handler
 │     ├── UpdateStudent/    # Update command + handler
 │     └── DeleteStudent/    # Delete command + handler
 ├── Controller/             # Student API controller
 ├── Data/                   # In-memory DbContext
 ├── Middlewares/            # Custom middlewares 
 ├── Models/                 # Student model
 ├── Queries/
 │     └── GetAllStudents/   # Query + handler for listing all students
 ├── Validators/             # FluentValidation rules
 ├── Program.cs              # Application startup
 └── CQRS.sln                # Solution file
```

**Features Implemented**

✔ Add Student

Handled through CreateStudentCommand + Handler
Validation done using FluentValidation.

✔ Update Student

Handled using UpdateStudentCommand
Checks if student exists before updating.

✔ Delete Student

Handled using DeleteStudentCommand

✔ Get All Students

Query handled by GetAllStudentsQuery

**Technologies Used**

ASP.NET Core Web API
CQRS Pattern
MediatR
FluentValidation
In-Memory List Storage

**How to Run the Project**

Open the solution in Visual Studio.
Restore the NuGet packages.
Run the project using https.
Open Swagger:
https://localhost:xxxx/swagger

**Conclusion**

This assignment demonstrates how CQRS and MediatR can be used to build a clean, layered, and scalable API.
The project successfully supports adding, updating, deleting, and retrieving students, with proper validation and architecture separation.
