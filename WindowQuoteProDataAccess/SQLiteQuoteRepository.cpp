#include "pch.h"
#include "SQLiteQuoteRepository.h"


Quote SQLiteQuoteRepository::findQuoteById(int id) {
    Quote foundQuote;

    const char* sql = "SELECT * FROM Quotes WHERE ID = ?;";
    sqlite3_stmt* stmt;
    int rc = sqlite3_prepare_v2(db, sql, -1, &stmt, nullptr);
    if (rc == SQLITE_OK) {
        sqlite3_bind_int(stmt, 1, id);
        rc = sqlite3_step(stmt);
        if (rc == SQLITE_ROW) {
            const char* quoteName = reinterpret_cast<const char*>(sqlite3_column_text(stmt, 1));
            const char* customerName = reinterpret_cast<const char*>(sqlite3_column_text(stmt, 2));
            const char* doorMaterial = reinterpret_cast<const char*>(sqlite3_column_text(stmt, 3));
            const char* doorSize = reinterpret_cast<const char*>(sqlite3_column_text(stmt, 4));
            float price = sqlite3_column_int(stmt, 5);

            foundQuote = Quote(id, std::string(quoteName), std::string(customerName), to_DoorMaterial(doorMaterial), to_DoorSize(doorSize), price);
        }
        sqlite3_finalize(stmt);
    }
    else {
        //TODO: Handle SQL error (e.g., log and throw)
    }

    return foundQuote;
}

void SQLiteQuoteRepository::saveQuote(const Quote& quote) {
    const char* sql = "INSERT INTO Quotes (QuoteName, CustomerName, DoorMaterial, DoorSize, Price) VALUES (?, ?, ?, ?, ?);";
    sqlite3_stmt* stmt;
    int rc = sqlite3_prepare_v2(db, sql, -1, &stmt, nullptr);
    if (rc == SQLITE_OK) {
        sqlite3_bind_text(stmt, 1, quote.getQuoteName().c_str(), -1, SQLITE_STATIC);
        sqlite3_bind_text(stmt, 2, quote.getCustomerName().c_str(), -1, SQLITE_STATIC);
        sqlite3_bind_text(stmt, 3, to_string(quote.getDoorMaterial()).c_str(), -1, SQLITE_STATIC);
        sqlite3_bind_text(stmt, 4, to_string(quote.getDoorSize()).c_str(), -1, SQLITE_STATIC);
        sqlite3_bind_int(stmt, 5, quote.getPrice());

        rc = sqlite3_step(stmt);
        if (rc != SQLITE_DONE) {
            //TODO: Handle SQL error (e.g., log and throw)
        }
        sqlite3_finalize(stmt);
    }
    else {
        //TODO: Handle SQL error (e.g., log and throw)
    }
}

void SQLiteQuoteRepository::updateQuote(const Quote& quote) {
    const char* sql = "UPDATE Quotes SET QuoteName = ?, CustomerName = ?, DoorMaterial = ?, DoorSize = ?, Price = ? WHERE ID = ?;";
    sqlite3_stmt* stmt;
    int rc = sqlite3_prepare_v2(db, sql, -1, &stmt, nullptr);
    if (rc == SQLITE_OK) {
        sqlite3_bind_text(stmt, 1, quote.getQuoteName().c_str(), -1, SQLITE_STATIC);
        sqlite3_bind_text(stmt, 2, quote.getCustomerName().c_str(), -1, SQLITE_STATIC);
        sqlite3_bind_text(stmt, 3, to_string(quote.getDoorMaterial()).c_str(), -1, SQLITE_STATIC);
        sqlite3_bind_text(stmt, 4, to_string(quote.getDoorSize()).c_str(), -1, SQLITE_STATIC);
        sqlite3_bind_double(stmt, 5, quote.getPrice());
        sqlite3_bind_int(stmt, 6, quote.getQuoteID());

        rc = sqlite3_step(stmt);
        if (rc != SQLITE_DONE) {
            //TODO: Handle SQL error (e.g., log and throw)
        }
        sqlite3_finalize(stmt);
    }
    else {
        //TODO: Handle SQL error (e.g., log and throw)
    }
}

void SQLiteQuoteRepository::deleteQuote(int id) {
    const char* sql = "DELETE FROM Quotes WHERE ID = ?;";
    sqlite3_stmt* stmt;
    int rc = sqlite3_prepare_v2(db, sql, -1, &stmt, nullptr);
    if (rc == SQLITE_OK) {
        sqlite3_bind_int(stmt, 1, id);
        rc = sqlite3_step(stmt);
        if (rc != SQLITE_DONE) {
            //TODO: Handle SQL error (e.g., log and throw)
        }
        sqlite3_finalize(stmt);
    }
    else {
        //TODO: Handle SQL error (e.g., log and throw)
    }
}

std::vector<Quote> SQLiteQuoteRepository::retrieveAllQuotes()
{
    std::vector<Quote> quotes;
    const char* sql = "SELECT * FROM Quotes;";
    sqlite3_stmt* stmt;
    int rc = sqlite3_prepare_v2(db, sql, -1, &stmt, nullptr);
    if (rc == SQLITE_OK) {
        while (sqlite3_step(stmt) == SQLITE_ROW) {
            int id = sqlite3_column_int(stmt, 0);
            const char* quoteName = reinterpret_cast<const char*>(sqlite3_column_text(stmt, 1));
            const char* customerName = reinterpret_cast<const char*>(sqlite3_column_text(stmt, 2));
            const char* doorMaterial = reinterpret_cast<const char*>(sqlite3_column_text(stmt, 3));
            const char* doorSize = reinterpret_cast<const char*>(sqlite3_column_text(stmt, 4));
            float price = sqlite3_column_int(stmt, 5);

            Quote quote(id, std::string(quoteName), std::string(customerName), to_DoorMaterial(doorMaterial), to_DoorSize(doorSize), price);
            quotes.push_back(quote);
        }
        sqlite3_finalize(stmt);
    }
    else {
        //TODO: Handle SQL error (e.g., log and throw)
    }
    return quotes;
}