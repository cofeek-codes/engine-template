using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Engine.Loaders;

public class ContentLoader
{
    private ContentManager manager;
    public ContentLoader(ContentManager Content)
    {
        this.manager = Content;
    }

#nullable enable
    public T? Load<T>(T loadableType, string loadableValue)
    {
        try
        {
            T value = manager.Load<T>(loadableValue);
            return value;
        }
        catch (ContentLoadException e)
        {
            Console.WriteLine($"unable to load this type of content. detils: {e}");

            return default(T);

        }
    }
}
