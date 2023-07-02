using Microsoft.Xna.Framework;

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
    }
}
