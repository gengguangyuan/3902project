using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sprint0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Goku goku;
        private SpriteFont creditsFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            Texture2D texture = Content.Load<Texture2D>("Sprint0Sprite");
            Vector2 position = new Vector2(Window.ClientBounds.Width / 2 - 49, Window.ClientBounds.Height / 2);
            goku = new Goku(texture, position);
            creditsFont = Content.Load<SpriteFont>("File");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var kstate = Keyboard.GetState();
            var mouseState = Mouse.GetState();

            int q = 0;
            if (kstate.IsKeyDown(Keys.D0) || mouseState.RightButton == ButtonState.Pressed)
            {
                Exit();
            }
            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                if (mouseState.Position.X < Window.ClientBounds.Width / 2 && mouseState.Position.Y < Window.ClientBounds.Height / 2)
                {
                    q = 1;
                }
                else if (mouseState.Position.X > Window.ClientBounds.Width / 2 && mouseState.Position.Y < Window.ClientBounds.Height / 2)
                {
                    q = 2;
                }
                else if (mouseState.Position.X < Window.ClientBounds.Width / 2)
                {
                    q = 3;
                }
                else
                {
                    q = 4;
                }
            }
                if (kstate.IsKeyDown(Keys.D1) || q == 1)
                {
                    goku.stopMotion();
                    goku.unAnimate();
                    var position = goku.position;
                    position.X = Window.ClientBounds.Width / 2 - 49;
                    position.Y = Window.ClientBounds.Height / 2;
                    goku.setPosition(position);
                }

                if (kstate.IsKeyDown(Keys.D2) || q==2)
                {
                    goku.stopMotion();
                    goku.animate();
                }
                if (kstate.IsKeyDown(Keys.D3) || q==3)
                {
                    goku.unAnimate();
                    goku.startMotionUp();
                }
                
                if (kstate.IsKeyDown(Keys.D4)|| q==4)
                {
                    goku.animate();
                    goku.startMotion();
                }
            
                goku.Update(gameTime);
                base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(goku.texture, new Rectangle(0, Window.ClientBounds.Height / 2 + 131, Window.ClientBounds.Width, 150), new Rectangle(862, 512, 100, 100), Color.White);

            string creditsText = "Created by: Anirudh Kummamuri\nSprites from: https://www.spriters-resource.com/";
            _spriteBatch.DrawString(creditsFont, creditsText, new Vector2(Window.ClientBounds.Height / 2 + 200, Window.ClientBounds.Width / 2), Color.White);

            _spriteBatch.Draw(goku.texture, goku.DestRect, goku.SourceRect, Color.White);


            _spriteBatch.End();

            

            base.Draw(gameTime);
        }
    }
}
