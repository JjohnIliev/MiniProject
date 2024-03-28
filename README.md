# PC Gaming Club Management System

This project is a PC Gaming Club management system developed in C# using Windows Forms. It includes features for searching available PC gaming rooms, making bookings, and user authentication.

## Prerequisites

- .NET Framework
- SQL Server (LocalDB or Express edition)

## Installation

1. Clone or download the repository to your local machine.
2. Open the solution file (`Project2.sln`) in Visual Studio.
3. Build the solution to restore dependencies.
4. Set up the database by executing the SQL script provided (`database.sql`).
5. Update the connection string in the code files to match your SQL Server configuration.

## Usage

### Form1

- Form1 provides a search interface to find available PC gaming rooms based on specified criteria.
- Users can select the type of room, availability, and WiFi availability.
- Clicking the "Search" button retrieves matching rooms and displays them in a DataGridView.
- The "Book Now" button redirects the user to Form2 to make a booking.

### Form2

- Form2 allows users to make a booking for a selected PC gaming room.
- Users need to enter their name, phone number, and email address to complete the booking.
- Upon successful booking, the room's availability is updated, and a confirmation message is displayed.
- If the room is not available, an error message is shown.

### Form3

- Form3 provides a login interface for users to authenticate.
- Users need to enter their username and password.
- Clicking the "Login" button attempts to authenticate the user.
- If the authentication is successful, the user is redirected to Form1.
- If the authentication fails, an error message is displayed.

## Configuration

- Database connection strings are located in the code files and are hardcoded. Update the connection string to match your SQL Server instance.
- Ensure that the necessary SQL Server authentication and permissions are configured.
- Verify that the database schema includes the required tables (`PCGamingClub` and `UserCredentials`) with the appropriate structure.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
# MiniProject
