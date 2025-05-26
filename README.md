# 📏 MeasurementHub

**MeasurementHub** is a modular, full-stack demo application built using **ASP.NET Core**, **Blazor WebAssembly**, **Entity Framework Core**, and **Clean Architecture** principles with **CQRS** pattern and **MediatR** integration.

This project is designed as a learning and interview-ready reference for developers working with modern .NET stacks in real-world enterprise environments like **Energy Transfer** and other enterprise software teams.

---

## 🚀 Features

- ✅ **Clean Architecture** with clear separation of concerns
- 📦 **CQRS with MediatR** for command/query segregation
- 🌐 **ASP.NET Core Web API** for backend services
- 🖥 **Blazor WebAssembly** frontend with Telerik UI (trial)
- 🧪 In-memory DB for dev/testing with Entity Framework Core
- 📄 **Swagger/OpenAPI** documentation enabled
- 📁 Organized with `src/` and `tests/` folder structure for maintainability

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
