
namespace System
{
    public partial class RandomExtension
    {
        public bool NextBoolean()
        {
            return this.Next(2) == 0;
        }
    }
}
