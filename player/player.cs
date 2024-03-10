using Godot;
using System;

public partial class player : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 400;
	
	public void HandleInput() 
	{
		var moveDirection = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		Velocity = moveDirection * Speed;
	}
	
	public override void _PhysicsProcess(double delta)
	{
		HandleInput();
		MoveAndSlide();
	}
}
