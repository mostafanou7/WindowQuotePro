// IPricerService.h
#pragma once
#include "Enums.h"

/**
 * Interface for pricing services that determine the price of a door based on material and size.
 */
class IPricerService {
public:
    virtual ~IPricerService() {}

    /**
     * Retrieves the price for a given door material and size.
     * @param material The material of the door.
     * @param size The size of the door.
     * @return The price as an integer.
     */
    virtual float GetPrice(DoorMaterial material, DoorSize size) = 0;
};
