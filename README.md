# BookManager
# 📚 Library Management System

A robust, modern desktop application developed in **C#** and **.NET Framework (WinForms)** designed to streamline library inventory management. 

🏆 **Production-Ready:** This application is **currently deployed and actively used in two local libraries**, managing real-world inventory operations, tracking books, and generating daily reports.

## 🚀 Key Features

* **Dashboard Overview:** Real-time statistics showing total book count and total inventory value.
* **Inventory Management (CRUD):** Complete control to Add, Edit, and Delete books with strict input validation (Regex for pricing, data consistency).
* **Advanced Search:** Filter the database dynamically by Title, Author, Year, ID, or Price.
* **PDF Reporting:** * Custom-built PDF generator using **PdfSharp** (draws tables and headers programmatically).
  * Integrated PDF Viewer using **PdfiumViewer** for in-app print previews.
* **Custom UI:** Modern, borderless window design with custom navigation using **Win32 API Interop** and **FontAwesome** icons.
* **Database:** Powered by **SQLite** with a custom ADO.NET Data Access Layer for optimized queries.

## 🛠️ Tech Stack

* **Language:** C# (.NET Framework)
* **GUI:** Windows Forms (WinForms)
* **Database:** SQLite
* **Data Access:** ADO.NET (Custom DAL Wrapper)
* **Libraries:**
  * `PdfSharp` (Report Generation)
  * `PdfiumViewer` (Document Rendering)
  * `FontAwesome.Sharp` (UI/UX)
  * `System.Data.SQLite`

> **Technical Note:** A custom **ADO.NET** layer was implemented deliberately (instead of a full ORM) to maximize performance on low-spec library hardware and to demonstrate a deep understanding of raw SQL command execution and database interactions.

## 📸 Screenshots

| Add Book Form | Modify Book Form |
|:---:|:---:|
| ![Add Form Screenshot](https://github.com/StanislavPorcesco/BookManager/raw/main/Add%20Form.png) | ![Modify Form Screenshot](https://github.com/StanislavPorcesco/BookManager/raw/main/Modify%20Form.png) |

| PDF Report | Search Module |
|:---:|:---:|
| ![PDF Screenshot](https://github.com/StanislavPorcesco/BookManager/raw/main/Print%20Form.png) | ![Search Screenshot](https://github.com/StanislavPorcesco/BookManager/raw/main/Search%20Form.png) |

*(Note: Ensure image paths in the repository match these links)*

## 💻 Code Structure

The project follows a modular structure distinguishing between UI logic and Data logic:

* **Forms/:** Contains all UI elements (`AddForm`, `MenuForm`, `ImprimareForm`, etc.).
* **Data.cs:** A static wrapper class handling direct SQL connections, protecting the UI from raw database logic.
* **Entities:** Structured classes (e.g., `Carte.cs`) representing database models.

## 🚧 Roadmap / Future Improvements

* [ ] Migration to **.NET 8** and **WPF** for a more modern UI.
* [ ] Integration with a cloud database (Azure SQL) for remote access.
* [ ] Implementation of a **REST API** backend to support web clients.

## 🔧 Getting Started

1. Clone the repository.
2. Open the solution file (`.sln`) in **Visual Studio**.
3. Ensure NuGet packages are restored (PdfSharp, System.Data.SQLite, FontAwesome.Sharp).
4. Build and Run. *The SQLite database will be automatically accessed/created in the output directory.*

## 👤 Author

**Porcesco Stanislav**
* [LinkedIn Profile](https://www.linkedin.com/in/porcesco-stanislav/)
