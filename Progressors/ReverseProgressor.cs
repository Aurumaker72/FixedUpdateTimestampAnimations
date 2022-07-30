namespace FixedUpdateTimestampAnimations.Progressors
{
    /// <summary>
    /// A progressor which seamlessy advances the progress back to the initial state upon ending
    /// </summary>
    public class ReverseProgressor : IProgressor
    {
        private float lastProgress;
        private bool progressIncreasing = true;

        public float GetProgress(float delta, Animation animation)
        {
            lastProgress = animation.Progress;
            if ((animation.Progress == Animation.MaximumProgress
                 && lastProgress != Animation.MaximumProgress) || (animation.Progress == Animation.MaximumProgress && lastProgress == Animation.MaximumProgress))
            {
                progressIncreasing = false;
            }
            if ((animation.Progress == Animation.MinimumProgress && lastProgress != Animation.MinimumProgress) || (animation.Progress == Animation.MinimumProgress && lastProgress == Animation.MinimumProgress))
            {
                progressIncreasing = true;
            }
            if (progressIncreasing)
            {
                return Math.Clamp((animation.Progress + (1f / (float)animation.Duration.TotalMilliseconds) * delta), Animation.MinimumProgress, Animation.MaximumProgress);
            }
            else
            {
                return Math.Clamp((animation.Progress - (1f / (float)animation.Duration.TotalMilliseconds) * delta), Animation.MinimumProgress, Animation.MaximumProgress);
            }
        }
    }
}
