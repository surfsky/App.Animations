using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace App.Animations
{
    /// <summary>
    /// 动画扩展方法
    /// </summary>
    public static class AnimatorExtension
    {
        /// <summary>
        /// Build animation by assigning changing property. The method just supports simple-writable property.
        /// something.Animate(100, 200, 1000, t=>t.Top);
        /// </summary>
        /// <param name="back">If true, the object will animate back to the origin</param>
        public static Animator Animate<T, TValue>(
            this T obj,
            double startValue,
            double endValue,
            long duration,
            Expression<Func<T, TValue>> property,
            EasingType easingType = EasingType.Linear,
            long wait = 0,
            int interval = 10,
            bool autoStart = true,
            bool infinity = false,
            bool back = false
            )
        {
            var propertyInfo = obj.GetPropertyInfo(property);
            var ani = new Animator()
                .AddPath(easingType, startValue, endValue, duration)
                .SetWait(wait)
                .SetInterval(interval)
                .SetInfinity(infinity)
                .SetFrameEvent((values) =>
                {
                    Action action = () => {
                        TValue value = (TValue)Convert.ChangeType(values[0], typeof(TValue));
                        propertyInfo.SetValue(obj, value, null);
                    };
                    SafeInvoke(obj, action);
                })
                .SetEndEvent((values) =>
                {
                    Action action = () => {
                        TValue value = (TValue)Convert.ChangeType(values[0], typeof(TValue));
                        propertyInfo.SetValue(obj, value, null);
                    };
                    SafeInvoke(obj, action);
                })
                ;
            if (back)
                ani.AddReversePaths();
            if (autoStart)
                ani.Start();
            return ani;
        }

        /// <summary>
        /// Build animation with callback.
        /// something.Animate(100, 200, 1000, t=>t.Top=(int)value);
        /// </summary>
        /// <param name="back">If true, the object will animate back to the origin</param>
        public static Animator Animate<T>(
            this T obj,
            double startValue, 
            double endValue, 
            long duration, 
            Action<T, double> onFrame,
            EasingType easingType=EasingType.Linear,
            long wait = 0, 
            int interval = 10,
            bool autoStart=true,
            bool infinity=false,
            bool back = false
            )
        {
            var ani = new Animator()
                .AddPath(easingType, startValue, endValue, duration)
                .SetWait(wait)
                .SetInterval(interval)
                .SetInfinity(infinity)
                .SetFrameEvent((values) =>
                {
                    Action action = () => onFrame(obj, (double)values[0]);
                    SafeInvoke(obj, action);
                })
                .SetEndEvent((values) =>
                {
                    Action action = () => onFrame(obj, (double)values[0]);
                    SafeInvoke(obj, action);
                })
                ;
            if (back)
                ani.AddReversePaths();
            if (autoStart)
                ani.Start();
            return ani;
        }

        /// <summary>
        /// Build animation with callback.
        /// something.Animate(100, 200, 1000, t=>t.Top=(int)value);
        /// </summary>
        /// <param name="easingFunc">Custom easing funcion. The input arg is between 0.0-1.0</param>
        /// <param name="back">If true, the object will animate back to the origin</param>
        public static Animator Animate<T>(
            this T obj,
            double startValue,
            double endValue,
            long duration,
            Action<T, double> onFrame,
            Func<double, double> easingFunc,
            long wait = 0,
            int interval = 10,
            bool autoStart = true,
            bool infinity = false,
            bool back = false
            )
        {
            var ani = new Animator()
                .AddPath(easingFunc, startValue, endValue, duration)
                .SetWait(wait)
                .SetInterval(interval)
                .SetInfinity(infinity)
                .SetFrameEvent((values) =>
                {
                    Action action = () => onFrame(obj, (double)values[0]);
                    SafeInvoke(obj, action);
                })
                .SetEndEvent((values) =>
                {
                    Action action = () => onFrame(obj, (double)values[0]);
                    SafeInvoke(obj, action);
                })
                ;
            if (back)
                ani.AddReversePaths();
            if (autoStart)
                ani.Start();
            return ani;
        }

        /// <summary>
        /// Build animation with callback.
        /// something.Animate([0,0], [200,100], 1000, t=>{t.Left=(int)value[0], t.Top=(int)values[1]});
        /// </summary>
        /// <param name="back">If true, the object will animate back to the origin</param>
        public static Animator Animate<T>(
            this T obj,
            List<double> startValues, 
            List<double> endValues, 
            long duration,
            Action<T, List<double>> onFrame,
            EasingType easingType = EasingType.Linear,
            long wait = 0,
            int interval = 10,
            bool autoStart = true,
            bool infinity = false,
            bool back = false
            )
        {
            var ani = new Animator()
                .AddPath(easingType, startValues, endValues, duration)
                .SetInfinity(infinity)
                .SetInterval(interval)
                .SetWait(wait)
                .SetFrameEvent((values) =>
                {
                    Action action = () => onFrame(obj, values);
                    SafeInvoke(obj, action);
                })
                .SetEndEvent((values) =>
                {
                    Action action = () => onFrame(obj, values);
                    SafeInvoke(obj, action);
                })
                ;
            if (back)
                ani.AddReversePaths();
            if (autoStart)
                ani.Start();
            return ani;
        }

        /// <summary>
        /// Build animation with callback.
        /// something.Animate([0,0], [200,100], 1000, t=>{t.Left=(int)value[0], t.Top=(int)values[1]});
        /// </summary>
        /// <param name="easingFunc">Custom easing funcion. The input arg is between 0.0-1.0</param>
        /// <param name="back">If true, the object will animate back to the origin</param>
        public static Animator Animate<T>(
            this T obj,
            List<double> startValues,
            List<double> endValues,
            long duration,
            Action<T, List<double>> onFrame,
            Func<double, double> easingFunc,
            long wait = 0,
            int interval = 10,
            bool autoStart = true,
            bool infinity = false,
            bool back = false
            )
        {
            var ani = new Animator()
                .AddPath(easingFunc, startValues, endValues, duration)
                .SetInfinity(infinity)
                .SetInterval(interval)
                .SetWait(wait)
                .SetFrameEvent((values) =>
                {
                    Action action = () => onFrame(obj, values);
                    SafeInvoke(obj, action);
                })
                .SetEndEvent((values) =>
                {
                    Action action = () => onFrame(obj, values);
                    SafeInvoke(obj, action);
                })
                ;
            if (back)
                ani.AddReversePaths();
            if (autoStart)
                ani.Start();
            return ani;
        }

        /// <summary>UI 线程安全调用</summary>
        private static void SafeInvoke<T>(T obj, Action action)
        {
            var type = obj.GetType();
            if (type.IsType("System.Windows.Forms.Control"))
            {
                // winform need: obj.Invoke(action)
                var method = type.GetMethodInfo("Invoke");
                method.Invoke(obj, new object[] { action });
            }
            else
                action();
        }
    }
}
