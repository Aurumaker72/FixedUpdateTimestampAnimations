namespace FixedUpdateTimestampAnimations.Animations
{
    public class OneDimensionalAnimation : Animation
    {

        public OneDimensionalAnimation(TimeSpan duration, IInterpolator interpolator, IProgressor progressor, float startValue, float endValue) : base(duration, interpolator, progressor)
        {
            StartValue = startValue;
            EndValue = endValue;
        }

        public float StartValue { get; set; }
        public float EndValue { get; set; }

        public float CurrentValue
        {
            get
            {
                return interpolator.Interpolate(StartValue, EndValue, Progress);
            }
        }

    }
}
