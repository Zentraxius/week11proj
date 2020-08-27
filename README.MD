# Pierre's Sweet and Savory!

#### A quick website for Pierre to help make his life better

#### By Cody Fritz

[SweetAndSavory-Solution](https://github.com/Zentraxius/week11proj)

## Description

A website specially made for Pierre to help manage his products flavors!

## Setup/Installation Requirements

- To clone this content, copy the url provided by the 'clone or download' button in GitHub
- In command line use the command 'git clone https://github.com/Zentraxius/week9proj'
- Open the program in a code editor (Using VisualStudioCode for reference)
- You will need [.NET](https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program
- Then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
- Type dotnet build in the command line to compile the code
- Create a .gitignore file and store the bin and obj folders in .gitignore
- Type dotnet run in the command line to run the program, ensuring you are in the SweetAndSavory.solution/SweetAndSavory directory

- Run `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0` &
  `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
  in the terminal
- Add a file called `appsetting.json` in the SweetAndSavory directory.
- In `appsetting.json` add ![appsetting.json](Assets/setup.png)
- Fill in your `server`, `port`,`database`,`uid`, and `pwd`

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=DatabaseNameHere;uid=YourUserNameHere;pwd=YourPasswordHere;"
  }
}
- Here is an easy to use template

# Database Instructions

DROP DATABASE IF EXISTS `Cody_Fritz`;
In MySqlWorkbench

## Importing the provided Database

0. These instructions are assuming you have already downloaded the project and can open it in a proper editor such as VisualStudioCode
1. Copy the file cody_fritz.sql from the SweetAndSavory.solution/SweetAndSavory/cody_fritz.sql location
2. Place in easily accessible folder of your choice, in this example we will use desktop
3. Open a database manager, in this case we will use MySql Workbench
4. From the "Navigator" tab, and the "Administration" sub-tab, we will click on Data Import/Restore
5. Select Import from Self-Contained-File and navigate to the desktop, select the file cody_fritz.sql.
6. Select Start Import.

## Making your own Database
0. These instructions are assuming you have already downloaded the project and can open it in a proper editor such as VisualStudioCode
1. In the terminal type `dotnet ef migrations add {name}` It is standard practice to do "Initial" as the first, which has already been done. 
2. In this example, `dotnet ef migrations add CodeReview` as this has not been used yet
3. Now, you can run `dotnet ef database update` to automatically update and create the database to your MySqlWorkbench.
4. The database is named `cody_fritz` by default, this can be changed in the appsettings.json as mentioned above. 

## Specs

| Behavior     | Input                         | Output                                    |
| ------------ | ----------------------------- | ----------------------------------------- |
| Add a Treat  | User selects to add new Treat | New Treat is added and updated to website |
| Add a Flavor | User adds a Flavor to a Treat | Website reflects Flavor for Treat         |

## Known Bugs

_No known bugs_

## Support and contact details

Cody Fritz <clanalia55@gmail.com>

## Technologies Used

_The Technologies used in the making of this software was Chrome browser, Visual Studio editor, Windows 10, C#, .Net_

### License

Copyright (c) 2020 **Cody Fritz**

MIT License
