#include "Terrain.h"

Terrain::Terrain(int movementCost, bool isWater)
	:moveCost_(movementCost), isWater_(isWater)
{
}

Terrain::~Terrain()
{
}

int Terrain::getMoveCost() const
{
	return this->moveCost_;
}

bool Terrain::isWater() const
{
	return this->isWater_;
}

