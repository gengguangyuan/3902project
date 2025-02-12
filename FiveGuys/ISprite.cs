using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace FiveGuys
{
  public interface ISprite
  {
        //test

    void Draw(SpriteBatch _spriteBatch, Vector2 position);
    void Update(GameTime gt);
    void LoadContent(ContentManager content);
  }
}
