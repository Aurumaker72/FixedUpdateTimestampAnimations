namespace FixedUpdateTimestampAnimations.Progressors
{
    /// <summary>
    /// A progressor which retains the animation's ultimate state upon ending
    /// </summary>
    public class HoldProgressor : IProgressor
    {
        public float GetProgress(float delta, Animation animation)
        {
            return Math.Clamp((animation.Progress + (1f / (float)animation.Duration.TotalMilliseconds) * delta), Animation.MinimumProgress, Animation.MaximumProgress);
        }
    }
}
