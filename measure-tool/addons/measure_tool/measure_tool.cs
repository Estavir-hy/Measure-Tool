#if TOOLS
using Godot;
using System;

[Tool]
public partial class measure_tool : EditorPlugin
{
	public override void _EnterTree()
	{
		GD.Print("Im in");
	}

	public override void _ExitTree()
	{
		GD.Print("Im out");
	}
}
#endif
