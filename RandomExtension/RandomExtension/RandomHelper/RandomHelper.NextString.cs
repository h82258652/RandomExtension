
namespace System
{
    public static partial class RandomHelper
    {
        /// <summary>
        /// 从字符串数组中随机返回一个字符串。
        /// </summary>
        /// <param name="strs">字符串数组。</param>
        /// <returns>字符串数组中随机一个字符串。</returns>
        /// <exception cref="System.ArgumentNullException"><c>strs</c> 为 null。</exception>
        /// <exception cref="System.ArgumentException"><c>strs</c> 的元素个数为零。</exception>
        public static string NextString(params string[] strs)
        {
            return Rand.NextString(strs);
        }
    }
}
