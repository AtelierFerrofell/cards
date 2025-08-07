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
		Card card = Deck.GetChild(0) as Card;
		card.Reparent(this);
		card.Reveal();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (GetChildCount() == 0)
		{
			Draw();
		}
	}
}
