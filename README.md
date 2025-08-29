# ToDoAppAPI

API for managing tasks (ToDo) built with ASP.NET Core.

## How to Run Locally

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- (Optional) [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

### Steps

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd ToDoApp.Api
   ```

2. **Restore packages**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Access Swagger**
   Open your browser and go to:  
   [http://localhost:5176/swagger](http://localhost:5176/swagger)  
   *(Port may vary, check the console output when running the project)*

### Testing the API

Use Swagger UI to test endpoints or tools like Postman/cURL.

### Main Endpoints

- `GET /api/tasks` — List all tasks
- `POST /api/tasks` — Create a new task
- `PUT /api/tasks/{id}` — Update an existing task
- `DELETE /api/tasks/{id}` — Delete a task

---

## Project Structure

- `Controllers/` — API controllers
- `Models/` — Data models
- `DTOs/` — Data Transfer Objects
- `Services/` — Business logic

---

## Notes

- CORS is enabled for any origin (for development purposes only).
- Endpoint documentation is available via Swagger.

---

## License

This project is open-source and free to