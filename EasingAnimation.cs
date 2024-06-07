using System;

namespace App.Animations
{
    /// <summary>
    /// All known animation functions
    /// </summary>
    public enum EasingType
    {
        Linear,
        BackEaseIn,
        BackEaseOut,
        BackEaseInOut,
        BounceEaseIn,
        BounceEaseOut,
        BounceEaseInOut,
        ElasticEaseIn,
        ElasticEaseOut,
        ElasticEaseInOut,
        CubicEaseIn,
        CubicEaseInOut,
        CubicEaseOut,
        CircularEaseInOut,
        CircularEaseIn,
        CircularEaseOut,
        QuadraticEaseIn,
        QuadraticEaseOut,
        QuadraticEaseInOut,
        QuarticEaseIn,
        QuarticEaseOut,
        QuarticEaseInOut,
        QuinticEaseIn,
        QuinticEaseOut,
        QuinticEaseInOut,
        SinusoidalEaseIn,
        SinusoidalEaseOut,
        SinusoidalEaseInOut,
        ExponentialEaseIn,
        ExponentialEaseOut,
        ExponentialEaseInOut,
        None,
    }


    /// <summary>
    ///     The functions gallery for animation
    /// </summary>
    public class EasingAnimation
    {
        /// <summary>Animaton easing type</summary>
        public EasingType Type { get; set; }


        //----------------------------------------------------------------
        // Constructor
        //----------------------------------------------------------------
        public EasingAnimation(EasingType type)
        {
            this.Type = type;
        }


        //----------------------------------------------------------------
        // Functions
        //----------------------------------------------------------------
        /// <summary>Get current value.</summary>
        /// <param name="time">The time of the animation.</param>
        /// <param name="duration">The duration of the animations.</param>
        /// <param name="beginValue">The begin value.</param>
        /// <param name="distance">The different between starting and ending value.</param>
        /// <returns>The calculated current value of the animation</returns>
        public double GetValue(double time, double duration, double beginValue, double distance)
        {
            switch (this.Type)
            {
                case EasingType.None:                    return beginValue;
                case EasingType.Linear:                  return Linear(time, duration, beginValue, distance);
                case EasingType.BackEaseIn:              return BackEaseIn(time, duration, beginValue, distance);
                case EasingType.BackEaseOut:             return BackEaseOut(time, duration, beginValue, distance);
                case EasingType.BackEaseInOut:           return BackEaseInOut(time, duration, beginValue, distance);
                case EasingType.BounceEaseIn:            return BounceEaseIn(time, duration, beginValue, distance);
                case EasingType.BounceEaseOut:           return BounceEaseOut(time, duration, beginValue, distance);
                case EasingType.BounceEaseInOut:         return BounceEaseInOut(time, duration, beginValue, distance);
                case EasingType.ElasticEaseIn:           return ElasticEaseIn(time, duration, beginValue, distance);
                case EasingType.ElasticEaseOut:          return ElasticEaseOut(time, duration, beginValue, distance);
                case EasingType.ElasticEaseInOut:        return ElasticEaseInOut(time, duration, beginValue, distance);
                case EasingType.CubicEaseIn:             return CubicEaseIn(time, duration, beginValue, distance);
                case EasingType.CubicEaseOut:            return CubicEaseOut(time, duration, beginValue, distance);
                case EasingType.CubicEaseInOut:          return CubicEaseInOut(time, duration, beginValue, distance);
                case EasingType.CircularEaseIn:          return CircularEaseIn(time, duration, beginValue, distance);
                case EasingType.CircularEaseOut:         return CircularEaseOut(time, duration, beginValue, distance);
                case EasingType.CircularEaseInOut:       return CircularEaseInOut(time, duration, beginValue, distance);
                case EasingType.QuadraticEaseIn:         return QuadraticEaseIn(time, duration, beginValue, distance);
                case EasingType.QuadraticEaseOut:        return QuadraticEaseOut(time, duration, beginValue, distance);
                case EasingType.QuadraticEaseInOut:      return QuadraticEaseInOut(time, duration, beginValue, distance);
                case EasingType.QuarticEaseIn:           return QuarticEaseIn(time, duration, beginValue, distance);
                case EasingType.QuarticEaseOut:          return QuarticEaseOut(time, duration, beginValue, distance);
                case EasingType.QuarticEaseInOut:        return QuarticEaseInOut(time, duration, beginValue, distance);
                case EasingType.QuinticEaseIn:           return QuinticEaseIn(time, duration, beginValue, distance);
                case EasingType.QuinticEaseOut:          return QuinticEaseOut(time, duration, beginValue, distance);
                case EasingType.QuinticEaseInOut:        return QuinticEaseInOut(time, duration, beginValue, distance);
                case EasingType.SinusoidalEaseIn:        return SinusoidalEaseIn(time, duration, beginValue, distance);
                case EasingType.SinusoidalEaseOut:       return SinusoidalEaseOut(time, duration, beginValue, distance);
                case EasingType.SinusoidalEaseInOut:     return SinusoidalEaseInOut(time, duration, beginValue, distance);
                case EasingType.ExponentialEaseIn:       return ExponentialEaseIn(time, duration, beginValue, distance);
                case EasingType.ExponentialEaseOut:      return ExponentialEaseOut(time, duration, beginValue, distance);
                case EasingType.ExponentialEaseInOut:    return ExponentialEaseInOut(time, duration, beginValue, distance);
                default:                                 throw new Exception("The passed animation type is unknown.");
            }        
        }

