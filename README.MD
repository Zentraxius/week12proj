# Animal Shelter API

#### _API building project for Epicodus, 08.21.2020_

#### By _**Cody Fritz**_

## Description

_An API that allows users to view and see local animal shelter info._

## Specifications

| Behavior | Input | Output | Met? (Y/N) |
| -------- | :---: | -----: | ---------: |
|          |       |        |            |

## Stretch Goals

| Behavior | Input | Output | Met? (Y/N) |
| -------- | :---: | -----: | ---------: |


## User Stories

As a user, I want to GET and POST reviews about travel destinations.
As a user, I want to GET reviews by country or city.
As a user, I want to see the most popular travel destinations by number of reviews or by overall rating.
As a user, I want to PUT and DELETE reviews, but only if I wrote them. (Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)
As a user, I want to look up random destinations just for fun.

## Setup/Installation Requirements

There are multiple ways to query the API. To search by username or a specific rating(1-5), add the parameter(s) after `places?` like so: `http://localhost:5000/api/places?username=kate&rating=5`. Use an ampersand(&) to separate parameters.



To search by page and/or to limit the number of results per page, add `pages?` after `places/`, then specity the pageNumber (which page you would like to see) and pageSize (how many results you would like per page. Here is an example query:  `http://localhost:5000/api/places/pages?pageNumber=2&pageSize=8`. If pageSize is not specified, the default number of results per page is 10.

## Known Bugs

| Bug : Message | Situation | Resolved (Y/N) | How was the issue resolved? |
| ------------- | --------- | -------------- | --------------------------- |
|               |           |                |                             |

## Support and contact details

_Please feel free to contact the authors through GitHub (LINDGRENBA)(kate-skorija)(Zentraxius) with any feedback, questions or concerns._

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

Copyright (c) 2020 \_{BrittanyLindgren, Kate Skorija, and Cody Fritz
