#include "Test.h"
void Test()
{
	Unit* main_unit = new Unit(0, 0);
	Command* buttonX = new JumpCommand();
	InputHandler* input_handler =
		new InputHandler(buttonX, nullptr, nullptr, nullptr, main_unit);

	input_handler->setInput(Input::BUTTON_X);
	Command* command = input_handler->handleInput();
	if (command != nullptr)
	{
		command->execute();
	}

	input_handler->setInput(Input::BUTTON_UP);
	command = input_handler->handleInput();
	if (command != nullptr)
	{
		command->execute();
	}

	delete buttonX;
	delete main_unit;
	delete input_handler;
}