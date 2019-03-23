#include "MoveUnitCommand.h"

MoveUnitCommand::MoveUnitCommand(Unit* unit, int x, int y)
	:unit_(unit), x_(x), y_(y), xBefore_(0), yBefore_(0)
{
}

MoveUnitCommand::~MoveUnitCommand()
{
}

void MoveUnitCommand::execute()
{
	xBefore_ = unit_->x();
	yBefore_ = unit_->y();
	unit_->moveTo(x_, y_);
}

void MoveUnitCommand::undo()
{
	unit_->moveTo(xBefore_, yBefore_);
}

MoveUnitCommand* MoveUnitCommand::set(int x, int y)
{
	this->x_ = x;
	this->y_ = y;

	return this;
}
