using Godot;
using System;

public class SpectatorCameraPivot : Spatial
{
    [Export]
    public float MoveSpeed = 20;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print(MoveSpeed);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        
    }

    public override void _Input(InputEvent @event)
    {
        InputEventAction eventAction = new InputEventAction();
        //eventAction.Action = 

        if (Input.IsActionPressed("Forward"))
        {
            GlobalTranslate(new Vector3(0, 0, MoveSpeed));
        }

        if (Input.IsActionPressed("Back"))
        {
            GlobalTranslate(new Vector3(0, 0, MoveSpeed * -1));
        }
        base._Input(@event);
    }
}
