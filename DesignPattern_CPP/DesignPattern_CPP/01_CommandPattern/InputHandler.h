#pragma once
#include "Command.h"
#include "MoveUnitCommand.h"

enum Input
{
	BUTTON_X,
	BUTTON_Y,
	BUTTON_A,
	BUTTON_B,
	BUTTON_UP,
	BUTTON_DOWN
};
class InputHandler
{
public:
	InputHandler(Command* buttonX, Command* buttonY, Command* buttonA, 
		Command* buttonB, Unit* unit);
	~InputHandler();
	void setInput(Input input);
	Command* handleInput() const;
private:
	bool isPressed(Input input) const;
	Unit* getSelectedUnit() const;

private:
	Input m_curInput;
	Command* buttonX_;
	Command* buttonY_;
	Command* buttonA_;
	Command* buttonB_;
	MoveUnitCommand* moveCommand_;
	Unit* unit_;
};

