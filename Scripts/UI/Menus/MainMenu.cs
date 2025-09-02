using Godot;
using System;
// AAAAAAAAAAAAAAAA


public partial class MainMenu : Control
{
	
	
	public override void _Ready()
	{
		GD.Print("oh yeah ");

		var quitButton = GetNode<Button>("Panel/VBoxContainer/QuitButton");
		quitButton.Pressed += OnQuitButtonPressed;


	}

	private void OnQuitButtonPressed()
	{
		GetTree().Quit();
	}
	
	
}
