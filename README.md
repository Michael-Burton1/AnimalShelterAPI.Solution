# Animal Shelter API

#### By Michael Burton

#### This is a project where I built my first simple API. It is an API for an animal shelter that contains different pets that are in the database. This API has full CRUD funtionallity and uses Swagger to show documentation for all the endpoints.

## Technologies Used

* VS Code
* C#
* .NET 5 SDK framwork
* Swagger
* MySql
* MySQL Workbench


### Prerequisites

* .NET 5 SDK
* A text editor like VS Code
* A command line interface like Terminal or GitBash to run and interact with the console app.
[MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
* Postman or another program to test API calls

### Installation

1. Clone this repository: $ git clone https://github.com/Michael-Burton1/AnimalShelterAPI.Solution.git
2. Navigate to the AnimalShelyterAPI.solution directory on your computer
3. Open with your preferred text editor to view the code 
4. Set up Sql Database using MySQL:
    * Make an appsettings.json file in the Shelter directory of the project.
    * Add this to your Appsettings.json file


 > {<br>
    > "ConnectionStrings": { <br>
  >  "DefaultConnection": "Server=localhost;Port=3306; database=michael_burton;uid=root;pwd=[YOUR PASSWORD];"<br>
 >   }<br>
  >}

* replace [YOUR PASSWORD] with your MySQL password
Open terminal and run this command with your MySQL password replacing [YOUR PASSWORD] : mysql -uroot -p[YOUR PASSWORD]
* Then type in this command to build the database in MySQL Workbench
    * Dotnet ef database update


5. To run the app:
  * Navigate to the {Shelter} directory in your command line
  * Run the command: dotnet restore 
  to restore the dependencies that are listed in {Shelter.csproj}
  * Run the command: dotnet build   to build the project and its dependencies   
  * Finally, run the command: dotnet run   to run the project!

## Swagger
This project impliments the use of swagger which allows you to see the documentation of all the endpoints in my API 
  to view documentation for the end points you just need to do the following:
  * Make sure the program is running using the commands listed above
  * navigate to localhost 5000/Swagger in your browser


## Known Bugs

* No known bugs

## License

_Licensed under the [MIT License](LICENSE)._

## Contact Information

_Michael Burton (micbur1@gmail.com)_