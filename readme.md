## Backend Assignment:

Simple Todos on Board API The assignment involves the creation of a Todo on different boards via REST JSON API using ASP.NET Core. Please use the following libraries and versions:

   - ASP.NET Core 5.0+



## Todos on Board API:

We want to create RESTful APIs for a simple Todo management application. The APIs will perform CRUD operation for Todos and Boards. Todos are organized in boards, on every board there can be multiple Todos. A Todo contains a title (str), done (bool), a created (datetime) and updated (datetime) timestamp. A board has a name (str).



Via a REST API it must be possible to:

<!-- - List all boards  -->

API - https://localhost:7218/api/board

Method - GET




<!-- - Add a new board  -->

API - https://localhost:7218/api/board

Method - POST

Body:

{

    "boardname": {name Of Board}

}




<!-- - Change a board's title  -->

API - https://localhost:7218/api/board/{boardId}

Method - PUT

Body

{

    "id": {boardId},

    "boardname": "{new name}"

}



<!-- - Remove a board  -->

API - https://localhost:7218/api/board/{boardId}

Method - DELETE




<!-- - List all Todos on a board  -->

API - https://localhost:7218/api/todoitems/allTodosInBoard/{boardId}

Method - GET





<!-- - List only uncompleted Todos  -->

API - https://localhost:7218/api/todoitems/allincompletetodos




<!-- - Add a Todo to a board  -->

API - https://localhost:7218/api/todoitems



<!-- - Change a Todo's title or status  -->

API - https://localhost:7218/api/todoitems/{todoId}

** on patch request Done will set to false

so, Please send Done if it is true



<!-- - Delete a Todo  -->

API - https://localhost:7218/api/todoitems/{todoId}



User management and authentication is a plus. The data have to be persisted in SQL Server using EF Core.



## How to work on the assessment:

Clone this repository - https://github.com/cybergroupdevs/todoonboard-api



Start working on the assignment



Please do periodic commits with meaningful commit messages



Once you are done push your final results



Please include a brief description how to run your solution



If you have any questions contact me (lagnesh.thakur@cygrp.com)



Please note that any solution without periodic commits or inexecutable code will not be considered.