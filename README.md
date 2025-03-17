---

![Clean Architecture Template Title](assets/Clean%20Architecture%20Template%20Title.png)

---

# 🏋️‍♂️ GymManagement

Welcome to **GymManagement**! This is a C# application designed to exercise **Clean Architecture** principles.



## 📋 Table of Contents

- [Tech Stack](#tech-stack)
- [Domain Overview 🌍](#domain-overview-)
- [Use Cases / Features 🤓](#use-cases--features-)
- [Getting Started 🏃](#getting-started-)
- [Usage](#usage)
- [Contributing](#contributing)


## 🏗️ Tech Stack

- **C#** (.NET Core)
- **Entity Framework Core** (SQLite)
- **ASP.NET Core** (for web API)

## Domain Overview 🌍

This is a simple reminder application. It allows users to create and manage their reminders.

To create reminders, a user must have an active subscription.

## Basic Subscription

Users with a basic subscription can create up to 3 daily reminders.

## Pro Subscription

Users with a pro subscription do not have a daily limit on the number of reminders.

## Use Cases / Features 🤓

## Subscriptions

1. Create Subscription
1. Get Subscription
1. Cancel Subscription

## Reminders

1. Set Reminder
1. Get Reminder
1. Delete Reminder
1. Dismiss Reminder
1. List Reminders

# Folder Structure 📁

![Folder structure](assets/Clean%20Architecture%20Template.png)

## Getting Started 🏃

To set up the project locally:

1. **Clone the repository**:

   ```bash
   git clone https://github.com/kiranm03/GymManagement.git
   ```

2. **Navigate to the project directory**:

   ```bash
   cd GymManagement
   ```

3. **Install dependencies**:

   ```bash
   dotnet restore
   ```

4. **Set up the database**:

   ```bash
   dotnet ef database update
   ```

   Ensure you have **.NET SDK** installed and the `Microsoft.EntityFrameworkCore.Sqlite` package configured.

5. **Run the application**:

   ```bash
   dotnet run
   ```

## 🚀 Usage

- The application will start and be accessible via the specified URL.
- Use the interface (if provided) or API endpoints to manage gym operations.

## 🤝 Contributing

We welcome contributions! To get started:

1. **Fork the repository**.
2. **Create a new branch**:
   ```bash
   git checkout -b feature/YourFeatureName
   ```
3. **Make your changes**.
4. **Commit your changes**:
   ```bash
   git commit -m 'Add some feature'
   ```
5. **Push to the branch**:
   ```bash
   git push origin feature/YourFeatureName
   ```
6. **Open a pull request**.

Please ensure your code adheres to Clean Architecture principles and follows best practices.

## Credits 🙏

- [CleanArchitecture](https://github.com/jasontaylordev/CleanArchitecture) - An awesome clean architecture solution template by Jason Taylor
---

Made with ❤️ by [kiranm03](https://github.com/kiranm03)

