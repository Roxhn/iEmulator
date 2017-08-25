using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iEMULATOR.Forms;

namespace iEMULATOR.Forms
{
    public partial class wfrmSO : Form
    {
        private int _newmem;
        private int _newhdd;
        private int _newtype;
        private bool conf;
        public wfrmSO()
        {
            InitializeComponent();
        }

        public wfrmSO(int mem, int hdd, int type)
        {
            InitializeComponent();
            try
            {
                this.textBox1.Text = mem.ToString();
                this.textBox2.Text = hdd.ToString();
                this.comboBox1.SelectedIndex = 0;
                conf = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool getConfirm()
        {
            return conf;
        }

        public int getMem()
        {
            return _newmem;
        }

        public int getHdd()
        {
            return _newhdd;
        }

        public int getType()
        {
            return _newtype;
        }

        private void wfrmSO_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _newmem = Convert.ToInt32(this.textBox1.Text.ToString());
                _newhdd = Convert.ToInt32(this.textBox2.Text.ToString());
                _newtype = (int)this.comboBox1.SelectedIndex;
                conf = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conf = false;
            this.Close();
        }
    }
}
