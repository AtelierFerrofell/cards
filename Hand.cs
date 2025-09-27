using Godot;
using System;

[Tool]
[GlobalClass]
public partial class Hand : Node
{
	[Export]
	public Deck Deck { get; set; }

	public void Draw()
	{
		Deck.Draw(this).Reveal();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//if (GetChildCount() == 0)
		//{
			//Draw();
		//}
	}
}
