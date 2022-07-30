namespace FixedUpdateTimestampAnimations
{
    /// <summary>
    /// Represents an 1-Dimensional interpolation contract
    /// </summary>
    public interface IInterpolator
    {
        public float Interpolate(float v1, float v2, float t);
    }
}
