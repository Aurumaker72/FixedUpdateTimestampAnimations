namespace FixedUpdateTimestampAnimations.Interpolators
{
    public class EasedSineInterpolator : IInterpolator
    {
        /// <summary>
        /// Returns an eased sine-wave interpolated value between v1 and v2, determined by t
        /// </summary>
        /// <param name="v1">The lower bound</param>
        /// <param name="v2">The higher bound</param>
        /// <param name="t">The progress/tempus</param>
        /// <returns>The scaled value</returns>
        public float Interpolate(float v1, float v2, float t)
        {
            return MathHelper.Remap((float)(-(Math.Cos(Math.PI * t) - 1) / 2), 0, 1, v1, v2);
        }
    }
}
