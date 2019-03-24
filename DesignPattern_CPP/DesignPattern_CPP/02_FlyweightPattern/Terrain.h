#pragma once
class Terrain
{
public:
	Terrain(int movementCost, bool isWater);
	~Terrain();
	int getMoveCost() const;
	bool isWater() const;

private:
	int moveCost_;
	bool isWater_;
};
