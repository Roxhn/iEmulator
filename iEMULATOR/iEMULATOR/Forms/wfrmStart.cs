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
    public partial class wfrmStart : Form
    {
        private int _codigo_algoritmo;
        private int tiempo_llegada;
        private bool stop;
        public wfrmStart()
        {
            InitializeComponent();
        }

        public wfrmStart(int codigo_algoritmo)
        {
            _codigo_algoritmo = codigo_algoritmo;
            InitializeComponent();
            this.textBox1.Text = "1";
            tiempo_llegada = 0;
            stop = false;
        }

        private void wfrmStart_Load(object sender, EventArgs e)
        {
            Terminator();
            try
            {
                this.tMP_PRIORIDADESTableAdapter.Fill(this.dtsEmulator.TMP_PRIORIDADES);
                this.view_ROUND_ROBBINTableAdapter.Fill(this.dtsEmulator.View_ROUND_ROBBIN);
                this.view_PRIORIDADESTableAdapter.Fill(this.dtsEmulator.View_PRIORIDADES);
                this.pROCESOS_ACTUALESTableAdapter.Fill(this.dtsEmulator.PROCESOS_ACTUALES);
                this.view_BLOQUEOTableAdapter.Fill(this.dtsEmulator.View_BLOQUEO);
                this.view_EJECUCIONTableAdapter.Fill(this.dtsEmulator.View_EJECUCION);
                ContextMenu cm = new ContextMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                fill();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fill()
        {
            try
            {
                this.pROCESOS_ACTUALESTableAdapter.Fill(this.dtsEmulator.PROCESOS_ACTUALES);
                this.pRC_PROGRAMASTableAdapter.Fill(this.dtsEmulator.PRC_PROGRAMAS);
                this.pRC_IOTableAdapter.Fill(this.dtsEmulator.PRC_IO);
                this.tMP_PRIORIDADESTableAdapter.Fill(this.dtsEmulator.TMP_PRIORIDADES);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertPadre_IO(int ID_IO)
        {
            int? value = this.pRC_IOTableAdapter.getPadre(ID_IO);
            if (value.Equals(null))
            {
                return;
            }
            else
            {
                int valor = Convert.ToInt32(value);
                int tiempo = this.pRC_IOTableAdapter.getTiempoCPU(valor).Value;
                int prioridad = this.pRC_IOTableAdapter.getPrioridad(valor).Value;
                insertPadre_IO(valor);
                tiempo_llegada++;
                this.pROCESOS_ACTUALESTableAdapter.Insert(true, valor, tiempo, tiempo_llegada, prioridad);
            }
        }

        private void insertPadre_Programas(int ID_PRG)
        {
            int? value = this.pRC_PROGRAMASTableAdapter.getPadre(ID_PRG);
            if (value.Equals(null))
            {
                return;
            }
            else
            {
                int valor = Convert.ToInt32(value);
                int tiempo = this.pRC_PROGRAMASTableAdapter.getTiempoCPU(valor).Value;
                int prioridad = this.pRC_PROGRAMASTableAdapter.getPrioridad(valor).Value;
                insertPadre_Programas(valor);
                tiempo_llegada++;
                this.pROCESOS_ACTUALESTableAdapter.Insert(false, valor, tiempo, tiempo_llegada, prioridad);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                insertPadre_IO((int)this.dataGridView1.CurrentRow.Cells["ID_IO"].Value);
                tiempo_llegada++;
                this.pROCESOS_ACTUALESTableAdapter.Insert(true, (int)this.dataGridView1.CurrentRow.Cells["ID_IO"].Value, (int)this.dataGridView1.CurrentRow.Cells["TIEMPO_CPU"].Value, tiempo_llegada, (int)this.dataGridView1.CurrentRow.Cells["PRIORIDAD"].Value);
                fill();
                if (!this.button2.Enabled)
                {
                    this.button1.Enabled = true;
                    this.button2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                insertPadre_Programas((int)this.dataGridView2.CurrentRow.Cells["ID_PRG"].Value);
                tiempo_llegada++;
                this.pROCESOS_ACTUALESTableAdapter.Insert(false, (int)this.dataGridView2.CurrentRow.Cells["ID_PRG"].Value, (int)this.dataGridView2.CurrentRow.Cells["TIEMPO_CPU1"].Value, tiempo_llegada, (int)this.dataGridView2.CurrentRow.Cells["PRIORIDAD1"].Value);
                fill();
                if (!this.button2.Enabled)
                {
                    this.button1.Enabled = true;
                    this.button2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.pROCESOS_ACTUALESTableAdapter.DeletebyTypes(Convert.ToBoolean(this.dataGridView3.CurrentRow.Cells["ID_TIPOL"].Value), (int)this.dataGridView3.CurrentRow.Cells["ID_PROCESOL"].Value, (int)this.dataGridView3.CurrentRow.Cells["TIEMPO_LLEGADAL"].Value);
                fill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void wfrmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Terminator();
        }

        private void Terminator()
        {
            try
            {
                this.pROCESOS_ACTUALESTableAdapter.DeleteAll();
                this.pROCESOS_EJECUCIONTableAdapter.DeleteAll();
                this.pROCESOS_BLOQUEOTableAdapter.DeleteAll();
                this.tMP_PRIORIDADESTableAdapter.DeleteAll();
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
                this.pROCESOS_ACTUALESTableAdapter.DeleteAll();
                this.pROCESOS_EJECUCIONTableAdapter.DeleteAll();
                this.pROCESOS_BLOQUEOTableAdapter.DeleteAll();
                this.tMP_PRIORIDADESTableAdapter.DeleteAll();
                fill();
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

        private void pickAlgoritmo()
        {
            try
            {
                if (this._codigo_algoritmo == 0)
                {
                    this.view_LOTESTableAdapter.FillByTiempo(this.dtsEmulator.View_LOTES);
                    this.dataGridView4.DataSource = this.viewLOTESBindingSource;
                }
                if (this._codigo_algoritmo == 1)
                {
                    this.view_PRIORIDADESTableAdapter.FillByPrioridades(this.dtsEmulator.View_PRIORIDADES);
                    this.dataGridView4.DataSource = this.viewPRIORIDADESBindingSource;
                }
                if (this._codigo_algoritmo == 2)
                {
                    this.view_ROUND_ROBBINTableAdapter.FillByORDEN(this.dtsEmulator.View_ROUND_ROBBIN);
                    this.dataGridView4.DataSource = this.viewROUNDROBBINBindingSource;
                }

                dataGridView4.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView3.RowCount > 0)
            {
                enabled_disabled(false);
                pickAlgoritmo();
                if (_codigo_algoritmo == 1)
                {
                    foreach (DataGridViewRow row in dataGridView3.Rows)
                    {
                        try
                        {
                            this.tMP_PRIORIDADESTableAdapter.Insert((int)row.Cells["PRIORIDADL"].Value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Debe seleccionar los procesos primero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enabled_disabled(bool val)
        {
            this.button3.Enabled = !val;
            this.button2.Enabled = val;
            this.button1.Enabled = val;
            this.dataGridView1.Enabled = val;
            this.dataGridView2.Enabled = val;
            this.dataGridView3.Enabled = val;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (true)
            {
                if (this.dataGridView4.RowCount > 0)
                {
                    try
                    {
                        bool tipo = (bool)this.dataGridView4.Rows[0].Cells[0].Value;
                        int codigo = (int)this.dataGridView4.Rows[0].Cells[1].Value;
                        int tiempo = (int)this.dataGridView4.Rows[0].Cells[3].Value;
                        int llegada = (int)this.dataGridView4.Rows[0].Cells[4].Value;
                        int prioridad = (int)this.dataGridView4.Rows[0].Cells[5].Value;
                        this.pROCESOS_EJECUCIONTableAdapter.Insert(tipo, codigo, tiempo, llegada, prioridad);
                        this.pROCESOS_ACTUALESTableAdapter.DeletebyTypes(tipo, codigo, llegada);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (true)
            {
                if (this.dataGridView5.RowCount > 0)
                {
                    try
                    {
                        bool tipo = (bool)this.dataGridView5.Rows[0].Cells["TIPOE"].Value;
                        int codigo = (int)this.dataGridView5.Rows[0].Cells["ID_PROCESOE"].Value;
                        int tiempo = (int)this.dataGridView5.Rows[0].Cells["TIEMPO_CPUE"].Value;
                        int llegada = (int)this.dataGridView5.Rows[0].Cells["TIEMPO_LLEGADAE"].Value;
                        int prioridad = (int)this.dataGridView5.Rows[0].Cells["PRIORIDAD_MAX"].Value;

                        if (tiempo - Convert.ToInt32(this.textBox1.Text) > 0)
                        {
                            this.pROCESOS_BLOQUEOTableAdapter.Insert(tipo, codigo, tiempo - Convert.ToInt32(this.textBox1.Text), llegada, prioridad);
                        }
                        this.pROCESOS_EJECUCIONTableAdapter.DeletebyTypes(tipo, codigo, llegada);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            if (true)
            {
                if (this.dataGridView6.RowCount > 0)
                {
                    try
                    {
                        bool tipo = (bool)this.dataGridView6.Rows[0].Cells["TIPOB"].Value;
                        int codigo = (int)this.dataGridView6.Rows[0].Cells["ID_PROCESOB"].Value;
                        int tiempo = (int)this.dataGridView6.Rows[0].Cells["TIEMPO_CPUB"].Value;
                        int llegada = (int)this.dataGridView6.Rows[0].Cells["TIEMPO_LLEGADAB"].Value;
                        int prioridad = (int)this.dataGridView6.Rows[0].Cells["PRIORIDAD_MAX1"].Value;

                        tiempo_llegada++;
                        if (this._codigo_algoritmo == 1)
                        {
                            if (prioridad > 1)
                            {
                                try
                                {
                                    var _res = (int)this.tMP_PRIORIDADESTableAdapter.getNextPrioridad(prioridad);
                                    prioridad = _res;
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                        this.pROCESOS_ACTUALESTableAdapter.Insert(tipo, codigo, tiempo, llegada + tiempo_llegada + Convert.ToInt32(this.textBox1.Text), prioridad);
                        this.pROCESOS_BLOQUEOTableAdapter.DeletebyTypes(tipo, codigo, llegada);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            fillEmulators();

            if (dataGridView4.RowCount == 0 && dataGridView5.RowCount == 0 && dataGridView6.RowCount == 0)
            {
                this.timer1.Stop();
                this.textBox1.Enabled = true;
                this.button3.Enabled = true;
                enabled_disabled(true);
                this.button4.Visible = false;
                try
                {
                    this.pROCESOS_ACTUALESTableAdapter.Fill(this.dtsEmulator.PROCESOS_ACTUALES);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                tiempo_llegada = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                this.timer1.Start();
                this.textBox1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Visible = true;
                stop = false;
            }
            else
            {
                MessageBox.Show(this, "Ingrese un valor de Quantum!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillEmulators()
        {
            try
            {
                this.dataGridView4.DataSource = null;
                pickAlgoritmo();
                this.view_EJECUCIONTableAdapter.Fill(this.dtsEmulator.View_EJECUCION);
                this.view_BLOQUEOTableAdapter.Fill(this.dtsEmulator.View_BLOQUEO);
                this.button2.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView4_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (stop)
            {
                this.timer1.Start();
                this.button4.Image = Properties.Resources._1498103493_pause;
                this.button4.Text = "Pausar";
                stop = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
            }
            else
            {
                this.timer1.Stop();
                this.button4.Image = Properties.Resources._1498103580_YouTube;
                this.button4.Text = "Reiniciar";
                stop = true;
                this.button5.Enabled = true;
                this.button6.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                bool tipo = (bool)this.dataGridView4.CurrentRow.Cells[0].Value;
                int codigo = (int)this.dataGridView4.CurrentRow.Cells[1].Value;
                int llegada = (int)this.dataGridView4.CurrentRow.Cells[4].Value;
                this.pROCESOS_ACTUALESTableAdapter.DeletebyTypes(tipo, codigo, llegada);
                switch(_codigo_algoritmo){
                    case 0:
                    this.view_LOTESTableAdapter.FillByTiempo(this.dtsEmulator.View_LOTES);
                    break;
                    case 1:
                    this.view_PRIORIDADESTableAdapter.FillByPrioridades(this.dtsEmulator.View_PRIORIDADES);
                    break;
                    case 2:
                    this.view_ROUND_ROBBINTableAdapter.FillByORDEN(this.dtsEmulator.View_ROUND_ROBBIN);
                    break;
                }
                this.dataGridView4.Refresh();
            }
            catch (Exception ex)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                bool tipo = (bool)this.dataGridView5.Rows[0].Cells["TIPOE"].Value;
                int codigo = (int)this.dataGridView5.Rows[0].Cells["ID_PROCESOE"].Value;
                int llegada = (int)this.dataGridView5.Rows[0].Cells["TIEMPO_LLEGADAE"].Value;
                this.pROCESOS_EJECUCIONTableAdapter.DeletebyTypes(tipo, codigo, llegada);
                this.view_EJECUCIONTableAdapter.Fill(this.dtsEmulator.View_EJECUCION);
                this.dataGridView5.Refresh();
            }
            catch (Exception ex)
            {

            }
        }

    }
}
