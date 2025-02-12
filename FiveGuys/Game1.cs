using FiveGuys.Animation;
using FiveGuys.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FiveGuys
{
    public class Game1 : Game
    {
        private MouseController mouseController;
        private KeyboardController keyboardController;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Vector2 position;
        private Sprite linkSprite;

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

            position = new Vector2(Window.ClientBounds.Width / 2 , Window.ClientBounds.Height / 2);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

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

            linkSprite.Draw(_spriteBatch, position);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
