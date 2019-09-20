# AvalaraCodeChallenge

## Introduction
This application allows for users to receive predicted precipitation amounts for 27612 Area Code for a given date.

## Notes For Reviewer
### Logic
All the logic within the application is within the Index.cshtml.cs file within the /Pages directory
### Testing
All the unit testing within the application is within the UniteTest1.cs file in the root directory

## Running the Application
### **NOTE**
Due to the data being stored within a local SQL database to effeciently run the applicaton the user must connect their own database containing the data to be utilized for the application

1. Install dependencies
If dotnet restore is not ran upon initially clone run:
```bash
dotnet restore
```
2. Run the application
```bash
dotnet run
```

##Final Thoughts
## Process
My approach to the challenge revolved around me creating a list of specific tasks that need to be completed. The list was as follows:
1. Import the provided data into SQL database
2. Figure out how to connect database with code
3. Figure out how to register click events within C#
4. Create logic for application
5. Learn C# unit testing and implement tests

## Reflection
This was my first introduction into C# and the .NET framework, as such, I was able to learn various aspects to the language/framework! While, I understand that some techniques I may have used may not be best practice for C#, however I feel just over this short project I increased my understanding of C# immensely!
