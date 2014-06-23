
namespace System
{
    public partial class RandomExtension
    {
        public override void NextBytes(byte[] buffer)
        {
            base.NextBytes(buffer);
        }

        public byte[] NextBytes(int length)
        {
            if (length < 0)
            {
            }

            var buffer = new byte[length];
            NextBytes(buffer);
            return buffer;
        }
    }
}