        public enum EaseMode
        {
            EaseIn,
            EaseOut,
            EaseInOut
        }



        //----------------------------------------------------------------
        // LInear functions
        //----------------------------------------------------------------
        /// <summary>The linear animation function.</summary>
        public static double Linear(double t, double d, double b, double c)
        {
            return c * t / d + b;
        }


        //----------------------------------------------------------------
        // Back functions
        //----------------------------------------------------------------
        private double BackEaseIn(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Back(time / duration, EaseMode.EaseIn) * distance;
        }
        private double BackEaseOut(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Back(time / duration, EaseMode.EaseOut) * distance;
        }
        private double BackEaseInOut(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Back(time / duration, EaseMode.EaseInOut) * distance;
        }

        public static double Back(double x, EaseMode easeMode)
        {
            switch (easeMode)
            {
                case EaseMode.EaseIn:
                    return 2.70158 * x * x * x - 1.70158 * x * x;
                case EaseMode.EaseOut:
                    return 1 + 2.70158 * Math.Pow(x - 1, 3) + 1.70158 * Math.Pow(x - 1, 2);
                case EaseMode.EaseInOut:
                    return x < 0.5 ? (Math.Pow(2 * x, 2) * (7.189819 * x - 2.5949095)) / 2 : (Math.Pow(2 * x - 2, 2) * (7.189819 * x - 4.5949095) + 2) / 2;
                default:
                    return 0;
            }
        }

        //----------------------------------------------------------------
        // Elastic functions
        //----------------------------------------------------------------
        private double ElasticEaseIn(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Elastic(time / duration, EaseMode.EaseIn) * distance;
        }
        private double ElasticEaseOut(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Elastic(time / duration, EaseMode.EaseOut) * distance;
        }
        private double ElasticEaseInOut(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Elastic(time / duration, EaseMode.EaseInOut) * distance;
        }
        public static double Elastic(double x, EaseMode easeMode)
        {
            switch (easeMode)
            {
                case EaseMode.EaseIn:
                    return x == 0 ? 0 : x == 1 ? 1 : -Math.Pow(2, 10 * x - 10) * Math.Sin((x * 10 - 10.75) * 2 * Math.PI / 3);
                case EaseMode.EaseOut:
                    return x == 0 ? 0 : x == 1 ? 1 : Math.Pow(2, -10 * x) * Math.Sin((x * 10 - 0.75) * 2 * Math.PI / 3) + 1;
                case EaseMode.EaseInOut:
                    return x == 0 ? 0 : x == 1 ? 1 : x < 0.5 ? -(Math.Pow(2, 20 * x - 10) * Math.Sin((x * 20 - 11.125) * 2 * Math.PI / 4.5)) / 2 : (Math.Pow(2, -20 * x + 10) * Math.Sin((x * 20 - 11.125) * 2 * Math.PI / 4.5)) / 2 + 1;
                default:
                    return 0;
            }
        }

