# ITI Summer Training Tasks – ASP.NET Development

This repository contains a series of **hands-on C# projects and exercises** developed during my summer training at the **Information Technology Institute (ITI)**.

Each folder focuses on a specific topic or concept, showcasing **practical implementations**, **clean code structure**, and **real-world development practices**.

---

## 📚 Training Overview

- **Duration:** 1 Month  
- **Track:** ASP.NET Development  
- **Technologies & Tools:** C#, SQL Server, Entity Framework, ASP.NET MVC, ASP.NET Web API  
- **Final Project:** ⚡ Hackathon Challenge

---

## 🧩 Tasks Details

### 🗓️ Day 1
**Purpose:** Learn C# syntax basics and console applications.  
**Key Concepts:** Variables, data types, `Console.WriteLine`, `Console.ReadLine`.

---

### 🗓️ Day 2
**Purpose:** Introduce object-oriented structure.  
**Key Concepts:** Class design, constructors, encapsulation.

---

### 🗓️ Day 3
**Purpose:** Dive deeper into OOP.  
**Key Concepts:** Inheritance hierarchies, interfaces, method overriding.

---

### 🧰 ClassLibrary1
**Purpose:** Provide a shared library of common utilities.  
**Usage:** Imported into other projects (e.g., Day2...) for reuse.

---

### 🗓️ Day 4
**Purpose:** Handle runtime errors gracefully.  
**Key Concepts:** Exception handling using `try`, `catch`, `finally`, and custom exceptions.

---

### 🗓️ Day 7 – Bubble Sort with Delegates
**Purpose:** Implement generic sorting logic using delegates.  
**Highlights:**
1. `Compare` delegate to inject comparison logic.  
2. Anonymous methods for ascending/descending sort.  
3. Tracing output for each pass and swap in Bubble Sort.

---

### 🗓️ Day 8 – Thermostat with Events
**Purpose:** Build event-driven logic in C#.  
**Highlights:**
1. `Thermostat` class with `OnTemperatureChanged` event *(Publisher)*  
2. `Heater` and `Cooler` classes respond based on threshold *(Subscribers)*  
3. Demonstrates loose coupling and real-world event usage.

---

### 🗓️ Day 9
**Purpose:** Learn LINQ for data querying in C#.  
**Key Concepts:** LINQ syntax, query expressions, filtering, grouping.

---

### 🗓️ Day 10
**Purpose:** Implement file I/O operations in C#.  
**Key Concepts:** Reading/writing files, `StreamReader`, `StreamWriter`, file exception handling.

---

## 🎯 Learning Objectives
- Understand fundamental and advanced OOP principles.  
- Practice exception handling techniques.  
- Explore delegate-based programming and event-driven architecture.  
- Learn to structure reusable code via libraries.

---

## 🌐 MVC & Web Development Track

### 🗂️ Overview
This section contains projects focused on the **Model-View-Controller (MVC)** architectural pattern.  
Each project demonstrates separation of concerns in web applications, organizing code into **Models**, **Views**, and **Controllers**.

---

### 🗓️ Day 11 – MVC Controllers & Views
**Focus:** Implementing the core components of MVC architecture (Controllers and Views).  
**Topics Covered:**
- **Controllers:**  
  - Managing user interactions and handling HTTP requests (GET, POST).  
  - Routing and passing data between controllers and views.  
- **Views:**  
  - Dynamic UI design using Razor templates.  
  - Rendering data and implementing layouts & partial views.  
- **Routing:**  
  - Configuring URL mapping to controller actions.  
- **Exercise:**  
  - Built a simple MVC app with form input and output rendering.

---

### 🗓️ Day 12 – Models & Database Integration
**Focus:** Defining models and integrating databases with MVC.  
**Topics Covered:**
- **Models:**  
  - Representing entities (e.g., Employee, Department).  
  - Using data annotations for validation (`[Required]`, `[StringLength]`).  
  - Implementing a generic repository for CRUD operations.  
- **Database Integration:**  
  - Setting up Entity Framework context and connection strings.  
  - Performing migrations to manage schema updates.  
- **Exercise:**  
  - Built a company management system with Add, View, Edit, Delete features.

---

### 🗓️ Day 13 – Partial Views, Models & JSON Rendering
**Focus:** Working with Partial Views, strongly typed Models, and JSON output.  
**Topics Covered:**
- **Partial Views & Layouts:**  
  - Created reusable UI components (`MovieCardPartial.cshtml`).  
  - Integrated Bootstrap for responsive design.  
- **Model Binding:**  
  - Defined `Movie` model and bound it to the view.  
- **JSON Output Button:**  
  - Implemented a button to toggle between HTML and JSON representations.

---

### 🗓️ Day 14 – MVC with Web API
**Focus:** Building a **Movie Management Application** using ASP.NET Core MVC with a separate **Web API** backend.  
**Highlights:**
- MVC frontend (`WebApp`) for UI and movie management.  
- Web API (`Day14_WebAPI`) for CRUD operations.  
- Partial views for dynamic movie rendering.  
- Connected MVC app with API for data handling.

---

### 🗓️ Day 15 – Identity & CRUD Operations
**Focus:** Integrating **ASP.NET Core Identity** for authentication with CRUD operations.  
**Highlights:**
- Authentication and Authorization using Identity.  
- CRUD for `Department` and `Employee` entities.  
- Features: Login, Two-Factor Authentication, Recovery Codes.  
- Data persistence using **Entity Framework Core** and migrations.

---

## 🏆 Final Hackathon Project
As a conclusion to the training, we participated in a **Hackathon Challenge**, applying all learned concepts to build a full ASP.NET application integrating:
- MVC + API  
- Entity Framework Core  
- Authentication with Identity  
- Real-world CRUD functionality

---

## 🧑‍💻 Author
**Ahmed Basem**  
💼 Full Stack Developer  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/ahmed-basem0104/)  
🔗 [GitHub Profile](https://github.com/Basem0)

---
