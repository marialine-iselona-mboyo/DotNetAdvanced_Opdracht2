using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        Koe koe1 = new Koe();
        Slang slang1 = new Slang();
        Varken varken1 = new Varken();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbKoe.Checked)
            {
                MessageBox.Show(koe1.Zegt());
                koe1.KoeSound();
            } 
            else if (cbSlang.Checked)
            {
                MessageBox.Show(slang1.Zegt());
                slang1.SlangSound();
            } 
            else if (cbVarken.Checked)
            {
                MessageBox.Show(varken1.Zegt());
                varken1.VarkenSound();
            }
            else
            {
                MessageBox.Show("Did not select anything!");
            }
        }
    }
}