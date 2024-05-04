// IQuoteRepository.h
#pragma once

#include <vector>
#include <Entities/Quote.h>

/**
 * Interface for the repository handling data operations for quotes.
 */
class IQuoteRepository {
public:
	virtual ~IQuoteRepository() {}

	/**
	 * Retrieves a quote by its unique identifier.
	 * @param id The ID of the quote to retrieve.
	 * @return The found Quote object, or an empty Quote if not found.
	 */
	virtual Quote findQuoteById(int id) = 0;

	/**
	 * Saves a new quote to the repository.
	 * @param quote The Quote object to save.
	 */
	virtual void saveQuote(const Quote& quote) = 0;

	/**
	 * Updates an existing quote in the repository.
	 * @param quote The Quote object with updated information to save.
	 */
	virtual void updateQuote(const Quote& quote) = 0;

	/**
	* Retrieves the next available unique identifier for a new quote.
	* This method ensures that each quote has a unique ID by incrementally increasing the last assigned ID.
	* @return The next unique ID as an integer.
	*/
	virtual int getNextID() = 0;

	/**
	 * Deletes a quote from the repository based on its ID.
	 * @param id The ID of the quote to delete.
	 */
	virtual void deleteQuote(int id) = 0;

	/**
	 * Retrieves all quotes currently stored in the repository.
	 * @return A vector containing all the quotes.
	 */
	virtual std::vector<Quote> retrieveAllQuotes() = 0;
};