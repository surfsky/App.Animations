using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace App.Animations
{
    /// <summary>
    /// 动画控制器
    /// </summary>
    public class Animator
    {
        //
        bool _running = false;
        DateTime _start;


        //-------------------------------------------------------
        // Public properties and event
        //-------------------------------------------------------
        public List<Path> Paths { get; set; } = new List<Path>();
        public Thread Thread { get; set; }
        public int Interval { get; set; } = 10;
        public bool Infinity { get; set; } = false;

        // events
        public Action<List<double>> Frame;
        public Action<List<double>> End;



        //-------------------------------------------------------
        // Constructor
        //-------------------------------------------------------
        public Animator() { }
        public Animator(bool infinity)
        {
            this.Infinity = infinity;
        }

        //-------------------------------------------------------
        // Fluent API
        //-------------------------------------------------------
        public Animator AddPath(EasingType type, double start, double end, long duration)
        {
            this.Paths.Add(new Path(type, start, end, duration));
            return this;
        }
        public Animator AddPath(EasingType type, List<double> start, List<double> end, long duration)
        {
            this.Paths.Add(new Path(type, start, end, duration));
            return this;
        }

        public Animator SetInterval(int interval)
        {
            this.Interval = (int)interval;
            return this;
        }

        public Animator SetFrameEvent(Action<List<double>> action) 
        { 
            this.Frame = action; 
            return this;
        }
        public Animator SetEndEvent(Action<List<double>> action) 
        { 
            this.End = action; 
            return this;
        }

        //-------------------------------------------------------
        // Animate
        //-------------------------------------------------------
        public Animator Start()
        {
            _running = true;
            _start = DateTime.Now;
            new Thread(() =>Loop()).Start();
            return this;
        }

        public Animator Stop()
        {
            Infinity = false;
            _running = false;
            return this;
        }

        void Loop()
        {
            while (_running)
            {
                var ms = (long)(DateTime.Now - _start).TotalMilliseconds;  // 总耗时
                var pathId = FindCurrentPath(ms, out long pathMs);
                if (pathId == -1)
                {
                    if (Infinity)
                    {
                        _start = DateTime.Now;
                        continue;
                    }
                    break;
                }
                else
                {
                    var path = this.Paths[pathId];
                    var values = path.GetValues(pathMs);
                    Frame?.Invoke(values);
                    Trace.WriteLine(string.Format("Time={0}, Path={1}, PathType={2}, Values=({3})", ms, pathId, path.Type, ToJoinString(values)));
                }
                Thread.Sleep(Interval);
            }

            // 触发结束事件
            var endValues = Paths.Last().End;
            End?.Invoke(endValues);
        }

        string ToJoinString(List<double> values)
        {
            var sb = new StringBuilder();
            foreach (var v in values)
                sb.Append(v).Append(", ");
            return sb.ToString().TrimEnd(' ', ',');
        }

        /// <summary>找到当前运行的路径ID</summary>
        /// <param name="ms">已经过去的毫秒</param>
        /// <param name="pathMs">在当前路径下执行的毫秒数</param>
        private int FindCurrentPath(long ms, out long pathMs)
        {
            pathMs = 0;
            long total = 0;
            for (int i = 0; i< this.Paths.Count; i++)
            {
                pathMs = ms - total;
                total += Paths[i].Duration;
                if (ms <= total)
                    return i;
            }
            return -1;
        }
    }
}
