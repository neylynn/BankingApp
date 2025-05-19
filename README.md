# OldPhonePadApp

[![.NET Build and Test](https://github.com/neylynn/OldPhonePadApp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/neylynn/OldPhonePadApp/actions)

A C# console app simulating an old mobile phone keypad.

## Structure
- `Program.cs` : Console UI
- `OldPhonePadService.cs` : Business logic (key decoding)
- `OldPhonePadApp.Tests` : xUnit tests

## Features
- from Old Phone Pad's key input to desire result for text messaging
- can test app in local 
- using github's test automation feature after push 

## Technologies
- .NET (specify version: .NET 8.0)

## Installation
```bash
# Clone the repository
git clone https://github.com/neylynn/OldPhonePadApp.git

# Change into the directory
cd OldPhonePadApp

# Build the project
dotnet build

# Run the app [go to /OldPhonePadApp]
dotnet run

# Test the app [go to /OldPhonePadApp.Tests]
dotnet test



