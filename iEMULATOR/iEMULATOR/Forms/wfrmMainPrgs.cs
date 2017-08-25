using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iEMULATOR.Forms
{
    public partial class wfrmMainPrgs : Form
    {
        public wfrmMainPrgs()
        {
            InitializeComponent();
        }

        private void wfrmMainPrgs_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void fill()
        {
            try
            {
                this.pRC_PROGRAMASTableAdapter.Fill(this.dtsEmulator.PRC_PROGRAMAS);
                this.vIEW_PRCPROGRAMASTableAdapter.Fill(this.dtsEmulator.VIEW_PRCPROGRAMAS);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    try
                    {
                        this.pRC_PROGRAMASTableAdapter.insertPRG((int?)this.comboBox1.SelectedValue, this.textBox1.Text, Convert.ToInt32(this.textBox3.Text), Convert.ToInt32(this.textBox4.Text));
                        fill();

                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {
                    MessageBox.Show(this, "Verifíque los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.RowCount > 0)
                {
                    DialogResult result = MessageBox.Show(this, "Está seguro de eliminar este proceso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        this.pRC_PROGRAMASTableAdapter.DeletePRG(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["ID_PRG"].Value));
                        fill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBox1.Checked)
                {
                    this.comboBox1.Enabled = false;
                    this.comboBox1.DataSource = null;
                }
                else
                {
                    this.comboBox1.Enabled = true;
                    this.comboBox1.DataSource = this.pRCPROGRAMASBindingSource;
                    this.comboBox1.ValueMember = "ID_PRG";
                    this.comboBox1.DisplayMember = "NOMBRE";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    this.textBox1.Text = this.dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    this.comboBox1.SelectedValue = this.dataGridView1.CurrentRow.Cells["ID_PRG_MAYOR"].Value;
                    if (this.dataGridView1.CurrentRow.Cells["ID_PRG_MAYOR"].Value.ToString().Trim().Equals(""))
                        this.checkBox1.Checked = true;
                    else
                        this.checkBox1.Checked = false;
                    this.textBox3.Text = this.dataGridView1.CurrentRow.Cells["TIEMPO_CPU"].Value.ToString();
                    this.textBox4.Text = this.dataGridView1.CurrentRow.Cells["PRIORIDAD"].Value.ToString();
                    allowdenied(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void allowdenied(bool bo)
        {
            this.button4.Enabled = !bo;
            this.button5.Enabled = !bo;
            this.dataGridView1.Enabled = bo;
            this.button1.Enabled = bo;
            this.button2.Enabled = bo;
            this.button3.Enabled = bo;
        }

        private void clear()
        {
            this.textBox1.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    this.pRC_PROGRAMASTableAdapter.updatePRG((int?)this.comboBox1.SelectedValue, this.textBox1.Text, Convert.ToInt32(this.textBox3.Text), Convert.ToInt32(this.textBox4.Text), (int)this.dataGridView1.CurrentRow.Cells["ID_PRG"].Value);
                    allowdenied(true);
                    fill();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "Verifíque los datos Ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            allowdenied(true);
            clear();
        }

        private bool validate()
        {
            if (this.textBox1.Text.Trim().Equals("") || this.textBox1.Text.Trim().Equals(null))
                return false;
            else
            {
                if (this.textBox3.Text.Trim().Equals("") || this.textBox1.Text.Trim().Equals(null))
                    return false;
                else
                {
                    if (this.textBox4.Text.Trim().Equals("") || this.textBox1.Text.Trim().Equals(null))
                        return false;
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}
