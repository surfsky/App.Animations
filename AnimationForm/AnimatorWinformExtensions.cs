using App.Animations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationForm
{
    public static class AnimatorWinformExtensions
    {
        /// <summary>Build a moving animation</summary>
        public static Animator MoveTo(
            this Control ctrl, 
            Point endPt, 
            long duration, 
            EasingType easingType=EasingType.CubicEaseOut,
            bool back = false
            )
        {
            return MoveTo(ctrl, ctrl.Location, endPt, duration);
        }

        /// <summary>Build a moving animation</summary>
        public static Animator MoveTo(
            this Control ctrl,
            Point startPt, 
            Point endPt, 
            long duration, 
            EasingType easingType = EasingType.CubicEaseOut,
            bool back = false
            )
        {
            var startValues = new List<double> { startPt.X, startPt.Y};
            var endValues   = new List<double> {  endPt.X, endPt.Y };
            var anim = ctrl.Animate(startValues, endValues, duration, (t, vs) => {
                    t.Left = (int)vs[0];
                    t.Top = (int)vs[1];
                },
                easingType,
                back: back
                );
            return anim;

        }
    }
}
