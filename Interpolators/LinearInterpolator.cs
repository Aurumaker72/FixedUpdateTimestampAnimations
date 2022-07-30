namespace FixedUpdateTimestampAnimations.Interpolators
{
    public class LinearInterpolator : IInterpolator
    {
        /// <summary>
        /// Returns a linearly interpolated value between v1 and v2, determined by t
        /// </summary>
        /// <param name="v1">The lower bound</param>
        /// <param name="v2">The higher bound</param>
        /// <param name="t">The progress/tempus</param>
        /// <returns>The scaled value</returns>
        public float Interpolate(float v1, float v2, float t)
        {
            return v1 + (v2 - v1) * t;
        }
    }
}
