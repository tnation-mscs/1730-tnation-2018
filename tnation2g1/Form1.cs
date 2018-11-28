using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tnation2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 1a) 'Switch' with no default
            resultSwitch01TextBox.Text = Ex2hStringUnitTests.Switch01(input1aTextBox.Text);

            // 1b) Seperate 'if' statements
            resultIf01TextBox.Text = Ex2hStringUnitTests.If01(input1aTextBox.Text);

            // 1c) if elseif
            resultElseIf01TextBox.Text = Ex2hStringUnitTests.ElseIf01(input1aTextBox.Text);

            // 1d) Nested if-else
            resultNestedIfElse01TextBox.Text = Ex2hStringUnitTests.NestedIfElse01(input1aTextBox.Text);

            // 1e) 'Switch' with no default
            resultSwitchDefault01TextBox.Text = Ex2hStringUnitTests.SwitchDefault01(input1aTextBox.Text);

            // 1f) Seperate 'if' statements, default value 0
            resultIfDefault01TextBox.Text = Ex2hStringUnitTests.IfDefault01(input1aTextBox.Text);

            // 1g) if elseif with default
            resultElseIfDefault01TextBox.Text = Ex2hStringUnitTests.ElseIfDefault01(input1aTextBox.Text);

            // 1h) Nested if-else with default
            resultNestedIfElseDefault01TextBox.Text = Ex2hStringUnitTests.NestedIfElseDefault01(input1aTextBox.Text);

            // 2a) 'Switch' with no default
            resultSwitch02TextBox.Text = Ex2hStringUnitTests.Switch02(input2aTextBox.Text);

            // 1f) Seperate 'if' statements, default value 0
            resultIf02TextBox.Text = Ex2hStringUnitTests.If02(input2aTextBox.Text);

            // 2c) if elseif
            resultElseIf02TextBox.Text = Ex2hStringUnitTests.ElseIf02(input2aTextBox.Text);

            // 2d) Nested if-else
            resultNestedIfElse02TextBox.Text = Ex2hStringUnitTests.NestedIfElse02(input2aTextBox.Text);
        }

    }
}
