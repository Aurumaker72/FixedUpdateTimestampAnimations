namespace FixedUpdateTimestampAnimations
{
    internal class MathHelper
    {
        public static float Remap(float value, float from1, float to1, float from2, float to2)
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }
        public static float WrappingClamp(float value, float min, float max)
        {
            if (value > max)
            {
                return min;
            }
            if (value < min)
            {
                return max;
            }
            return value;
        }
    }
}
