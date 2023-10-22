# T-shirt Customization App

## Table of Contents

- [About](#about)
- [Features](#features)
- [Requirements](#requirements)
- [Specifications](#specifications)
- [Installation](#installation)
- [Images](#images)
- [Version Control](#version-control)
- [Usage](#usage)
- [Contribution](#contribution)
- [License](#license)

## About

**T-shirt Customization App** is a web platform that simplifies the creation and customization of items. It allows users to list products, associate images based on colors and material types, and edit the details of each item.

## Features

- Item listing
- Item editing
- Adding images to items
- Viewing images associated with items
- Removing images associated with items
- Listing available colors for items
- Listing available materials for items

## Requirements

- .NET 6 SDK
- SQL Server 2019
- Visual Studio 2022 or VS Code
- SQL Server Management Studio

## Specifications

1. **Architecture**
   - Monolithic architecture
   - Layered architecture
   - REST API

2. **Used Design Patterns:**
   - Model View Controller (MVC)
   - Service Layer
   - Factory
   - Repository
   - Data Transfer Object (DTO)
   - Dependency Injection (DI)

3. **Applied Approaches:**
   - Clean Code
   - Single Responsibility Principle (SOLID)

4. **Adopted Languages/Frameworks:**
   - .NET 6 (C#)
   - ASP NET CORE
   - HTML/CSS/JavaScript

## Installation

1. **Installing the .NET 6 SDK:**
   - Download and install the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

2. **Installing SQL Server:**
   - If you don't have an instance of SQL Server, install the Express version from [this link](https://www.microsoft.com/en-us/download/details.aspx?id=101064).
   - Configure the instance according to your machine/server parameters.

3. **Creating the Database:**
   - Run the following script in SQL Server Management Studio or another tool of your choice:
     ```sql
     USE [master]
     GO

     CREATE DATABASE tsca_db
     ```

4. **Repository Cloning:**
   - Clone the repository to your machine.

5. **Connection String Configuration:**
   - In the "TShirtCustomizationApp\TShirtCustomizationApp.Repository" project, update line 19 with the connection string of your instance/database.

6. **Running Migrations:**
   - Open a terminal in the folder: `TShirtCustomizationApp\TShirtCustomizationApp.Repository`.
   - Run the `dotnet ef database update` command to apply the required migrations.

7. **Populating the database**
   - Execute the data.sql file to load the information into the database

8. **Running the Projects:**
   - Run the projects:
     - API: `TShirtCustomizationApp.API`
     - WEB: `TShirtCustomizationApp.Web`

## Images
![image](https://github.com/LiaAlexandre/TShirtCustomizationApp/assets/47008881/49113248-b3d9-4696-a56e-b6a80b539b54)
![image](https://github.com/LiaAlexandre/TShirtCustomizationApp/assets/47008881/cbd4de47-6e1d-455f-b7ce-09c6c82ab83c)


## Version Control

Git was used for version control and the GitHub platform. The 'Conventional Commits' commit message standard was adopted for clear and informative messages. A single 'main' branch is maintained to simplify development, which is ideal for projects with a single person actively contributing.

## License

[MIT License](https://opensource.org/license/mit/)
