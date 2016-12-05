using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.IO;
using Newtonsoft.Json;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Color bgColor = new Color(25, 23, 22);

        Player player;

        Texture2D background;

        SpriteFont font;

        int[] mapArray;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Window.Title = "Hello World";
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            player = new Player(Content.Load<Texture2D>(@"player"), new Vector2(0,0), 64);
            int windowWidth = GraphicsDevice.Viewport.Bounds.Width / 2;
            int windowHeight = GraphicsDevice.Viewport.Bounds.Height / 2;
            player.position = new Vector2(windowWidth - (player.spriteSize/2), windowHeight - (player.spriteSize / 2)); // Move player to center

            background = Content.Load<Texture2D>(@"cave");
            Scroller.X = 0;
            Scroller.Y = 0;

            LoadJson("cave_1.json");

            font = Content.Load<SpriteFont>("Arial");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(bgColor);

            // Draw while not interpleting (bluring) half-pixels 
            spriteBatch.Begin(SpriteSortMode.Deferred, null, SamplerState.PointWrap, null, null, null, Matrix.CreateTranslation(-Scroller.X, -Scroller.Y, 0));

            spriteBatch.Draw(background, new Rectangle(0, 0, background.Width, background.Height), Color.White);
            drawMap(mapArray, background, 16, 32, spriteBatch);
            player.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void LoadJson(string file)
        {
            string json;
            using (StreamReader r = new StreamReader(file)) {
                 json = r.ReadToEnd();
            }
            dynamic o = JsonConvert.DeserializeObject(json);
            mapArray = (int[])o.layers[0].data.ToObject(typeof(int[]));
        }

        public void drawMap(int[] map, Texture2D tilemap, int tileSize, int drawSize ,SpriteBatch spriteBatch)
        {
            int tileWidth = 30;// Used to turn id's to positions 

            for (int i = 0; i < map.Length; i++)
            {
                int x = (i % tileWidth) * drawSize;
                int y = (int)(i / tileWidth) * drawSize;
                int sourceX = ((map[i]-1) % tileSize) * tileSize;
                int sourceY = ((map[i]-1) / tileSize) * tileSize;
                spriteBatch.Draw(tilemap, new Rectangle(x, y, drawSize, drawSize), new Rectangle(sourceX, sourceY, tileSize, tileSize), Color.White);
            }
        }
    }
}
