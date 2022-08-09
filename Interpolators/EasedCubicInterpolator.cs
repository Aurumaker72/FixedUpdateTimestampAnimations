using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedUpdateTimestampAnimations.Interpolators
{
    public class EasedCubicInterpolator : IInterpolator
    {
        /// <summary>
        /// Returns an eased cubic interpolated value between v1 and v2, determined by t
        /// </summary>
        /// <param name="v1">The lower bound</param>
        /// <param name="v2">The higher bound</param>
        /// <param name="t">The progress/tempus</param>
        /// <returns>The scaled value</returns>
        public float Interpolate(float v1, float v2, float t)
        {
            return MathHelper.Remap((float)(t < 0.5 ? 4 * t * t * t : 1 - Math.Pow(-2 * t + 2, 3) / 2), 0, 1, v1, v2);
        }
    }
}
