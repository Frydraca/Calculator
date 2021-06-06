using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorApp : Form
    {
        private CompositionContainer _container;

        [Import(typeof(ICalculator))]
        private Calculator calculator;
        public CalculatorApp()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            // An aggregate catalog that combines multiple catalogs.
            var catalog = new AggregateCatalog();
            // Adds all the parts found in the same assembly as the Program class.
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(Program).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog("..\\..\\Operations"));

            // Create the CompositionContainer with the parts in the catalog.
            _container = new CompositionContainer(catalog);

            // Fill the imports of this object.
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }

        #region Button OnClick Definitions
        private void button1_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "0";
        }

        private void buttonLeftParenthesis_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "(";
        }

        private void buttonRightParenthesis_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += ")";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (this.ScreenText.Text.Length > 1)
            {
                this.ScreenText.Text = this.ScreenText.Text.Substring(0, this.ScreenText.Text.Length - 1);
            }
            else { this.ScreenText.Text = ""; }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text = calculator.Calculate(this.ScreenText.Text);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += ".";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "/";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.ScreenText.Text += "-";
        }
        #endregion
    }
}