        //----------------------------------------------------------------
        // Bounce functions
        //----------------------------------------------------------------
        private double BounceEaseInOut(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Bounce(time / duration, EaseMode.EaseIn) * distance;
        }

        private double BounceEaseOut(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Bounce(time / duration, EaseMode.EaseOut) * distance;
        }

        private double BounceEaseIn(double time, double duration, double beginValue, double distance)
        {
            return beginValue + Bounce(time / duration, EaseMode.EaseInOut) * distance;
        }


        public static double Bounce(double x, EaseMode easeMode)
        {
            switch (easeMode)
            {
                case EaseMode.EaseIn:
                    return 1 - BounceOut(1 - x);
                case EaseMode.EaseOut:
                    return BounceOut(x);
                case EaseMode.EaseInOut:
                    return x < 0.5 ? (1 - BounceOut(1 - 2 * x)) / 2 : (1 + BounceOut(2 * x - 1)) / 2;
                default:
                    return 0;
            }
        }

        private static double BounceOut(double x)
        {
            if (x < 1d / 2.75d) return 7.5625 * x * x;
            else if (x < 2d / 2.75d) return 7.5625 * (x -= 1.5d / 2.75d) * x + 0.75;
            else if (x < 2.5d / 2.75d) return 7.5625 * (x -= 2.25d / 2.75d) * x + 0.9375;
            else return 7.5625 * (x -= 2.625d / 2.75d) * x + 0.984375;
        }



        //----------------------------------------------------------------
        // Cubic functions
        //----------------------------------------------------------------
        /// <summary>The cubic ease-in animation function.</summary>
        /// <param name="t">The time of the animation.</param>
        /// <param name="d">The duration of the animations.</param>
        /// <param name="b">The beging value.</param>
        /// <param name="c">The changed value between starting and ending value.</param>
        /// <returns>The calculated current value of the animation</returns>
        public static double CubicEaseIn(double t, double d, double b, double c)
        {
            t /= d;
            return c*t*t*t + b;
        }

        /// <summary>The cubic ease-in and ease-out animation function.</summary>
        public static double CubicEaseInOut(double t, double d, double b, double c)
        {
            t /= d/2;
            if (t < 1)
                return c/2*t*t*t + b;

            t -= 2;
            return c/2*(t*t*t + 2) + b;
        }

        /// <summary>The cubic ease-out animation function.</summary>
        public static double CubicEaseOut(double t, double d, double b, double c)
        {
            t /= d;
            t--;
            return c*(t*t*t + 1) + b;
        }


        //----------------------------------------------------------------
        // Circular functions
        //----------------------------------------------------------------
        /// <summary>The circular ease-in and ease-out animation function.</summary>
        public static double CircularEaseInOut(double t, double d, double b, double c)
        {
            t /= d/2;
            if (t < 1)
                return (double) (-c/2*(Math.Sqrt(1 - t*t) - 1) + b);
            t -= 2;
            return (double) (c/2*(Math.Sqrt(1 - t*t) + 1) + b);
        }


        /// <summary>The circular ease-in animation function.</summary>
        public static double CircularEaseIn(double t, double d, double b, double c)
        {
            t /= d;
            return (double) (-c*(Math.Sqrt(1 - t*t) - 1) + b);
        }


        /// <summary>The circular ease-out animation function.</summary>
        public static double CircularEaseOut(double t, double d, double b, double c)
        {
            t /= d;
            t--;
            return (double) (c*Math.Sqrt(1 - t*t) + b);
        }


        //----------------------------------------------------------------
        // Quadratic functions
        //----------------------------------------------------------------
        /// <summary>The quadratic ease-in animation function.</summary>
        public static double QuadraticEaseIn(double t, double d, double b, double c)
        {
            t /= d;
            return c*t*t + b;
        }


