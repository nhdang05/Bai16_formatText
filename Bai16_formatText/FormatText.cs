using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16_formatText
{
    public partial class FormatText : Form
    {
        public FormatText()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           raRed.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            raBlue.ForeColor = Color.Blue;
            txtNhapten.ForeColor = Color.Blue;
        }

        private void FormatText_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_Changed(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, chkItalic.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Bold);
            txtNhapten.Font = new Font(txtNhapten.Font.Name, txtNhapten.Font.Size, txtNhapten.Font.Style ^ FontStyle.Bold);
        }

        private void raGreen_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Green;
            txtNhapten.ForeColor = Color.Green;
        }

        private void raBlack_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Black;
            txtNhapten.ForeColor = Color.Black;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Italic);
            txtNhapten.Font = new Font(txtNhapten.Font.Name, txtNhapten.Font.Size, txtNhapten.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(txtNhapten.Font.Name, txtNhapten.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Underline);
            txtNhapten.Font = new Font(txtNhapten.Font.Name, txtNhapten.Font.Size, txtNhapten.Font.Style ^ FontStyle.Underline);
        }

        private void lblLapTrinh_Click(object sender, EventArgs e)
        {

        }
    }
}