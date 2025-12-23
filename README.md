# Book Management System (OOP Basics)

A simple C# Console Application demonstrating the fundamental concepts of **Object-Oriented Programming (OOP)**, specifically focusing on classes, constructors, and field encapsulation.

## 📌 Features
- **Class Implementation**: Includes a `Book` class with fields for Title, Author, and Price.
- **Constructors**: 
  - **Default Constructor**: Initializes books with default values ("Untitled", "Unknown", 0.0).
  - **Parameterized Constructor**: Allows dynamic object creation with specific data.
- **Method**: A `DisplayInfo()` method to format and print object data to the console.

## 🚀 How to Run
1. Ensure you have the **.NET SDK** installed.
2. Clone this repository:
   ```bash
   git clone [https://github.com/YourUsername/BookClass-CSharp.git](https://github.com/YourUsername/BookClass-CSharp.git)

   // Example of creating a book with specific details
Book book2 = new Book("C# Programming", "John Doe", 29.99);
book2.DisplayInfo();
