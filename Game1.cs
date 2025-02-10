using FiveGuys.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0;

namespace FiveGuys
{
    public class Game1 : Game
    {
        private MouseController mouseController;
        private KeyboardController keyboardController;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        LinkSprite linkSprite;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this._graphics.PreferredBackBufferHeight = 720;
            this._graphics.PreferredBackBufferWidth = 1280;
        }

        protected override void Initialize()
        {
            keyboardController = new KeyboardController(this);
            mouseController = new MouseController(this);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D texture = Content.Load<Texture2D>("Link");
            Vector2 position = new Vector2(Window.ClientBounds.Width / 2 , Window.ClientBounds.Height / 2);
            linkSprite = new LinkSprite(texture, position);
        }
        

        protected override void Update(GameTime gameTime)
        {
            mouseController.Update();
            keyboardController.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGoldenrodYellow);


            _spriteBatch.Begin();
            _spriteBatch.Draw(linkSprite.texture, linkSprite.DestRect, linkSprite.SourceRect, Color.White);
            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
