using Godot;
using System;

[GlobalClass]
public partial class Card : Resource
{
	[Export]
	public CardInfo Info { get; set; }
}
