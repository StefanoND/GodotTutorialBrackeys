using System;
using Godot;

public partial class Coin : Area2D
{
    public override void _Ready()
    {
        collisionShape2D = GetNode<CollisionShape2D>("CollisionShape2D");
    }

    private void OnBodyEntered(Node2D body)
    {
        if (collisionShape2D != null)
        {
            collisionShape2D.SetDeferred(
                CollisionShape2D.PropertyName.Disabled,
                true
            );
            GD.Print("+1 Coin!");
            Hide();
        }
    }

    private CollisionShape2D collisionShape2D = null;
}
