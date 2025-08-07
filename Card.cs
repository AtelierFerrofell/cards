using Godot;
using System;

[Tool]
[GlobalClass]
public partial class Card : Node
{
	private CardInfo _info;

	[Export]
	public CardInfo Info
	{
		get => _info;
		set
		{
			if (_info != null)
			{
				_info.Changed -= OnInfoChanged;
			}
			_info = value;
			if (_info != null)
			{
				_info.Changed += OnInfoChanged;
			}
		}
	}

	protected virtual void OnInfoChanged()
	{
	}

	public virtual void Reveal()
	{
	}
}
