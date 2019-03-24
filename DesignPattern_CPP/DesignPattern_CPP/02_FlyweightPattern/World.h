#pragma once
#include "Terrain.h"

class World
{
public:
	World();
	virtual ~World();
	void generateTerrain();
	const Terrain& getTile(int x, int y) const;
private:
	const static unsigned int WIDTH = 55;
	const static unsigned int HEIGHT = 55;
	Terrain* tiles_[WIDTH][HEIGHT];
	Terrain grassTerrain_;
	Terrain hillTerrain_;
	Terrain riverTerrain_;
};

