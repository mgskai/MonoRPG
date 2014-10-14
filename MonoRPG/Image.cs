using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoRPG
{
    public class Image
    {
        public float Alpha;

        public string Text, FontName, Path;
        public Vector2 Postion, Scale;
        public Rectangle SourceRect;

        public Texture2D Texture;
        Vector2 origin;
        ContentManager content;
        RenderTarget2D renderTarget;

        public Image()
        {
            Path = String.Empty;
            FontName = "Oribtron";
            Postion = Vector2.Zero;
            Scale = Vector2.One;
            Alpha = 1.0f;
            SourceRect = Rectangle.Empty;
        }
        public void LoadContent()
        {
            content = new ContentManager(
                ScreenManager.Instance.Content.ServiceProvider, "Content");
            if (Path != String.Empty)
            {
                Texture = content.Load<Texture2D>(Path);
            }
          
        }

        public void UnloadContent()
        {

        }

        public void Update(GameTime gameTime)
        {
              
        }

        public void Draw(SpriteBatch spriteBatch)
        {
 
        }

    }
}
