# Introduction to .NET Forms In Class

## Initial setup
- Create a new MVC app called `BookAuthors`
- Add View compilation to `startup.cs`
  - `dotnet add package Microsoft.AspNetCore.MVC.Razor.RuntimeCompilation`
  ```services.AddControllersWithViews().AddRazorRuntimeCompilation();```
### Database Setup
- Add the required Entity Framework packages

- Create a model called `BookAuthor` with the following properties:
  - `id` - int
  - `FirstName` - string
  - `LastName` - string
  - `Active` - bool

- Create a `DbContext` called `BookAuthorContext` in new subdirectory called `Dao`
- Create a `DbSet` called `BookAuthors`
- Create a Sqlite configuration string in `appsettings.json` using
  ```
    "ConnectionStrings" : {
    "DefaultDBConnection" : "DataSource=BookAuthors.db"
  }
  ```
- Update the `startup.cs` file to include reference to created database context and connection string in the `ConfigurationServices` method
  
- Run the entity framework commands to:
  - Create Migrations
  - Apply migrations to the database
  - Use the Sqlite Plug-in to ensure the database was created

### Controllers and Views
- Create a new controller called `AuthorController`
- Create the following Actions/Endpoints and sanity check in PostMan
  - `ViewBookAuthor` that accepts an BookAuthor `id` and returns a specific BookAuthor or an error message
  - `ListBookAuthors` that returns all BookAuthors
  - `AddBookAuthor` that adds a new BookAuthor (HTTP POST)
- Add the database code to perform the required action 

- Create a corresponding View for each action accepting a model reference and then sanity check (NOTE: `AddBookAuthor` needs no model)
  - Modify the `ViewBookAuthor` view to display the BookAuthor details or an error if no BookAuthor matched
  - Modify the `ListBookAuthors` view to display a table of BookAuthor details of each BookAuthor or the message `No BookAuthors found` 
  
### Add BookAuthor Form
- Create a basic form in `AddBookAuthor`
  - `@Html.BeginForm`
  - `@Html.LabelFor`
  - `@Html.TextBoxFor`
  - `@Html.CheckBoxFor`
  - submit button
- Formatting
  - Use `new{}` to add attributes like `form-control`
    - Change checkbox for display (https://getbootstrap.com/docs/4.1/components/forms/)
    - Improve label names by using Model annotations
- Saving data with a bound model
  - Create second action `CreateBookAuthor` to accept a bound `BookAuthore` model
  - Save changes
- Using redirect

## Extra: Handling Model Errors
- Create a view model under `ViewModels` called `AddBookAuthorForm` that includes a `List<string> Errors` and an `BookAuthor` model reference
- Modify the `CreateBookAuthor` action so that if there are errors with the model, that it will redirect back to `AddBookAuthor` and pass in a view model instance
- Modify your `AddBookAuthor` view to display any errors with submission along with form (https://v4-alpha.getbootstrap.com/components/alerts/#examples)

### Error List Method
```
        public static List<string> GetErrorListFromModelState
                                              (ModelStateDictionary modelState)
        {
            var query = from state in modelState.Values
                        from error in state.Errors
                        select error.ErrorMessage;

            var errorList = query.ToList();
            return errorList;
        }
```        

