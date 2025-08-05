using Godot;
using System;

[Tool]
[GlobalClass]
public partial class Card : Resource
{
	private CardInfo _info;
	
	[Export]
	public CardInfo Info
	{
		get => _info;
		set
		{
			_info = value;
			EmitChanged();
		}
	}
}
