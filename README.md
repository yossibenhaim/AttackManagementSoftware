# IDF Attack Management Software

This is a simulation-based C# project designed to model an attack management system for the IDF (Israel Defense Forces). It includes modules for tracking terrorists, evaluating threat levels, and selecting suitable weapons based on real-time intelligence.

## 🔧 Technologies

- Language: C#
- Environment: .NET Core / Visual Studio
- Project Type: Console Application

## 📁 Project Structure

```
attack_management_software/
│
├── IDF.cs                  # Main controller class for coordinating tools, intelligence, and attacks
├── Attack.cs               # Responsible for selecting the correct attack tool
├── IntelligenceDivision.cs # Handles search and analysis of terrorist threats
├── ListAllTerrorist.cs     # Generates and stores terrorist profiles
├── Weapons.cs              # Weapon data and functionality
├── IAttackTool.cs          # Interface for all attack tools (currently only Weapons)
└── Terrorist.cs            # Model class for a terrorist entity
```

## 🧠 Main Features

- **Terrorist Generator**: Creates multiple terrorists with random attributes like name, location, weapon type, and danger level.
- **Intelligence Module**: Searches for terrorists by name and identifies the most dangerous one.
- **Attack Module**: Selects a suitable weapon based on the terrorist's current location.
- **Weapons System**: Stores information about each weapon, including attack and gas usage counters.
- **Interface Usage**: `IAttackTool` allows support for future tools beyond weapons.

## ▶️ How to Run

1. Clone or download the repository.
2. Open the project in Visual Studio or Rider.
3. Set the `Program.cs` (if available) to call `IDF.print()` after initializing the system.
4. Build and run the solution.

```csharp
// Example initialization (you may add to Program.cs or Main):
var tolls = new tolls(); // Make sure to initialize with weapons
var terrorists = new ListAllTerrorist();
terrorists.Terrorist_creator();
var idf = new IDF(tolls, terrorists);
idf.print();
```

## ✅ Future Improvements

- Add GUI using WinForms or WPF.
- Store terrorists and weapons in a database (e.g. SQLite).
- Add more types of attack tools (e.g. drones, snipers).
- Improve randomness and realism in terrorist generation.
- Add unit testing using NUnit or xUnit.

## 📜 License

This project is for educational and training purposes only.