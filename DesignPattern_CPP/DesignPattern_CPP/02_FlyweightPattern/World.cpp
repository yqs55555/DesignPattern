#include "World.h"
#include <random>


World::World()
	:grassTerrain_(1, false), hillTerrain_(3, false), riverTerrain_(2, true)
{
}


World::~World()
{
}

void World::generateTerrain()
{
	std::default_random_engine random;
	std::uniform_int_distribution<int> u(0, 10);
	for(int x = 0;x < WIDTH;x++)
	{
		for(int y = 0;y < HEIGHT;y++)
		{
			if(u(random) == 0)
			{
				tiles_[x][y] = &hillTerrain_;
			}
			else
			{
				tiles_[x][y] = &grassTerrain_;
			}
		}
	}
	u = std::uniform_int_distribution<int>(0, WIDTH);
	int x = u(random);
	for(int y = 0;y < HEIGHT;y++)
	{
		tiles_[x][y] = &riverTerrain_;
	}
}

const Terrain & World::getTile(int x, int y) const
{
	return *tiles_[x][y];
}
