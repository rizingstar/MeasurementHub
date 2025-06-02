# 📏 MeasurementHub, ASP.NET Core C# CQRS REST API MediatR Clean Architecture

**MeasurementHub** is a modular, full-stack demo application built using **ASP.NET Core**, **Blazor WebAssembly**, **Entity Framework Core**, and **Clean Architecture** principles with **CQRS** pattern and **MediatR** integration.

**📏 MeasurementHub **
**A real-world .NET reference for building, learning, and selling your expertise—MeasurementHub helps you ship enterprise-grade software faster and smarter.**

MeasurementHub is more than just a demo—it's a modular, production-style blueprint engineered for developers and teams who want to build scalable, maintainable, and interview-ready solutions on today’s .NET stack.

**Why MeasurementHub?**
Accelerate your learning and project delivery with a battle-tested architecture inspired by real-world enterprise scenarios (think Fortune 500s). Whether you’re preparing for interviews, onboarding to a new team, or looking for proven patterns to implement at work, MeasurementHub empowers you to build with confidence and modern best practices.

**🚀 Key Features & Benefits**
**Clean Architecture**
Robust, enterprise-proven separation of concerns to keep your codebase maintainable as it grows.

**CQRS + MediatR**
Leverage command/query segregation and MediatR pipelines to deliver true decoupling and testability.

**RESTful ASP.NET Core Web API**
Build scalable backend services, ready for integration and extension.

**Modern UI with Blazor WebAssembly**
Deliver rich client experiences with a modern SPA frontend (showcasing Telerik UI, trial version included).

**Plug-and-Play Data Layer**
Use Entity Framework Core with an in-memory database for rapid prototyping and automated testing.

**Swagger/OpenAPI**
Out-of-the-box interactive API documentation makes onboarding and integration a breeze.

**Professional Project Structure**
Organized src/ and tests/ directories modeled after enterprise codebases for real-world maintainability.

**Who Is This For?**
**.NET Developers:**
Looking for a reference app with proven patterns.

**Engineering Teams:**
Onboarding new team members or standardizing best practices.

J**ob Seekers:**
Preparing for interviews or building a portfolio project that stands out.

**Enterprise Architects:**
Evaluating modular approaches for greenfield or brownfield projects.

---

## 🏗️ Project Structure
MeasurementHub/
├── src/
│ ├── MeasurementHub.Api/ # ASP.NET Core Web API (Controllers + DI)
│ ├── MeasurementHub.Application/ # Application layer (CQRS Handlers, DTOs)
│ ├── MeasurementHub.Domain/ # Core domain models and interfaces
│ ├── MeasurementHub.Infrastructure/# Infra services (logging, email, etc.)
│ ├── MeasurementHub.Persistence/ # EF Core DbContext & Repository
│ └── MeasurementHub.Client/ # Blazor WASM UI using TelerikGrid
└── README.md

---

## 🧰 Tech Stack

| Layer            | Tech Used                              |
|------------------|-----------------------------------------|
| UI Frontend      | Blazor WebAssembly + Telerik UI         |
| API Backend      | ASP.NET Core 8                          |
| Data Access      | Entity Framework Core (InMemory + SQL) |
| Architecture     | Clean Architecture + CQRS              |
| Mediator         | MediatR                                 |
| API Docs         | Swashbuckle / Swagger                   |
| DI & Config      | .NET built-in Dependency Injection      |

---

## 📸 Screenshots

> _(Coming Soon)_ Blazor UI with live API integration and grid-based data listing.

---

## 🔧 Getting Started

### ✅ Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022+ with Blazor/WebAssembly workload
- (Optional) Telerik UI Trial Key (if using premium components)

### 🛠️ Setup Instructions

1. **Clone the repository**
   ``bash
   git clone https://github.com/rizingstar/MeasurementHub.git
   cd MeasurementHub/src
---

| Method | Endpoint                 | Description            |
| ------ | ------------------------ | ---------------------- |
| GET    | `/api/measurements`      | Get all measurements   |
| GET    | `/api/measurements/{id}` | Get measurement by ID  |
| POST   | `/api/measurements`      | Create new measurement |
| PUT    | `/api/measurements/{id}` | Update measurement     |
| DELETE | `/api/measurements/{id}` | Delete measurement     |

---

💡 Learnings & Design Choices
Implemented CQRS pattern using IRequestHandler<TRequest, TResponse> for command/query segregation.

Used Clean Architecture to enforce layer separation:

Domain: Business rules

Application: Use-cases, handlers

Infrastructure: EF Core logic

API: Only orchestration via Controllers + MediatR

Dependency Injection ensures testability and decoupling.

Blazor WASM acts as lightweight SPA frontend, consuming REST API.

---

👨‍💻 Author
Noman Khan
.NET Full Stack Developer | Clean Architecture Advocate | Houston, TX
LinkedIn Profile (https://www.linkedin.com/in/Nomanakhan/)

---

📜 License
This project is licensed under the MIT License.

---
