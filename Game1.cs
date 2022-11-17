using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Part_2___Scaling
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture;
        Rectangle circleRect;

        Texture2D rectangleTexture;
        Rectangle rectangleRect;

        Rectangle smileRect;

        Rectangle eyeRect1;

        Rectangle eyeRect2;

        SpriteFont titlefont;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            rectangleRect = new Rectangle(10, 10, 40, 40);
            circleRect = new Rectangle(125, 0, 475, 475);
            smileRect = new Rectangle(220, 295, 275, 50);
            eyeRect1 = new Rectangle(260, 150, 50, 50);
            eyeRect2 = new Rectangle(410, 150, 50, 50);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            titlefont = Content.Load<SpriteFont>("TitleFont");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");



        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(circleTexture, circleRect, Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, smileRect, Color.Black);
            _spriteBatch.Draw(rectangleTexture, eyeRect1, Color.Black);
            _spriteBatch.Draw(rectangleTexture, eyeRect2, Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}