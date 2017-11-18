using System.Windows.Forms;

namespace SBSamplePlugin
{
    public partial class Form1 : Form
    {
        public Form1(string text)
        {
            InitializeComponent();

            richTextBox1.Text = text;
        }
    }
}
