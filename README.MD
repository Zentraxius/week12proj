# Animal Shelter API

#### _API building project for Epicodus, 08.21.2020_

#### By _**Cody Fritz**_

## Description

_An API that allows users to view and see local animal shelter info._

- This api allows you to view and paginate through the different animals looking for a home in this shelter.
- Using pagination, you can further filther your results using search functions such as pages?/pageNumber=1&pageSize=2 this would give you only the top 2 results, due to pageSize=2
- With this you can browse through all of the lovely animals available and filter out those that don't have what you're looking for, or only look for the best!

## Specifications

| Behavior                           |                              Input                               |                                               Output | Met? (Y/N) |
| ---------------------------------- | :--------------------------------------------------------------: | ---------------------------------------------------: | ---------: |
| Check Local Shelter occupants      |                http://localhost:5000/api/animals                 | API returns list of animals starting from lowest fee |          Y |
| Check shelter api using Pagination |         http://localhost:5000/api/animals?adoptionfee=50         |    Returns animals with an adoption fee of "only" 50 |          Y |
| Check only the top 3 results       | http://localhost:5000/api/animals/pages?/pageNumber=1&pageSize=3 |          Returns the top 3 animals due to pagination |          Y |

## Setup/Installation Requirements

- To clone this content, copy the url provided by the 'clone or download' button in GitHub
- In command line use the command 'git clone https://github.com/Zentraxius/week12proj'
- Open the program in a code editor (Using VisualStudioCode for reference)
- You will need [.NET](https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program
- Then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
- Type dotnet build in the command line to compile the code
- Create a .gitignore file and store the bin and obj folders in .gitignore
- Type dotnet run in the command line to run the program, ensuring you are in the AnimalShelterApi.solution/animalshelterapi directory

- Run `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0` &
  `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
  in the terminal
- Add a file called `appsetting.json` in the AnimalShelterApi directory.
- Fill in your `server`, `port`,`database`,`uid`, and `pwd`
- Template for appsettings.json provided below
  {
  "ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Port=3306;database=DatabaseNameHere;uid=YourUserNameHere;pwd=YourPasswordHere;"
  }
  }

## Importing the provided Database

0. These instructions are assuming you have already downloaded the project and can open it in a proper editor such as VisualStudioCode
1. Copy the file cody_fritz.sql from the AnimalShelterApi.solution/AnimalShelterApi/cody_fritz.sql location
2. Place in easily accessible folder of your choice, in this example we will use desktop
3. Open a database manager, in this case we will use MySql Workbench
4. From the "Navigator" tab, and the "Administration" sub-tab, we will click on Data Import/Restore
5. Select Import from Self-Contained-File and navigate to the desktop, select the file cody_fritz.sql.
6. Select Start Import.

There are multiple ways to query the API. To search by username or a specific adoptionfee(0 for example), add the parameter(s) after `animals?` like so: `http://localhost:5000/api/animals?animalid=1&adoptionfee=0`. Use an ampersand(&) to separate parameters.

To search by page and/or to limit the number of results per page, add `pages?` after `animals/`, then specity the pageNumber (which page you would like to see) and pageSize (how many results you would like per page. Here is an example query: `http://localhost:5000/api/animals/pages?pageNumber=2&pageSize=8`. If pageSize is not specified, the default number of results per page is 10.

## Support and contact details

_Please feel free to contact the authors through GitHub (Zentraxius) with any feedback, questions or concerns._

## Technologies Used

- Entity Framework Core
- .NET Core CLI
- ASP.NET Core Identity
- ASP.NET Core MVC
- .NET Core 2.2
- MySQL & MySQL Workbench
- C#
- Razor
- Visual Studio Code
- Git Version Control
- GitHub

### License

_This site is licensed under the MIT license._

Copyright (c) 2020 Cody Fritz
