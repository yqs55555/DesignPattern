#pragma once
#include "Command.h"
class JumpCommand : public Command
{
public:
	JumpCommand();
	~JumpCommand();
	void execute() override;
	void undo() override;
};

