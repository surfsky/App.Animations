﻿using System;
using System.Collections.Generic;

namespace App.Animations
{
    /// <summary>
    ///     Animatoin path
    /// </summary>
    public class Path
    {
        EasingAnimation _ani;

        /// <summary>Gets or sets the starting value</summary>
        public List<double> Start { get; set; }

        /// <summary>Gets or sets the ending value</summary>
        public List<double> End { get; set; }

        /// <summary>Gets or sets the duration in milliseconds</summary>
        public long Duration { get; set; }

        /// <summary>Gets animation easing type</summary>
        public EasingType Type => _ani.Type;


        //---------------------------------------------------------
        // Constructor
        //---------------------------------------------------------
        /// <summary>Initializes a new instance of the <see cref="Path" /> class.</summary>
        public Path(EasingType type, double start, double end, long duration)
            : this(type, new List<double> { start }, new List<double> { end }, duration)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Path" /> class.</summary>
        public Path(EasingType type, List<double> start, List<double> end, long duration)
        {
            Start = start;
            End = end;
            Duration = duration;
            _ani = new EasingAnimation(type);
        }

        /// <summary>Creates and returns a new <see cref="Path" /> based on the current path but in reverse order</summary>
        /// <returns>A new <see cref="Path" /> which is the reverse of the current <see cref="Path" /></returns>
        public Path Reverse()
        {
            return new Path(Type, End, Start, Duration);
        }


        //---------------------------------------------------------
        // Functions
        //---------------------------------------------------------
        public List<double> GetValues(double time)
        {
            var result = new List<double>();
            for(int i = 0; i< Start.Count; i++)
            {
                var val = _ani.GetValue(time, this.Duration, this.Start[i], this.End[i] - this.Start[i]);
                result.Add(val);
            }
            return result;
        }

        public double GetValue(double time)
        {
            return GetValues(time)[0];
        }
    }
}