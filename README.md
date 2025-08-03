# 🎮 PRG182_Project_V2 – Loyalty Program Applicant Collector

A console-based C# application designed to collect, process, and validate customer information for a fictional loyalty-based credit qualification program. Built as a learning tool for arrays, input validation, and control flow.

---

## 📦 Features

- Collects detailed applicant information:
  - Name, age, arcade and bowling high scores
  - Employment status based on age
  - Slush Puppy flavor preference
  - Loyalty start date, pizza/slush consumption totals
- Stores entries in fixed-length arrays (up to 5,000 applicants)
- Performs credit qualification checks via `Validation.Credit_Qualification()`
- Supports continuous input with user-controlled looping
- Integrated menu navigation (via `OpenMenu.Get_Menu()` placeholder

---

## 📂 Data Storage

| Array Name        | Purpose                                  |
|------------------|-------------------------------------------|
| `ArrayUserDetails` | Stores all applicant detail strings       |
| `passCredit`      | Stores details of credit-qualified users  |
| `failCredit`      | Stores details of unqualified applicants  |

---

## 🖥️ Sample Input Flow

```plaintext
Enter your name:
Enter your age:
Enter your high score in arcade games:
Enter your starting date as a loyal customer (yyyy-mm-dd):
Enter total pizzas you consumed since first visit:
Enter your high score in bowling:
Are you (or your parents) currently employed? [yes/no]
Choose your Slush Puppy flavor (1–4):
Enter total slush puppies consumed:
Do you want to capture more applicants? [Y/N]
