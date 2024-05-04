// Quote.h
#pragma once

#include <string>
#include "Enums.h"

/**
 * Represents a quotation for a window including details such as customer name, material, and size.
 */
class Quote {
private:
	int quoteID {};
	std::string quoteName {};
	std::string customerName {};
	DoorMaterial doorMaterial {};
	DoorSize doorSize {};
	double price {};

public:
	//Default costructor
	Quote() {};

	/**
	 * Constructs a new Quote object with detailed parameters.
	 * @param id Unique identifier for the quote.
	 * @param qName Name of the quote.
	 * @param cName Name of the customer.
	 * @param material Material of the door.
	 * @param size Size of the door.
	 * @param p Price of the quote.
	 */
	Quote(int id, std::string qName, std::string cName, DoorMaterial material, DoorSize size, double p)
		: quoteID(id), quoteName(qName), customerName(cName), doorMaterial(material), doorSize(size), price(p) {}

	// Getters
	int getQuoteID() const { return quoteID; }
	const std::string& getQuoteName() const { return quoteName; }
	const std::string& getCustomerName() const { return customerName; }
	DoorMaterial getDoorMaterial() const { return doorMaterial; }
	DoorSize getDoorSize() const { return doorSize; }
	double getPrice() const { return price; }

	// Setters
	void setQuoteID(int id) { quoteID = id; }
	void setQuoteName(const char* qName) { quoteName = qName; }
	void setCustomerName(const char* cName) { customerName = cName; }
	void setDoorMaterial(DoorMaterial material) { doorMaterial = material; }
	void setDoorSize(DoorSize size) { doorSize = size; }
	void setPrice(double p) { price = p; }
};
