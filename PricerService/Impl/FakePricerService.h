// PricerService.h
#pragma once

#include <Abstractions/IPricerService.h>
#include <Entities/Enums.h>
#include <random>

/**
 * Implements the IPricerService interface to provide pricing based on door material and size.
 */
class FakePricerService : public IPricerService {
public:
    double GetPrice(DoorMaterial material, DoorSize size) override {
        // For simplicity, generate a random price. In a real scenario, this could query an external service or database.
        std::random_device rd;
        std::mt19937 gen(rd());
        std::uniform_int_distribution<> dis(1, 100);

        return dis(gen);  // Returns a random price between 1 and 100
    }
};
