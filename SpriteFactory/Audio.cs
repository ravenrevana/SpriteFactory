namespace SpriteFactory
{
    public class Audio
    {
        public string name;
        public string cycle;
        public int keyFrameIndex;
        public int delay;

        public Audio(string name, int delay, string cycle, int keyFrameIndex)
        {
            this.name = name;
            this.delay = delay;
            this.cycle = cycle;
            this.keyFrameIndex = keyFrameIndex;
        }
    }
}
