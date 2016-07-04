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
    public partial class Form2 : Form
    {
        Bitmap imagePreview = Form1.imagePreview;

        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = imagePreview;
        }
    }
}
