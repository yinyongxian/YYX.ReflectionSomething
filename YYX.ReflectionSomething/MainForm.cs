using System;
using System.Linq;
using System.Windows.Forms;
using YYX.ReflectionSomething.Classes;
using YYX.ReflectionSomething.Interfaces;

namespace YYX.ReflectionSomething
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            var bases = DerivedClassesFinder.Find<Base>();
            var firstClass = bases.ToList()[0];

            var interfaces = ImplementInterfaceFinder.Find<IPerson>();
            var firstinterfaces = interfaces.ToList()[0];
        }
    }
}
