#include "InputHandler.h"

InputHandler::InputHandler(Command* buttonX, Command* buttonY, 
	Command* buttonA, Command* buttonB, Unit* unit)
	:buttonX_(buttonX), buttonY_(buttonY), buttonA_(buttonA),
	buttonB_(buttonB), unit_(unit)
{
	this->moveCommand_ = new MoveUnitCommand(unit, unit->x(), unit->y());
}


InputHandler::~InputHandler()
{
	delete moveCommand_;
}

void InputHandler::setInput(Input input)
{
	this->m_curInput = input;
}

Command* InputHandler::handleInput() const
{
	Unit* unit = getSelectedUnit();
	if(isPressed(BUTTON_UP))
	{
		return moveCommand_->set(unit->x(), unit->y() - 1);
	}
	else if(isPressed(BUTTON_DOWN))
	{
		return moveCommand_->set(unit->x(), unit->y() + 1);
	}
	else if(isPressed(BUTTON_X))
	{
		return this->buttonX_;
	}
	else if(isPressed(BUTTON_Y))
	{
		return this->buttonY_;
	}
	else if(isPressed(BUTTON_A))
	{
		return this->buttonA_;
	}
	else if(isPressed(BUTTON_B))
	{
		return this->buttonB_;
	}

	return nullptr;
}

bool InputHandler::isPressed(Input input) const
{
	return this->m_curInput == input;
}

Unit * InputHandler::getSelectedUnit() const
{
	return this->unit_;
}
