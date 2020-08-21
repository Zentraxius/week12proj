# Animal Shelter API

#### _API building project for Epicodus, 08.21.2020_

#### By _**Cody Fritz**_

## Description

_An API that allows users to view and see local animal shelter info._

## Specifications

| Behavior                                              |                      Input                      |                                  Output | Met? (Y/N) |
| ----------------------------------------------------- | :---------------------------------------------: | --------------------------------------: | ---------: |
| Check Local Shelter occupants without an adoption fee | http://localhost:5000/api/animals?adoptionfee=0 | API returns list of animals with no fee |   Y        |

## Setup/Installation Requirements

There are multiple ways to query the API. To search by username or a specific adoptionfee(0 for example), add the parameter(s) after `animals?` like so: `http://localhost:5000/api/animals?username=kate&adoptionfee=0`. Use an ampersand(&) to separate parameters.

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
