
namespace System
{
    /// <summary>
    /// Random 扩展类。
    /// </summary>
    public partial class RandomExtension : Random
    {
        public RandomExtension()
        {
        }

        public RandomExtension(int seed)
            : base(seed)
        {
        }
    }
}
