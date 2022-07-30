namespace FixedUpdateTimestampAnimations
{
    /// <summary>
    /// Represents a contract responsible for computing the progress of an animation
    /// </summary>
    public interface IProgressor
    {
        public float GetProgress(float delta, Animation animation);
    }
}
