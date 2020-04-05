# console-phonebook
Simple console phonebook

To run app:
 - start project using VS 2019.
 - execute "dotnet restore" command
 
 Supporting commands:
  - add - format 'add {name} {phone}'
  - list
  - help

To add new command need to do the following:
 - Create implementation of ICommand;
 - Add attribute CommandAttribute to the implementation.
