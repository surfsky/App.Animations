﻿using App.Animations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;

namespace AnimationForm
{
    public partial class Form1 : Form
    {
        Animator _ani;

        //-------------------------------------------------------
        // Init
        //-------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            BindEnum(this.cmbType1, typeof(EasingType));
            BindEnum(this.cmbType2, typeof(EasingType));
        }

        //-------------------------------------------------------
        // Combobox <-> Enum
        //-------------------------------------------------------
        void BindEnum(ComboBox cmb, Type enumType)
        {
            var infos = enumType.GetEnumInfos();
            cmb.Items.Clear();
            foreach (var info in infos)
            {
                cmb.Items.Add(info);
            }
            cmb.SelectedIndex = 0;
        }

        T GetEnum<T>(ComboBox cmb) where T : Enum
        {
            return (T)(cmb.SelectedItem as EnumInfo).Value;
        }

        //-------------------------------------------------------
        // Run
        //-------------------------------------------------------
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_ani != null)
                _ani.Stop();
        }

        // Animation on x
        private void btnAnimX_Click(object sender, EventArgs e)
        {
            var start = 100;  // x
            var end   = 300;
            var type1 = GetEnum<EasingType>(cmbType1);
            var type2 = GetEnum<EasingType>(cmbType2);
            var dur1 = (long)numDur1.Value;
            var dur2 = (long)numDur2.Value;
            _ani = new Animator()
                .SetInterval((int)numInterval.Value)
                .AddPath(type1, start, end, dur1)
                .AddPath(type2, end, start, dur2)
                .SetFrameEvent((values) =>
                {
                    Action action = () => {
                        label1.Left = (int)values[0];
                        label1.Text = string.Format("{0:000}", values[0]);
                    };
                    this.Invoke(action);
                })
                .SetEndEvent((_) => Trace.WriteLine("Animation end."))
                .Start()
                ;
        }


        // Animation on y
        private void btnAnimXY_Click(object sender, EventArgs e)
        {
            var start = new List<double> { 100, 10 };  // x, y
            var end   = new List<double> { 300, 100 };
            var type1 = GetEnum<EasingType>(cmbType1);
            var type2 = GetEnum<EasingType>(cmbType2);
            var dur1 = (long)numDur1.Value;
            var dur2 = (long)numDur2.Value;
            _ani = new Animator()
                .SetInterval((int)numInterval.Value)
                .AddPath(type1, start, end, dur1)
                .AddPath(type2, end, start, dur2)
                .SetFrameEvent((values) =>
                {
                    Action action = () => {
                        label1.Left = (int)values[0];
                        label1.Top = (int)values[1];
                        label1.Text = string.Format("({0:000},{1:000})", values[0], values[1]);
                    };
                    this.Invoke(action);
                })
                .SetEndEvent((values) => Trace.WriteLine("Animaion end."))
                .Start();
        }

        // Animation on color
        private void btnAnimColor_Click(object sender, EventArgs e)
        {
            var start = new List<double> { 255, 0, 0 };        // r, g, b
            var end   = new List<double> { 0, 255, 255 };
            var type1 = GetEnum<EasingType>(cmbType1);
            var type2 = GetEnum<EasingType>(cmbType2);
            var dur1 = (long)numDur1.Value;
            var dur2 = (long)numDur2.Value;
            _ani = new Animator()
                .SetInterval((int)numInterval.Value)
                .AddPath(type1, start, end, dur1)
                .AddPath(type2, end, start, dur2)
                .SetFrameEvent((values) =>
                {
                    Action action = () => {
                        label1.ForeColor = Color.FromArgb(Limit(values[0]), Limit(values[1]), Limit(values[2]));
                        label1.Text = string.Format("({0:0},{1:0},{2:0})", values[0], values[1], values[2]);
                    };
                    this.Invoke(action);
                })
                .SetEndEvent((values)=>
                {
                    Action action = () => {
                        label1.ForeColor = Color.FromArgb(Limit(values[0]), Limit(values[1]), Limit(values[2]));
                        label1.Text = string.Format("({0:0},{1:0},{2:0})", values[0], values[1], values[2]);
                    };
                    this.Invoke(action);
                })
                .Start()
                ;
        }

        int Limit(double v, int min=0, int max=255)
        {
            if (v < min) return min;
            if (v > max) return max;
            return (int)v;
        }
    }
}