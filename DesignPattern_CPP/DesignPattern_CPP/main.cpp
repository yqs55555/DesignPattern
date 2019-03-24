#include <iostream>
#include "01_CommandPattern/InputHandler.h"
#include "01_CommandPattern/JumpCommand.h"
#include "02_FlyweightPattern/World.h"

void Test_CommandPattern();
void Test_FlyweightPattern();

int main()
{
	Test_FlyweightPattern();
	return 0;
}

void Test_CommandPattern()
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

void Test_FlyweightPattern()
{
	World* world = new World();

	world->generateTerrain();
	std::cout << world->getTile(2, 5).getMoveCost() << std::endl;

	delete world;
}