using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace App.Animations
{
    /// <summary>
    /// 动画扩展方法
    /// </summary>
    public static class AnimateExtension
    {
        /// <summary>
        /// something.Animate(t=>t.Top, 100, 200, 1000, Linear);
        /// 不支持复杂属性，或复杂对象。
        /// </summary>
        public static Animator Animate<T,TValue>(this T obj, Expression<Func<T, TValue>> property, double startValue, double endValue, long duration, EasingType easingType= EasingType.Linear, long wait=0)
        {
            var propertyInfo = obj.GetPropertyInfo(property);
            return new Animator()
                .AddPath(easingType, startValue, endValue, duration)
                .SetWait(wait)
                .SetFrameEvent((values) =>
                {
                    Action action = () => {
                        TValue value = (TValue)Convert.ChangeType(values[0], typeof(TValue));
                        propertyInfo.SetValue(obj, value, null);
                    };
                    SafeInvoke(obj, action);
                })
                .Start()
                ;
        }

        /// <summary>
        /// something.Animate(100, 200, 1000, Linear, t=>t.Top=(int)value);
        /// </summary>
        public static Animator Animate<T>(
            this T obj,
            EasingType easingType,
            double startValue, double endValue, long duration, 
            Action<T, double> onFrame, 
            long wait = 0, 
            int interval = 10,
            bool autoStart=true,
            bool infinity=false
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
                ;
            if (autoStart)
                ani.Start();
            return ani;
        }

        /// <summary>
        /// something.Animate([0,0], [200,100], 1000, Linear, t=>{t.Left=(int)value[0], t.Top=(int)values[1]});
        /// </summary>
        public static Animator Animate<T>(
            this T obj,
            EasingType easingType,
            List<double> startValues, List<double> endValues, long duration,
            Action<T, List<double>> onFrame,
            long wait = 0,
            int interval = 10,
            bool autoStart = true,
            bool infinity = false
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
                ;
            if (autoStart)
                ani.Start();
            return ani;
        }

        /// <summary>UI 线程安全调用</summary>
        private static void SafeInvoke<T>(T obj, Action action)
        {
            // winform need: obj.Invoke(action)
            var type = obj.GetType();
            if (type.IsType("System.Windows.Forms.Control"))
            {
                var method = type.GetMethodInfo("Invoke");
                method.Invoke(obj, new object[] { action });
            }
            else
                action();
        }
    }
}
