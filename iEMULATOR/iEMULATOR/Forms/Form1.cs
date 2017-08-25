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

namespace iEMULATOR
{
    public partial class Form1 : Form
    {
        public int _mbMemory;
        public int _mbHDD;
        public int _typeAlgorithm;
        public Form1()
        {
            InitializeComponent();
            _mbMemory = 0;
            _mbHDD = 0;
            _typeAlgorithm = 0;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entradasSalidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new wfrmMainIO().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void programasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new wfrmMainPrgs().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                new wfrmStart(_typeAlgorithm).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new wfrmStart(_typeAlgorithm).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                new wfrmMainIO().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                new wfrmMainPrgs().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SO();
        }

        private void configuraciónSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SO()
        {
            try
            {
                wfrmSO frm = new wfrmSO(_mbMemory, _mbHDD, _typeAlgorithm);
                frm.ShowDialog();
                if (frm.getConfirm())
                {
                    _mbMemory = frm.getMem();
                    _mbHDD = frm.getHdd();
                    _typeAlgorithm = frm.getType();
                    this.label1.Text = _mbMemory.ToString();
                    this.label1.Font = new Font(label1.Font.FontFamily, 20 - (2 * _mbMemory.ToString().Length),
                        FontStyle.Bold);


                    this.label4.Text = _mbHDD.ToString();
                    this.label4.Font = new Font(label4.Font.FontFamily, 20 - (2 * _mbHDD.ToString().Length),
                        FontStyle.Bold);
                    this.label6.Text = (_typeAlgorithm + 1).ToString();
                    switch (_typeAlgorithm)
                    {
                        case 0: label7.Text = "Lotes"; break;
                        case 1: label7.Text = "Esc. Prioridad"; break;
                        case 2: label7.Text = "Round Robbin"; break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
