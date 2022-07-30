namespace FixedUpdateTimestampAnimations
{
    public abstract class Animation
    {
        protected IInterpolator interpolator;
        protected IProgressor progressor;

        internal const float MinimumProgress = 0f;
        internal const float MaximumProgress = 1f;

        public Animation(TimeSpan duration, IInterpolator interpolator, IProgressor progressor)
        {
            Duration = duration;
            this.interpolator = interpolator;
            this.progressor = progressor;
        }

        /// <summary>
        /// The animation's progress, ranging from 0f-1f
        /// </summary>
        public float Progress { get; protected internal set; }

        /// <summary>
        /// The animation's duration
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Whether the animation's progress will be advanced on new ticks
        /// </summary>
        public bool IsResumed { get; set; } = true;

        /// <summary>
        /// Whether the animation's progress won't be advanced on new ticks
        /// </summary>
        public bool IsPaused => !IsResumed;

        /// <summary>
        /// Tick the animation, advancing its progress
        /// </summary>
        /// <param name="delta"></param>
        public void Tick(float delta)
        {
            if (IsResumed)
            {
                Progress = progressor.GetProgress(delta, this);
            }
        }

    }
}