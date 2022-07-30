namespace FixedUpdateTimestampAnimations.Progressors
{
    /// <summary>
    /// A progressor which restarts the animation upon ending
    /// </summary>
    public class RestartProgressor : IProgressor
    {
        public float GetProgress(float delta, Animation animation)
        {
            return MathHelper.WrappingClamp((animation.Progress + (1f / (float)animation.Duration.TotalMilliseconds) * delta), Animation.MinimumProgress, Animation.MaximumProgress);
        }
    }
}
