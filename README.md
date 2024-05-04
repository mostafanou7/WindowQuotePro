# WindowQuotePro

WindowQuotePro is a simple CRUD application that leverages C++ in the backend, powered by SQLite3 for efficient data management. On the frontend, it harnesses the versatility of WinForms in C#, meticulously crafted in Microsoft Visual Studio. To seamlessly bridge the communication gap between the frontend and backend, an interop layer is meticulously engineered using the COM IUnknown interface, ensuring smooth data exchange and enhanced user experience.

## Features

- Create quotes with various configurations.
- View all quotes with details.
- Edit or delete existing quotes.

## File Structure

The repository is organized as follows:

- `WindowQuoteProCommon`: Contains enterprise-wide business rules and data, including the Quote entity.
- `WindowQuoteProBusinessLogic`: Contains application-specific business rules and logic, including the QuoteManager.
- `WindowQuoteProDataAccess`: Contains concrete implementations of data repositories, such as SQLiteQuoteRepository.
- `WindowQuoteProGUI`: GUI component using WinForms for interacting with the application.
- `PricerService`: Fake pricer service to simulation the pricing process.
- `sqlite3`: Third-party SQLite library for database operations.

## How to Run

1. Clone the repository to your local machine:

   ```git clone https://github.com/mostafanou7/WindowQuotePro.git```

3. Open the project in Microsoft Visual Studio.

4. Build the solution.

5. Set `WindowQuoteProGUI` as startup project and run the application.

## Dependencies

- Microsoft Visual Studio
- SQLite database library

## Contributing

Contributions are welcome! If you find any bugs or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
