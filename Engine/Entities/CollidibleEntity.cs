using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Engine.Entities;

public abstract class CollidiableEntity
{
    private Point size;
    private Texture2D texture;
    public Rectangle collider;
    public object[] otherProps;

#nullable enable
    public CollidiableEntity(Texture2D t, Rectangle c, Point s, object[]? op)
    {
        this.texture = t;
        this.collider = c;
        this.size = s;
    }
}