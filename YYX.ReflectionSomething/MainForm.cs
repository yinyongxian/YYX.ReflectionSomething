using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YYX.ReflectionSomething.Classes;

namespace YYX.ReflectionSomething
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var bases = DerivedClassesFinder.Find<Base>();
            var x = bases.ToList()[0];
        }
    }
}
