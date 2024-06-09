using App.Animations;
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
        Animator anim0, anim1, anim2, anim3;

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
        // Stop
        //-------------------------------------------------------
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopAnims();
        }

        private void StopAnims()
        {
            anim0?.Stop();
            anim1?.Stop();
            anim2?.Stop();
            anim3?.Stop();
        }

        //-------------------------------------------------------
        // Run animation
        //-------------------------------------------------------
        // Animation on x
        private void btnAnimX_Click(object sender, EventArgs e)
        {
            anim0?.Stop();
            var start = 100;  // x
            var end   = 300;
            var type1 = GetEnum<EasingType>(cmbType1);
            var type2 = GetEnum<EasingType>(cmbType2);
            var dur1 = (long)numDur1.Value;
            var dur2 = (long)numDur2.Value;
            var wait = (long)numWait.Value;
            var interval = (int)numInterval.Value;
            var infinity = this.chkInfinity.Checked;
            anim0 = new Animator(this.chkInfinity.Checked)
                .AddPath(type1, start, end, dur1)
                .AddPath(type2, end, start, dur2)
                .SetInterval(interval)
                .SetWait(wait)
                .SetInfinity(infinity)
                .SetFrameEvent((values) =>
                {
                    Action action = () => {
                        block.Left = (int)values[0];
                        ShowBlockInfo();
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
            anim0?.Stop();
            var start = new List<double> { 100, 10 };  // x, y
            var end   = new List<double> { 300, 100 };
            var type1 = GetEnum<EasingType>(cmbType1);
            var type2 = GetEnum<EasingType>(cmbType2);
            var dur1 = (long)numDur1.Value;
            var dur2 = (long)numDur2.Value;
            var wait = (long)numWait.Value;
            var interval = (int)numInterval.Value;
            var infinity = this.chkInfinity.Checked;
            anim0 = new Animator(this.chkInfinity.Checked)
                .SetInterval((int)numInterval.Value)
                .AddPath(type1, start, end, dur1)
                .AddPath(type2, end, start, dur2)
                .SetInterval(interval)
                .SetWait(wait)
                .SetInfinity(infinity)
                .SetFrameEvent((values) =>
                {
                    Action action = () => {
                        block.Left = (int)values[0];
                        block.Top  = (int)values[1];
                        ShowBlockInfo();
                    };
                    this.Invoke(action);
                })
                .SetEndEvent((values) => Trace.WriteLine("Animaion end."))
                .Start();
        }

        // Animation on color
        private void btnAnimColor_Click(object sender, EventArgs e)
        {
            anim0?.Stop();
            var start = new List<double> { 255, 0, 0 };        // r, g, b
            var end   = new List<double> { 0, 255, 255 };
            var type1 = GetEnum<EasingType>(cmbType1);
            var type2 = GetEnum<EasingType>(cmbType2);
            var dur1 = (long)numDur1.Value;
            var dur2 = (long)numDur2.Value;
            var wait = (long)numWait.Value;
            var interval = (int)numInterval.Value;
            var infinity = this.chkInfinity.Checked;
            anim0 = new Animator(this.chkInfinity.Checked)
                .SetInterval((int)numInterval.Value)
                .AddPath(type1, start, end, dur1)
                .AddPath(type2, end, start, dur2)
                .SetInterval(interval)
                .SetWait(wait)
                .SetInfinity(infinity)
                .SetFrameEvent((values) =>
                {
                    Action action = () => {
                        block.BackColor = ToColor(values);
                        ShowBlockInfo();
                    };
                    this.Invoke(action);
                })
                .SetEndEvent((values)=>
                {
                    Action action = () => {
                        block.BackColor = ToColor(values);
                        ShowBlockInfo();
                    };
                    this.Invoke(action);
                })
                .Start()
                ;
        }

        //-------------------------------------------------------
        // Run animation method 2
        //-------------------------------------------------------
        private void btnAnim1_Click(object sender, EventArgs e)
        {
            StopAnims();
            //anim1 = this.block.MoveTo(new Point(150, 50), 1000, EasingType.Linear);
            anim1 = this.block.MoveTo(new Point(70, 100), new Point(150, 50), 1000, EasingType.Linear);
        }

        private void btnAnim2_Click(object sender, EventArgs e)
        {
            StopAnims();
            var startColor = new List<double> { 255, 0, 0 };
            var endColor = new List<double> { 0, 255, 255 };
            anim2 = this.block.Animate(startColor, endColor, 1000, (t, vs) => t.BackColor = ToColor(vs));
        }

        private void btnAnim3_Click(object sender, EventArgs e)
        {
            StopAnims();
            anim3 = this.picBg.Animate(500, -50, 1000, t => t.Left, infinity: true);  //
        }

        private void btnAnim4_Click(object sender, EventArgs e)
        {
            StopAnims();
            var startColor = new List<double> { 255, 0, 0 };
            var endColor = new List<double> { 0, 255, 255 };
            anim1 = this.block.MoveTo(new Point(70, 100), new Point(150, 50), 1000, EasingType.Linear);     // use moveto extension to apply animation.
            anim2 = this.block.Animate(startColor, endColor, 1000, (t, vs) => t.BackColor = ToColor(vs));   // use callback to modify property.
            anim3 = this.picBg.Animate(500, -50, 1000, t => t.Left, infinity: true);                        // assign property to be modified during animatin.
        }

        //-------------------------------------------------------
        // Utils
        //-------------------------------------------------------
        Color ToColor(List<double> values)
        {
            return Color.FromArgb(Limit(values[0]), Limit(values[1]), Limit(values[2]));
        }

        int Limit(double v, int min=0, int max=255)
        {
            if (v < min) return min;
            if (v > max) return max;
            return (int)v;
        }

        void ShowBlockInfo()
        {
            this.lblPos.Text = string.Format("({0}, {1})", block.Left, block.Top);
            this.lblColor.Text = string.Format("({0}, {1}, {2})", block.BackColor.R, block.BackColor.G, block.BackColor.B);
        }


    }
}
