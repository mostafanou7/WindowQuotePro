// SQLiteQuoteRepository.h
#pragma once

#include "sqlite3/sqlite3.h"
#include "../WindowQuoteProBusinessLogic/IQuoteRepository.h"
#include <vector>
#include <string>

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
    void initializeDatabase() {
        int rc = sqlite3_open(databaseFilename.c_str(), &db);
        if (rc) {
            // Handle errors (e.g., log and throw)
        }
        else {
            createTablesIfNeeded();
        }
    }

    /**
     * Ensures that the necessary database tables are created.
     */
    void createTablesIfNeeded() {
        const char* sql = "CREATE TABLE IF NOT EXISTS Quotes ("
            "ID INTEGER PRIMARY KEY AUTOINCREMENT, "
            "QuoteName TEXT NOT NULL, "
            "CustomerName TEXT NOT NULL, "
            "DoorMaterial TEXT NOT NULL, "
            "DoorSize TEXT NOT NULL, "
            "Price BINARY_DOUBLE NOT NULL);";
        char* errMsg = nullptr;
        int rc = sqlite3_exec(db, sql, nullptr, nullptr, &errMsg);
        if (rc != SQLITE_OK) {
            // Handle SQL error (e.g., log and throw)
            sqlite3_free(errMsg);
        }
    }

public:
    /**
     * Constructor that accepts a database filename.
     * @param dbFilename The filename of the SQLite database.
     */
    SQLiteQuoteRepository(const std::string& dbFilename) : databaseFilename(dbFilename) {
        initializeDatabase();
    }

    ~SQLiteQuoteRepository() {
        sqlite3_close(db);
    }

    // Implement all methods from IQuoteRepository
    Quote findQuoteById(int id) override;
    void saveQuote(const Quote& quote) override;
    void updateQuote(const Quote& quote) override;
    void deleteQuote(int id) override;
    std::vector<Quote> retrieveAllQuotes() override;

};
