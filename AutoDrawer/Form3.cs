using System;
using System.Data;
using System.Linq;
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
                var digits = pathInt.ToString().Select(t => int.Parse(t.ToString())).ToArray();
                foreach (int item in digits)
                {
                    if (item == 9 | item == 0)
                    {
                        throw new Exception();
                    }
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(new Form() { TopMost = true }, "Please enter a sequence of 8 integers from 1-8", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
