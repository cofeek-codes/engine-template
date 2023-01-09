using Engine.Loaders;
using Microsoft.Xna.Framework.Content;

namespace Engine;

public class Main
{
    ContentLoader loader;

    public Main(ContentManager manager)
    {
        loader = new ContentLoader(manager);
    }
}