// SQLiteQuoteRepository.h
#pragma once

#include <Abstractions\IQuoteRepository.h>
#include <vector>
#include <string>

#ifdef WINDOWQUOTEPRODATAACCESS_EXPORTS
#define WINDOWQUOTEPRODATAACCESS_API __declspec(dllexport)
#else
#define WINDOWQUOTEPRODATAACCESS_API __declspec(dllimport)
#endif // WINDOWQUOTEPRODATAACCESS_EXPORTS

struct sqlite3;
/**
 * Concrete implementation of IQuoteRepository for interacting with an SQLite database.
 */
class SQLiteQuoteRepository : public IQuoteRepository {
private:
    sqlite3* db;
    std::string databaseFilename;

    /**
     * Initializes the database connection.
     */
    void initializeDatabase();

    /**
     * Ensures that the necessary database tables are created.
     */
    void createTablesIfNeeded();

public:
    /**
     * Constructor that accepts a database filename.
     * @param dbFilename The filename of the SQLite database.
     */
    WINDOWQUOTEPRODATAACCESS_API SQLiteQuoteRepository(const std::string& dbFilename) : databaseFilename(dbFilename) {
        initializeDatabase();
    }

    WINDOWQUOTEPRODATAACCESS_API ~SQLiteQuoteRepository();

    // Implement all methods from IQuoteRepository
    WINDOWQUOTEPRODATAACCESS_API Quote findQuoteById(int id) override;
    WINDOWQUOTEPRODATAACCESS_API void saveQuote(const Quote& quote) override;
    WINDOWQUOTEPRODATAACCESS_API void updateQuote(const Quote& quote) override;
    WINDOWQUOTEPRODATAACCESS_API void deleteQuote(int id) override;
    WINDOWQUOTEPRODATAACCESS_API std::vector<Quote> retrieveAllQuotes() override;
    WINDOWQUOTEPRODATAACCESS_API int getNextID() override;
};
