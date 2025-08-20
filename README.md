# 🎮 Loyalty Program Applicant Collector

A robust console-based C# application for gathering and validating customer data in a fictional loyalty-based credit qualification program. Ideal for beginners learning arrays, input validation, control flow, and basic data processing in .NET. Collect up to 5,000 applicant entries, perform credit checks, and manage data with ease—all from your terminal.

## 🚀 Overview

This app simulates a loyalty program enrollment system, capturing detailed user information like names, scores, preferences, and consumption history. It validates inputs, qualifies applicants for credit, and stores data in arrays for efficient handling. Perfect for educational purposes or as a foundation for more complex CLI tools in C#.

## 🔍 How It Works

1. **User Input Collection**: Prompts for applicant details in a guided sequence, including name, age, high scores, employment status, flavor preferences, and more.
2. **Validation and Processing**: Uses custom validation methods (e.g., `Validation.Credit_Qualification()`) to check eligibility and ensure data integrity.
3. **Data Storage**: Stores entries in arrays like `ArrayUserDetails` for all applicants, with separate arrays (`passCredit` and `failCredit`) for qualified and unqualified users.
4. **Looping and Navigation**: Supports continuous input via user-controlled loops and integrates a menu system (via `OpenMenu.Get_Menu()` placeholder for extensibility).
5. **Output**: Displays collected data and qualification results in the console.

## ✨ Key Features

- **Comprehensive Data Collection**: Handles a wide range of inputs, from personal details to loyalty metrics like pizza and slush consumption.
- **Input Validation**: Ensures accurate data with checks for age-based employment, date formats, and numeric ranges.
- **Array-Based Storage**: Efficiently manages up to 5,000 applicants using fixed-length arrays for scalability in a console environment.
- **Credit Qualification Logic**: Applies rules to determine credit eligibility and segregates results into pass/fail categories.
- **User-Friendly Looping**: Allows multiple applicant entries in one session with a simple Y/N prompt.
- **Menu Integration**: Placeholder for expandable menu navigation to enhance usability.
- **Error Handling**: Gracefully manages invalid inputs to prevent crashes.

## 🛠️ Tech Stack

- **Language & Framework**: C# (.NET Console Application)
- **Core Concepts**: Arrays, loops, conditional statements, input validation, and basic methods.
- **Libraries**: Standard .NET libraries (e.g., `System` for console I/O and date parsing).

## 📋 Prerequisites

- .NET SDK (version 6.0 or later) installed on your machine.
- Basic knowledge of C# for running and modifying the code.

## ⚙️ Installation & Usage

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/loyalty-program-app.git
   cd loyalty-program-app
   ```

2. Restore dependencies (if any):
   ```bash
   dotnet restore
   ```

3. Run the app:
   ```bash
   dotnet run
   ```

   Sample Input Flow:
   ```
   Enter your name: John Doe
   Enter your age: 25
   Enter your high score in arcade games: 1500
   Enter your starting date as a loyal customer (yyyy-mm-dd): 2023-01-15
   Enter total pizzas you consumed since first visit: 45
   Enter your high score in bowling: 200
   Are you (or your parents) currently employed? [yes/no]: yes
   Choose your Slush Puppy flavor (1–4): 2
   Enter total slush puppies consumed: 30
   Do you want to capture more applicants? [Y/N]: N
   ```

   The app will process the data, perform credit checks, and store results accordingly.

## 📂 Data Storage Overview

| Array Name        | Purpose                              | Capacity |
|-------------------|--------------------------------------|----------|
| `ArrayUserDetails` | Stores all applicant detail strings | 5,000   |
| `passCredit`      | Stores details of credit-qualified users | Variable |
| `failCredit`      | Stores details of unqualified applicants | Variable |

## 🤝 Contributing

Contributions are encouraged! Submit pull requests for enhancements, bug fixes, or new features. Include clear descriptions and follow C# best practices.
