# console-phonebook
Simple console phonebook

To run app:
 1) start project using VS 2019.
 2) execute "dotnet restore" command
 3) to run console-app set 'Phonebook.Console' as Startup Project
 3) to run web-app set 'Phonebook.WebApi' as Startup Project
  - send post request to 'http://localhost:9080/api/command/execute'
  - request body:
  ```json
  {
    "input": "add newContact +199999999"
  }
  ```
 
 Supporting commands:
  - add - format 'add {name} {phone}'
  - list
  - help

To add new command need to do the following:
 - Create implementation of ICommand;
 - Add attribute CommandAttribute to the implementation.
