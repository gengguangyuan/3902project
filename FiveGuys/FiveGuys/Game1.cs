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
        Texture2D linkTexture;
        FiveGuys.linkSprite LinkSprite;

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
            linkTexture = Content.Load<Texture2D>("LinkFullSprite");
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



            base.Draw(gameTime);
        }
    }
}
