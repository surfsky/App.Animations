using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Animations
{
    /// <summary>
    /// 动画导演。可容纳多个动画同时有序的进行。
    /// </summary>
    public class AnimationDirector
    {
        public List<Animator> Animators { get; set; } = new List<Animator>();

        public void Run()
        {
            foreach(var animator in Animators)
            {
                animator.Stop();
                animator.Start();
            }
        }

    }
}
