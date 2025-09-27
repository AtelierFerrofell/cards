using Godot;
using System;

[Tool]
[GlobalClass]
public partial class Deck : Node
{
	public Card Draw(Node target)
	{
		Card card = GetChild(0) as Card;
		// Handle when card is null
		card.Reparent(target);
		return card;
	}
}
