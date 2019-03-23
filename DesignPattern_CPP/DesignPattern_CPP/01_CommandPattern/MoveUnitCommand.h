#pragma once
#include "Command.h"
class Unit;

class MoveUnitCommand : public Command
{
public:
	MoveUnitCommand(Unit* unit, int x, int y);
	~MoveUnitCommand();
	void execute() override;
	void undo() override;
	MoveUnitCommand* set(int x, int y);
private:
	Unit *unit_;
	int x_;
	int y_;
	int xBefore_;
	int yBefore_;
};

class Unit
{
public:
	Unit(int x, int y) : x_(x), y_(y)
	{
	}

	int x() const
	{
		return this->x_;
	}

	int y() const
	{
		return this->y_;
	}

	void moveTo(int x, int y)
	{
		std::cout << "move to " << x << "," << y << std::endl;
		this->x_ = x;
		this->y_ = y;
	}

private:
	int x_;
	int y_;
};