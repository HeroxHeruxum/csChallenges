# csChallengesC# Coding Challenges (Beginner to Expert)

Your Java experience will help you transition smoothly into C#. These challenges are categorized from beginner to expert level.

🔰 Beginner Level

1. Palindrome Checker

Task: Check if a string is a palindrome (ignoring case and non-alphanumeric characters).

Input: "A man, a plan, a canal: Panama"

Output: true

2. FizzBuzz

Task: Print numbers 1 to 100. For:

Multiples of 3: print "Fizz"

Multiples of 5: print "Buzz"

Multiples of both: print "FizzBuzz"

3. Factorial with Recursion

Task: Write a recursive method to calculate the factorial of a number.

4. LINQ Filter

Task: Return all even numbers using LINQ.

Input: [1, 2, 3, 4, 5, 6]

Output: [2, 4, 6]

5. String Reversal

Task: Reverse a given string without using built-in reverse methods.

⚙️ Intermediate Level

6. Custom Extension Method

Task: Create an extension method ToTitleCase() that capitalizes the first letter of each word.

Input: "hello world"

Output: "Hello World"

7. Dependency Injection Practice

Task: Create services IMailer and INotifier. Inject IMailer into Notifier and simulate sending an email.

8. Bank Account Class with Interface

Task: Create an IBankAccount interface and implement it in a SavingsAccount class. Support Deposit() and Withdraw().

9. Use async/await

Task: Fetch data from a web API using HttpClient with async/await.

10. JSON Parsing

Task: Parse a JSON file representing users into C# objects using System.Text.Json.

🚀 Advanced Level

11. Design a Plugin System

Task: Use reflection to load and run classes from separate assemblies that implement an interface IPlugin.

12. Generic Repository Pattern

Task: Implement a generic IRepository<T> for CRUD operations using Entity Framework Core.

13. Middleware in ASP.NET Core

Task: Write custom middleware that logs request URLs and execution time.

14. Use Records and Pattern Matching

Task: Create immutable models with record types. Use pattern matching to handle logic based on object state.

15. Implement a Caching Layer

Task: Implement a service that uses MemoryCache to cache expensive computations temporarily.

🧠 Bonus: Code Golf Challenge

One-liner

Task: Write the shortest C# method to check if a number is a power of two.

bool IsPowerOfTwo(int n) => n > 0 && (n & (n - 1)) == 0;
