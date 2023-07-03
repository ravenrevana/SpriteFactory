using Microsoft.Xna.Framework;
using System;

namespace SpriteFactory
{
    public class HitBox
    {
        public Rectangle hitBoxRectangle;
        public int keyFrameIndex;
        public bool isSelected;

        public HitBox(Rectangle hitBoxRectangle, int keyFrameIndex, bool isSelected) 
        {
            this.hitBoxRectangle = hitBoxRectangle;
            this.keyFrameIndex = keyFrameIndex;
            this.isSelected = isSelected;
        }

        public static Rectangle ScaleHitBoxDown(Rectangle rec, int zoom)
        {
            // Math Ceiling and Floor are used because selection should include all selected pixel
            // -> Without it the selection is more or less random while scaling down

            int scaleWidth = (int)Math.Ceiling((float)rec.Width / (float)zoom);
            int scaleHeight = (int)Math.Ceiling((float)rec.Height / (float)zoom);
            int posX = (int)Math.Floor((float)rec.X / (float)zoom);
            int posY = (int)Math.Floor((float)rec.Y / (float)zoom);

            return new Rectangle(posX, posY, scaleWidth, scaleHeight);
        }

        public static Rectangle ScaleHitBoxUp(Rectangle rec, int zoom)
        {
            // Math Ceiling and Floor are used because selection should include all selected pixel
            // -> Without it the selection is more or less random while scaling up

            int scaleWidth = (int)Math.Ceiling((float)rec.Width * (float)zoom);
            int scaleHeight = (int)Math.Ceiling((float)rec.Height * (float)zoom);
            int posX = (int)Math.Floor((float)rec.X * (float)zoom);
            int posY = (int)Math.Floor((float)rec.Y * (float)zoom);

            return new Rectangle(posX, posY, scaleWidth, scaleHeight);
        }
    }
}
