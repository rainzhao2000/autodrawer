using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDrawer
{
    public partial class Form3 : Form
    {
        public static int pathInt;
        string input;

        public Form3()
        {
            InitializeComponent();
            Show();
        }

        private void pathInput_TextChanged(object sender, EventArgs e)
        {
            input = pathInput.Text;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                pathInt = Convert.ToInt32(input);
                pathInt = int.Parse(input);
                if (pathInt.ToString().Length < 8)
                    throw new Exception();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(new Form() { TopMost = true }, "Please enter a sequence of 8 integers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
