// QuoteManager.h
#pragma once

#include <vector>
#include <memory>
#include <Entities/Quote.h>
#include "../Abstractions/IPricerService.h"
#include "../Abstractions/IQuoteRepository.h"

/**
 * Manages quote operations such as creation, retrieval, update, and deletion.
 */
class QuoteManager {
private:
    IPricerService* pricerService{};
    IQuoteRepository* quoteRepository{};

public:
    /**
     * Constructor that initializes the QuoteManager with necessary services.
     * @param service Pointer to an object that implements IPricerService.
     * @param repository Pointer to an object that implements IQuoteRepository.
     */
    QuoteManager(IPricerService* service, IQuoteRepository* repository)
        : pricerService(service), quoteRepository(repository) {}

    ~QuoteManager()
    {
        if (!pricerService)
        {
            delete pricerService;
            pricerService = nullptr;
        }
        if (!quoteRepository)
        {
            delete quoteRepository;
            quoteRepository = nullptr;
        }
    }
    /**
     * Creates a new quote with the provided details, calculates its price, and saves it.
     * @param quoteName Name of the quote.
     * @param customerName Name of the customer.
     * @param material Door material.
     * @param size Door size.
     * @return A fully populated Quote object including the price.
     */
    Quote createQuote(const char* quoteName, const char* customerName, DoorMaterial material, DoorSize size) {
        double price = pricerService->GetPrice(material, size);
        Quote newQuote(quoteRepository->getNextID(), quoteName, customerName, material, size, price);
        quoteRepository->saveQuote(newQuote);
        return newQuote;
    }

    /**
     * Retrieves a quote by its ID.
     * @param id The ID of the quote to retrieve.
     * @return The requested Quote object, or an empty Quote if not found.
     */
    Quote getQuote(int id) {
        return quoteRepository->findQuoteById(id);
    }

    /**
     * Updates an existing quote with new details.
     * @param quote The quote with updated details to save.
     * @return A boolean indicating if the update was successful.
     */
    bool updateQuote(const Quote& quote) {
        if (quoteRepository->findQuoteById(quote.getQuoteID()).getQuoteID() != 0) {
            quoteRepository->updateQuote(quote);
            return true;
        }
        return false;
    }

    /**
     * Deletes a quote by its ID.
     * @param id The ID of the quote to delete.
     * @return A boolean indicating if the deletion was successful.
     */
    bool deleteQuote(int id) {
        if (quoteRepository->findQuoteById(id).getQuoteID() != 0) {
            quoteRepository->deleteQuote(id);
            return true;
        }
        return false;
    }

    /**
     * Retrieves all quotes in the system.
     * @return A vector of Quote objects.
     */
    std::vector<Quote> getAllQuotes() {
        return quoteRepository->retrieveAllQuotes();
    }

};