        /// <summary>The quadratic ease-out animation function.</summary>
        public static double QuadraticEaseOut(double t, double d, double b, double c)
        {
            t /= d;
            return -c*t*(t - 2) + b;
        }


        /// <summary>The quadratic ease-in and ease-out animation function.</summary>
        public static double QuadraticEaseInOut(double t, double d, double b, double c)
        {
            t /= d/2;
            if (t < 1) return c/2*t*t + b;
            t--;
            return -c/2*(t*(t - 2) - 1) + b;
        }

        //----------------------------------------------------------------
        // Quartic functions
        //----------------------------------------------------------------
        /// <summary>The quartic ease-in animation function.</summary>
        public static double QuarticEaseIn(double t, double d, double b, double c)
        {
            t /= d;
            return c*t*t*t*t + b;
        }

        /// <summary>The quartic ease-out animation function.</summary>
        public static double QuarticEaseOut(double t, double d, double b, double c)
        {
            t /= d;
            t--;
            return -c*(t*t*t*t - 1) + b;
        }

        /// <summary>The quartic ease-in and ease-out animation function.</summary>
        public static double QuarticEaseInOut(double t, double d, double b, double c)
        {
            t /= d/2;
            if (t < 1) return c/2*t*t*t*t + b;
            t -= 2;
            return -c/2*(t*t*t*t - 2) + b;
        }

        //----------------------------------------------------------------
        // Quintic functions
        //----------------------------------------------------------------
        /// <summary>The quintic ease-in and ease-out animation function.</summary>
        public static double QuinticEaseInOut(double t, double d, double b, double c)
        {
            t /= d/2;
            if (t < 1) return c/2*t*t*t*t*t + b;
            t -= 2;
            return c/2*(t*t*t*t*t + 2) + b;
        }

        /// <summary>The quintic ease-in animation function.</summary>
        public static double QuinticEaseIn(double t, double d, double b, double c)
        {
            t /= d;
            return c*t*t*t*t*t + b;
        }

        /// <summary>The quintic ease-out animation function.</summary>
        public static double QuinticEaseOut(double t, double d, double b, double c)
        {
            t /= d;
            t--;
            return c*(t*t*t*t*t + 1) + b;
        }

        //----------------------------------------------------------------
        // Sinusoidal functions
        //----------------------------------------------------------------
        /// <summary>The sinusoidal ease-in animation function.</summary>
        public static double SinusoidalEaseIn(double t, double d, double b, double c)
        {
            return (double) (-c*Math.Cos(t/d*(Math.PI/2)) + c + b);
        }

        /// <summary>The sinusoidal ease-out animation function.</summary>
        public static double SinusoidalEaseOut(double t, double d, double b, double c)
        {
            return (double) (c*Math.Sin(t/d*(Math.PI/2)) + b);
        }

        /// <summary>The sinusoidal ease-in and ease-out animation function.</summary>
        public static double SinusoidalEaseInOut(double t, double d, double b, double c)
        {
            return (double) (-c/2*(Math.Cos(Math.PI*t/d) - 1) + b);
        }

        //----------------------------------------------------------------
        // Exponential functions
        //----------------------------------------------------------------
        /// <summary>The exponential ease-in animation function.</summary>
        public static double ExponentialEaseIn(double t, double d, double b, double c)
        {
            return (double) (c*Math.Pow(2, 10*(t/d - 1)) + b);
        }

        /// <summary>The exponential ease-out animation function.</summary>
        public static double ExponentialEaseOut(double t, double d, double b, double c)
        {
            return (double) (c*(-Math.Pow(2, -10*t/d) + 1) + b);
        }


        /// <summary>The exponential ease-in and ease-out animation function.</summary>
        public static double ExponentialEaseInOut(double t, double d, double b, double c)
        {
            t /= d/2;
            if (t < 1)
                return (double) (c/2*Math.Pow(2, 10*(t - 1)) + b);
            t--;
            return (double) (c/2*(-Math.Pow(2, -10*t) + 2) + b);
        }
    }
}