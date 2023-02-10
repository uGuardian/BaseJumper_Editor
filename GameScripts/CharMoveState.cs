using System;

public enum CharMoveState
{
	None,
	Stop,
	MoveForward,
	MoveBack,
	MoveRight,
	MoveLeft,
	MoveOpponent,
	MoveOpponent_Near,
	MoveOpponent_Near2,
	Disappear,
	TeleportFront,
	TeleportBack,
	Knockback,
	BackBlink,
	Confrontation,
	Competition,
	KnockDown,
	Custom
}
