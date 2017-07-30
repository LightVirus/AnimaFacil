using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Windows.Forms;
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyCompany("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyProduct("AnimaFacil")]
[assembly: AssemblyTitle("AnimaFacil")]
[assembly: AssemblyTrademark("")]
[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: ComVisible(false)]
[assembly: Guid("23e75951-0d08-4cbf-a567-6df5d7495eb7")]


namespace AnimaFacil
{
    public class Form1 : Form
    {
        private object ultimoValorCelda = "";
        private static Random r;
        private static object syncObj = new object();
        private IContainer components;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button buttonIniciativas;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxResultadoComb;
        private NumericUpDown numDano;
        private NumericUpDown numTA;
        private NumericUpDown numDefensa;
        private NumericUpDown numAtaque;
        private ComboBox comboBoxOperacion;
        private NumericUpDown numOperador2;
        private NumericUpDown numOperador1;
        private TextBox textBoxResultadoOp;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Button buttonExportar;
        private SaveFileDialog saveFileDialog1;
        private Button buttonImportar;
        private OpenFileDialog openFileDialog1;
        private TabPage tabPage2;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private DataGridViewTextBoxColumn Personaje;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewTextBoxColumn DadosT;
        private DataGridViewTextBoxColumn Iniciativa;
        private DataGridViewTextBoxColumn VidaActual;
        private DataGridViewTextBoxColumn Cansancio;
        private DataGridViewTextBoxColumn Ki;
        private DataGridViewTextBoxColumn Zeon;
        private DataGridViewTextBoxColumn CV;
        private DataGridViewComboBoxColumn Natura;
        private DataGridViewComboBoxColumn Suerte;
        private DataGridViewCheckBoxColumn Uroboros;
        private DataGridViewTextBoxColumn Sorpresa;
        private DataGridViewTextBoxColumn Notas;
        private GroupBox groupBox3;
        private NumericUpDown numericTurno;
        private TabPage tabPage3;
        private GroupBox groupBox4;
        private TextBox CPcv;
        private Label label19;
        private TextBox CPzeon;
        private Label label18;
        private TextBox CPki;
        private Label label17;
        private TextBox CPnombre;
        private Label label16;
        private GroupBox groupBox5;
        private Label CPAdano;
        private Label label24;
        private Label label23;
        private TextBox textBox2;
        private ComboBox CPA1critico;
        private TextBox CPA1ha;
        private Label label22;
        private TextBox CPA1nombre;
        private Label label21;
        private TextBox CPvida;
        private Label label20;
        private TextBox textBox20;
        private ComboBox comboBox7;
        private TextBox textBox21;
        private TextBox CPA8nombre;
        private Label label31;
        private TextBox textBox17;
        private ComboBox comboBox6;
        private TextBox textBox18;
        private TextBox CPA7nombre;
        private Label label30;
        private TextBox textBox14;
        private ComboBox comboBox5;
        private TextBox textBox15;
        private TextBox CPA6nombre;
        private Label label29;
        private TextBox textBox11;
        private ComboBox comboBox4;
        private TextBox textBox12;
        private TextBox CPA5nombre;
        private Label label28;
        private TextBox textBox8;
        private ComboBox comboBox3;
        private TextBox textBox9;
        private TextBox CPA4nombre;
        private Label label27;
        private TextBox textBox5;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private TextBox CPA3nombre;
        private Label label26;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox CPA2nombre;
        private Label label25;
        private Label label15;
        public Form1()
        {
            this.InitializeComponent();
            this.comboBoxOperacion.SelectedItem = "+";
        }
        private static void InitRandomNumber(int seed)
        {
            Form1.r = new Random(seed);
        }
        private int d100Anima(int tipo, int suerte)
        {
            int num = 90;
            lock (Form1.syncObj)
            {
                if (Form1.r == null)
                {
                    Form1.r = new Random();
                }
            }
            int i = Form1.r.Next(1, 101);
            int num2 = i;
            if (suerte == 0)
            {
                if (num2 == 1)
                {
                    return -125;
                }
                if (num2 == 2)
                {
                    return -100;
                }
                if (num2 == 3)
                {
                    return -75;
                }
            }
            if (suerte == -1)
            {
                if (num2 == 1)
                {
                    return -125;
                }
                if (num2 == 2)
                {
                    return -100;
                }
                if (num2 == 3)
                {
                    return -75;
                }
                if (num2 == 4)
                {
                    return -75;
                }
                if (num2 == 5)
                {
                    return -75;
                }
            }
            if (suerte == 1)
            {
                if (num2 == 1)
                {
                    return -125;
                }
                if (num2 == 2)
                {
                    return -100;
                }
            }
            if (tipo == 2)
            {
                while (i >= num)
                {
                    num++;
                    i = Form1.r.Next(1, 101);
                    num2 += i;
                }
            }
            if (tipo == 3)
            {
                int j = 0;
                while (j < 3)
                {
                    if (i < num && i != 11 && i != 22 && i != 33 && i != 44 && i != 55 && i != 66 && i != 77 && i != 88)
                    {
                        break;
                    }
                    if (i == 11 || i == 22 || i == 33 || i == 44 || i == 55 || i == 66 || i == 77 || i == 88 || i == 99)
                    {
                        j++;
                    }
                    if (i >= num)
                    {
                        num++;
                    }
                    i = Form1.r.Next(1, 101);
                    if (j == 3)
                    {
                        num2 += 100;
                    }
                    else
                    {
                        num2 += i;
                    }
                }
            }
            return num2;
        }
        private void numAtaque_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarResultadoCombate();
        }
        private void numDefensa_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarResultadoCombate();
        }
        private void numTA_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarResultadoCombate();
        }
        private void numDano_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarResultadoCombate();
        }
        private void actualizarResultadoCombate()
        {
            int num = Convert.ToInt32(this.numAtaque.Value);
            int num2 = Convert.ToInt32(this.numDefensa.Value);
            int num3 = Convert.ToInt32(this.numTA.Value);
            int num4 = Convert.ToInt32(this.numDano.Value);
            int num5 = num - num2;
            if (num5 >= 0)
            {
                string text = "Ataque falló. Defensor pierde acción.";
                num5 = num5 / 10 * 10;
                num5 = num5 - 20 - num3 * 10;
                if (num5 > 0)
                {
                    num5 = num5 * num4 / 100;
                    text = "Daño total: " + num5;
                }
                this.textBoxResultadoComb.Text = text;
                return;
            }
            num5 = -num5 / 2;
            num5 /= 5;
            num5 *= 5;
            this.textBoxResultadoComb.Text = "CONTRATAQUE: +" + num5;
        }
        private void buttonIniciativas_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dataGridView1.Rows)
            {
                int num = 0;
                int tipo = 2;
                int suerte = 0;
                if (dataGridViewRow.Cells["Personaje"].Value != null && dataGridViewRow.Cells["Personaje"].Value.ToString() != "")
                {
                    if (dataGridViewRow.Cells["Turno"].Value != null)
                    {
                        num = int.Parse(dataGridViewRow.Cells["Turno"].Value.ToString());
                    }
                    if (dataGridViewRow.Cells["Natura"].Value != null)
                    {
                        if (dataGridViewRow.Cells["Natura"].Value.ToString() == "Natura +0")
                        {
                            tipo = 1;
                        }
                        if (dataGridViewRow.Cells["Natura"].Value.ToString() == "Natura +5/+10")
                        {
                            tipo = 2;
                        }
                        if (dataGridViewRow.Cells["Natura"].Value.ToString() == "Natura +15")
                        {
                            tipo = 3;
                        }
                    }
                    if (dataGridViewRow.Cells["Suerte"].Value != null)
                    {
                        if (dataGridViewRow.Cells["Suerte"].Value.ToString() == "Normal")
                        {
                            suerte = 0;
                        }
                        if (dataGridViewRow.Cells["Suerte"].Value.ToString() == "Buena")
                        {
                            suerte = 1;
                        }
                        if (dataGridViewRow.Cells["Suerte"].Value.ToString() == "Mala")
                        {
                            suerte = -1;
                        }
                    }
                    int num2;
                    if (dataGridViewRow.Cells["Dados Turno"].Value == null)
                    {
                        num2 = this.d100Anima(tipo, suerte);
                    }
                    else
                    {
                        num2 = int.Parse(dataGridViewRow.Cells["Dados Turno"].Value.ToString());
                    }   
                    int num3 = num + num2;
                    dataGridViewRow.Cells["Iniciativa"].Value = num3;
                    if (num2 < 0)
                    {
                        dataGridViewRow.Cells["Iniciativa"].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        dataGridViewRow.Cells["Iniciativa"].Style.BackColor = Color.White;
                    }
                }
            }
            int num4 = int.Parse(this.numericTurno.Value.ToString());
            this.numericTurno.Value = num4 + 1;
            this.dataGridView1.Sort(this.dataGridView1.Columns["Iniciativa"], ListSortDirection.Descending);
            this.sorpresaComprobator();
        }
        private void sorpresaComprobator()
        {
            foreach (DataGridViewRow dataGridViewRow in (IEnumerable)this.dataGridView1.Rows)
            {
                dataGridViewRow.Cells["Sorpresa"].Value = "";
            }
            foreach (DataGridViewRow dataGridViewRow2 in (IEnumerable)this.dataGridView1.Rows)
            {
                dataGridViewRow2.Cells["Sorpresa"].Style.BackColor = Color.White;
                int num = 0;
                bool flag = false;
                if (dataGridViewRow2.Cells["Iniciativa"].Value != null && dataGridViewRow2.Cells["Iniciativa"].Value.ToString() != "")
                {
                    num = int.Parse(dataGridViewRow2.Cells["Iniciativa"].Value.ToString());
                }
                if (dataGridViewRow2.Cells["Uroboros"].Value != null)
                {
                    flag = bool.Parse(dataGridViewRow2.Cells["Uroboros"].Value.ToString());
                }
                foreach (DataGridViewRow dataGridViewRow3 in (IEnumerable)this.dataGridView1.Rows)
                {
                    int num2 = 0;
                    if (dataGridViewRow3.Cells["Iniciativa"].Value != null)
                    {
                        num2 = int.Parse(dataGridViewRow3.Cells["Iniciativa"].Value.ToString());
                    }
                    if (num - 150 >= num2 || (flag && num - 100 >= num2))
                    {
                        string text = "";
                        if (dataGridViewRow3.Cells["Personaje"].Value != null && dataGridViewRow3.Cells["Personaje"].Value.ToString() != "")
                        {
                            text = dataGridViewRow3.Cells["Personaje"].Value.ToString();
                        }
                        if (text != "")
                        {
                            if (dataGridViewRow2.Cells["Sorpresa"].Value != null && !(dataGridViewRow2.Cells["Sorpresa"].Value.ToString() == ""))
                            {
                                DataGridViewCell expr_256 = dataGridViewRow2.Cells["Sorpresa"];
                                expr_256.Value = expr_256.Value + ", " + text;
                            }
                            else
                            {
                                dataGridViewRow2.Cells["Sorpresa"].Value = text;
                                dataGridViewRow2.Cells["Sorpresa"].Style.BackColor = Color.Green;
                            }
                        }
                    }
                }
            }
        }
        private void numOperador1_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarResultadoOperacion();
        }
        private void numOperador2_ValueChanged(object sender, EventArgs e)
        {
            this.actualizarResultadoOperacion();
        }
        private void comboBoxOperacion_SelectedValueChanged(object sender, EventArgs e)
        {
            this.actualizarResultadoOperacion();
        }
        private void actualizarResultadoOperacion()
        {
            string text = this.comboBoxOperacion.SelectedItem.ToString();
            int num = Convert.ToInt32(this.numOperador1.Value);
            int num2 = Convert.ToInt32(this.numOperador2.Value);
            string a;
            int num3;
            if ((a = text) != null)
            {
                if (a == "+")
                {
                    num3 = num + num2;
                    goto IL_8D;
                }
                if (a == "-")
                {
                    num3 = num - num2;
                    goto IL_8D;
                }
                if (a == "x")
                {
                    num3 = num * num2;
                    goto IL_8D;
                }
                if (a == ":")
                {
                    num3 = 0;
                    if(num2 != 0)
                    {
                        num3 = num / num2;
                    }
                    goto IL_8D;
                }
            }
            num3 = 0;
        IL_8D:
            this.textBoxResultadoOp.Text = num3.ToString();
        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                this.ultimoValorCelda = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                int num = 0;
                bool flag = false;
                if (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string s = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    flag = int.TryParse(s, out num);
                }
                if (!flag)
                {
                    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = this.ultimoValorCelda;
                }
            }
            this.sorpresaComprobator();
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.Value == null)
            {
                e.Value = "Natura +5/+10";
            }
            if (e.ColumnIndex == 9 && e.Value == null)
            {
                e.Value = "Normal";
            }
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                this.buttonExportar.Enabled = true;
                return;
            }
            this.buttonExportar.Enabled = false;
        }
        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string fileName = "Vacio";
            if (this.dataGridView1.CurrentRow.Cells["Personaje"] != null)
            {
                fileName = this.dataGridView1.CurrentRow.Cells["Personaje"].Value.ToString();
            }
            this.saveFileDialog1.FileName = fileName;
            this.saveFileDialog1.ShowDialog();
        }
        private void rowsAddednousar(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = this.saveFileDialog1.FileName;
            this.escribirFichero(fileName);
        }
        private void escribirFichero(string nombreFichero)
        {
            string text;
            if (this.dataGridView1.CurrentRow.Cells["Personaje"].Value != null && this.dataGridView1.CurrentRow.Cells["Personaje"].Value.ToString() != "")
            {
                text = this.dataGridView1.CurrentRow.Cells["Personaje"].Value.ToString();
            }
            else
            {
                text = "Desconocido";
            }
            string text2;
            if (this.dataGridView1.CurrentRow.Cells["Turno"].Value != null && this.dataGridView1.CurrentRow.Cells["Turno"].Value.ToString() != "")
            {
                text2 = this.dataGridView1.CurrentRow.Cells["Turno"].Value.ToString();
            }
            else
            {
                text2 = "0";
            }
            string text3;
            if (this.dataGridView1.CurrentRow.Cells["VidaActual"].Value != null && this.dataGridView1.CurrentRow.Cells["VidaActual"].Value.ToString() != "")
            {
                text3 = this.dataGridView1.CurrentRow.Cells["VidaActual"].Value.ToString();
            }
            else
            {
                text3 = "0";
            }
            string text4;
            if (this.dataGridView1.CurrentRow.Cells["Cansancio"].Value != null && this.dataGridView1.CurrentRow.Cells["Cansancio"].Value.ToString() != "")
            {
                text4 = this.dataGridView1.CurrentRow.Cells["Cansancio"].Value.ToString();
            }
            else
            {
                text4 = "0";
            }
            string text5;
            if (this.dataGridView1.CurrentRow.Cells["Ki"].Value != null && this.dataGridView1.CurrentRow.Cells["Ki"].Value.ToString() != "")
            {
                text5 = this.dataGridView1.CurrentRow.Cells["Ki"].Value.ToString();
            }
            else
            {
                text5 = "0";
            }
            string text6;
            if (this.dataGridView1.CurrentRow.Cells["Zeon"].Value != null && this.dataGridView1.CurrentRow.Cells["Zeon"].Value.ToString() != "")
            {
                text6 = this.dataGridView1.CurrentRow.Cells["Zeon"].Value.ToString();
            }
            else
            {
                text6 = "0";
            }
            string text7;
            if (this.dataGridView1.CurrentRow.Cells["Natura"].Value != null && this.dataGridView1.CurrentRow.Cells["Natura"].Value.ToString() != "")
            {
                text7 = this.dataGridView1.CurrentRow.Cells["Natura"].Value.ToString();
            }
            else
            {
                text7 = "Natura +5/+10";
            }
            string text8;
            if (this.dataGridView1.CurrentRow.Cells["Uroboros"].Value != null && this.dataGridView1.CurrentRow.Cells["Uroboros"].Value.ToString() != "")
            {
                text8 = this.dataGridView1.CurrentRow.Cells["Uroboros"].Value.ToString();
            }
            else
            {
                text8 = "False";
            }
            string text9;
            if (this.dataGridView1.CurrentRow.Cells["Notas"].Value != null && this.dataGridView1.CurrentRow.Cells["Notas"].Value.ToString() != "")
            {
                text9 = this.dataGridView1.CurrentRow.Cells["Notas"].Value.ToString();
            }
            else
            {
                text9 = "-";
            }
            string text10;
            if (this.dataGridView1.CurrentRow.Cells["Suerte"].Value != null && this.dataGridView1.CurrentRow.Cells["Suerte"].Value.ToString() != "")
            {
                text10 = this.dataGridView1.CurrentRow.Cells["Suerte"].Value.ToString();
            }
            else
            {
                text10 = "Normal";
            }
            string text11;
            if (this.dataGridView1.CurrentRow.Cells["CV"].Value != null && this.dataGridView1.CurrentRow.Cells["CV"].Value.ToString() != "")
            {
                text11 = this.dataGridView1.CurrentRow.Cells["CV"].Value.ToString();
            }
            else
            {
                text11 = "0";
            }
            string[] contents = new string[]
            {
                "ANIMAFACILCHARACTERDATA",
                text,
                text2,
                text3,
                text4,
                text5,
                text6,
                text7,
                text8,
                text9,
                text10,
                text11
            };
            File.WriteAllLines(nombreFichero, contents);
        }
        private void buttonImportar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = this.openFileDialog1.FileName;
            string[] array = new string[12];
            int num = 0;
            StreamReader streamReader = new StreamReader(fileName);
            string value;
            while ((value = streamReader.ReadLine()) != null)
            {
                array.SetValue(value, num);
                num++;
            }
            streamReader.Close();
            if (!array[0].Equals("ANIMAFACILCHARACTERDATA"))
            {
                MessageBox.Show("Archivo incorrecto. Error localizado en la cabecera.");
                return;
            }
            if (num < 10)
            {
                MessageBox.Show("Archivo incorrecto. Error localizado en las líneas.");
                return;
            }
            this.dataGridView1.Rows.Add(new object[]
            {
                array[1],
                array[2],
                null,
                "0",
                array[3],
                array[4],
                array[5],
                array[6],
                array[11],
                array[7],
                array[10],
                array[8],
                "",
                array[9]
            });
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericTurno = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonIniciativas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxResultadoOp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOperacion = new System.Windows.Forms.ComboBox();
            this.numOperador2 = new System.Windows.Forms.NumericUpDown();
            this.numOperador1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResultadoComb = new System.Windows.Forms.TextBox();
            this.numDano = new System.Windows.Forms.NumericUpDown();
            this.numTA = new System.Windows.Forms.NumericUpDown();
            this.numDefensa = new System.Windows.Forms.NumericUpDown();
            this.numAtaque = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Personaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DadosT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iniciativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VidaActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cansancio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zeon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Natura = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Suerte = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Uroboros = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sorpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CPnombre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CPki = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CPzeon = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CPcv = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CPvida = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CPA1nombre = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.CPA1ha = new System.Windows.Forms.TextBox();
            this.CPA1critico = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.CPAdano = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CPA2nombre = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.CPA3nombre = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.CPA4nombre = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.CPA5nombre = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.CPA6nombre = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.CPA7nombre = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.CPA8nombre = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTurno)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1055, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.buttonImportar);
            this.tabPage1.Controls.Add(this.buttonExportar);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.buttonIniciativas);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1047, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.numericTurno);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(578, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 66);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contador de turno";
            // 
            // numericTurno
            // 
            this.numericTurno.Location = new System.Drawing.Point(9, 41);
            this.numericTurno.Name = "numericTurno";
            this.numericTurno.Size = new System.Drawing.Size(123, 20);
            this.numericTurno.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Turno";
            // 
            // buttonImportar
            // 
            this.buttonImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImportar.Location = new System.Drawing.Point(677, 413);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(190, 23);
            this.buttonImportar.TabIndex = 6;
            this.buttonImportar.Text = "Importar personaje desde archivo";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExportar.Enabled = false;
            this.buttonExportar.Location = new System.Drawing.Point(873, 411);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(173, 23);
            this.buttonExportar.TabIndex = 5;
            this.buttonExportar.Text = "Exportar personaje seleccionado";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Fondo Rojo = Pifia";
            // 
            // buttonIniciativas
            // 
            this.buttonIniciativas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIniciativas.Location = new System.Drawing.Point(6, 411);
            this.buttonIniciativas.Name = "buttonIniciativas";
            this.buttonIniciativas.Size = new System.Drawing.Size(169, 23);
            this.buttonIniciativas.TabIndex = 3;
            this.buttonIniciativas.Text = "Calcular nuevas iniciativas";
            this.buttonIniciativas.UseVisualStyleBackColor = true;
            this.buttonIniciativas.Click += new System.EventHandler(this.buttonIniciativas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxResultadoOp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxOperacion);
            this.groupBox2.Controls.Add(this.numOperador2);
            this.groupBox2.Controls.Add(this.numOperador1);
            this.groupBox2.Location = new System.Drawing.Point(722, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculadora Básica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Resultado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Num.2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Num.1";
            // 
            // textBoxResultadoOp
            // 
            this.textBoxResultadoOp.Location = new System.Drawing.Point(200, 39);
            this.textBoxResultadoOp.Name = "textBoxResultadoOp";
            this.textBoxResultadoOp.ReadOnly = true;
            this.textBoxResultadoOp.Size = new System.Drawing.Size(118, 20);
            this.textBoxResultadoOp.TabIndex = 5;
            this.textBoxResultadoOp.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "=";
            // 
            // comboBoxOperacion
            // 
            this.comboBoxOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperacion.FormattingEnabled = true;
            this.comboBoxOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            ":"});
            this.comboBoxOperacion.Location = new System.Drawing.Point(70, 40);
            this.comboBoxOperacion.Name = "comboBoxOperacion";
            this.comboBoxOperacion.Size = new System.Drawing.Size(41, 21);
            this.comboBoxOperacion.TabIndex = 3;
            this.comboBoxOperacion.SelectedValueChanged += new System.EventHandler(this.comboBoxOperacion_SelectedValueChanged);
            // 
            // numOperador2
            // 
            this.numOperador2.Location = new System.Drawing.Point(117, 40);
            this.numOperador2.Name = "numOperador2";
            this.numOperador2.Size = new System.Drawing.Size(58, 20);
            this.numOperador2.TabIndex = 2;
            this.numOperador2.ValueChanged += new System.EventHandler(this.numOperador2_ValueChanged);
            // 
            // numOperador1
            // 
            this.numOperador1.Location = new System.Drawing.Point(6, 40);
            this.numOperador1.Name = "numOperador1";
            this.numOperador1.Size = new System.Drawing.Size(58, 20);
            this.numOperador1.TabIndex = 1;
            this.numOperador1.ValueChanged += new System.EventHandler(this.numOperador1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxResultadoComb);
            this.groupBox1.Controls.Add(this.numDano);
            this.groupBox1.Controls.Add(this.numTA);
            this.groupBox1.Controls.Add(this.numDefensa);
            this.groupBox1.Controls.Add(this.numAtaque);
            this.groupBox1.Location = new System.Drawing.Point(6, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora Combate (Core Exxet)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Daño (Atacante)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TA (Defensor)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Defensa total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ataque total";
            // 
            // textBoxResultadoComb
            // 
            this.textBoxResultadoComb.Location = new System.Drawing.Point(340, 40);
            this.textBoxResultadoComb.Name = "textBoxResultadoComb";
            this.textBoxResultadoComb.ReadOnly = true;
            this.textBoxResultadoComb.Size = new System.Drawing.Size(214, 20);
            this.textBoxResultadoComb.TabIndex = 4;
            // 
            // numDano
            // 
            this.numDano.Location = new System.Drawing.Point(249, 40);
            this.numDano.Name = "numDano";
            this.numDano.Size = new System.Drawing.Size(75, 20);
            this.numDano.TabIndex = 3;
            this.numDano.ValueChanged += new System.EventHandler(this.numDano_ValueChanged);
            // 
            // numTA
            // 
            this.numTA.Location = new System.Drawing.Point(168, 40);
            this.numTA.Name = "numTA";
            this.numTA.Size = new System.Drawing.Size(75, 20);
            this.numTA.TabIndex = 2;
            this.numTA.ValueChanged += new System.EventHandler(this.numTA_ValueChanged);
            // 
            // numDefensa
            // 
            this.numDefensa.Location = new System.Drawing.Point(87, 40);
            this.numDefensa.Name = "numDefensa";
            this.numDefensa.Size = new System.Drawing.Size(75, 20);
            this.numDefensa.TabIndex = 1;
            this.numDefensa.ValueChanged += new System.EventHandler(this.numDefensa_ValueChanged);
            // 
            // numAtaque
            // 
            this.numAtaque.Location = new System.Drawing.Point(6, 40);
            this.numAtaque.Name = "numAtaque";
            this.numAtaque.Size = new System.Drawing.Size(75, 20);
            this.numAtaque.TabIndex = 0;
            this.numAtaque.ValueChanged += new System.EventHandler(this.numAtaque_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personaje,
            this.Turno,
            this.DadosT,
            this.Iniciativa,
            this.VidaActual,
            this.Cansancio,
            this.Ki,
            this.Zeon,
            this.CV,
            this.Natura,
            this.Suerte,
            this.Uroboros,
            this.Sorpresa,
            this.Notas});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.rowsAddednousar);
            // 
            // Personaje
            // 
            this.Personaje.HeaderText = "Personaje";
            this.Personaje.Name = "Personaje";
            this.Personaje.Width = 70;
            // 
            // Turno
            // 
            dataGridViewCellStyle1.Format = "N0";
            this.Turno.DefaultCellStyle = dataGridViewCellStyle1;
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.Width = 71;
            // 
            // DadosT
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.DadosT.DefaultCellStyle = dataGridViewCellStyle2;
            this.DadosT.HeaderText = "Dados Turno";
            this.DadosT.Name = "DadosT";
            this.DadosT.Width = 71;
            // 
            // Iniciativa
            // 
            dataGridViewCellStyle3.Format = "N0";
            this.Iniciativa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Iniciativa.HeaderText = "Iniciativa";
            this.Iniciativa.Name = "Iniciativa";
            this.Iniciativa.ReadOnly = true;
            this.Iniciativa.Width = 71;
            // 
            // VidaActual
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.VidaActual.DefaultCellStyle = dataGridViewCellStyle4;
            this.VidaActual.HeaderText = "Vida";
            this.VidaActual.Name = "VidaActual";
            this.VidaActual.Width = 72;
            // 
            // Cansancio
            // 
            dataGridViewCellStyle5.Format = "N0";
            this.Cansancio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cansancio.HeaderText = "Cansancio";
            this.Cansancio.Name = "Cansancio";
            this.Cansancio.Width = 72;
            // 
            // Ki
            // 
            dataGridViewCellStyle6.Format = "N0";
            this.Ki.DefaultCellStyle = dataGridViewCellStyle6;
            this.Ki.HeaderText = "Ki";
            this.Ki.Name = "Ki";
            this.Ki.Width = 71;
            // 
            // Zeon
            // 
            dataGridViewCellStyle7.Format = "N0";
            this.Zeon.DefaultCellStyle = dataGridViewCellStyle7;
            this.Zeon.HeaderText = "Zeon";
            this.Zeon.Name = "Zeon";
            this.Zeon.Width = 71;
            // 
            // CV
            // 
            this.CV.HeaderText = "CV";
            this.CV.Name = "CV";
            this.CV.Width = 72;
            // 
            // Natura
            // 
            this.Natura.HeaderText = "Natura";
            this.Natura.Items.AddRange(new object[] {
            "Natura +0",
            "Natura +5/+10",
            "Natura +15"});
            this.Natura.Name = "Natura";
            this.Natura.Width = 71;
            // 
            // Suerte
            // 
            this.Suerte.HeaderText = "Suerte";
            this.Suerte.Items.AddRange(new object[] {
            "Normal",
            "Buena",
            "Mala"});
            this.Suerte.Name = "Suerte";
            this.Suerte.Width = 71;
            // 
            // Uroboros
            // 
            this.Uroboros.HeaderText = "¿Uroboros?";
            this.Uroboros.Name = "Uroboros";
            this.Uroboros.Width = 71;
            // 
            // Sorpresa
            // 
            this.Sorpresa.HeaderText = "Sorprendes a...";
            this.Sorpresa.Name = "Sorpresa";
            this.Sorpresa.ReadOnly = true;
            this.Sorpresa.Width = 72;
            // 
            // Notas
            // 
            this.Notas.HeaderText = "Notas";
            this.Notas.Name = "Notas";
            this.Notas.Width = 71;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1047, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Creador Personajes";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Acerca de...";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(291, 448);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(556, 31);
            this.label14.TabIndex = 3;
            this.label14.Text = "E-Mail del autor: guillermocanino@gmail.com";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(209, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 31);
            this.label13.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(150, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(779, 42);
            this.label12.TabIndex = 1;
            this.label12.Text = "Creado por Guillermo Canino y Unai Lujambio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(375, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 42);
            this.label11.TabIndex = 0;
            this.label11.Text = "Anima Fácil v.1.2";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "apj";
            this.saveFileDialog1.Filter = "Anima PJ (*.apj)|*.apj";
            this.saveFileDialog1.Title = "Guardar personaje...";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "apj";
            this.openFileDialog1.Filter = "Anima PJ (*.apj)|*.apj";
            this.openFileDialog1.Title = "Cargar personaje...";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.CPvida);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.CPcv);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.CPzeon);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.CPki);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.CPnombre);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1034, 499);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personaje";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Nombre";
            // 
            // CPnombre
            // 
            this.CPnombre.Location = new System.Drawing.Point(57, 17);
            this.CPnombre.Name = "CPnombre";
            this.CPnombre.Size = new System.Drawing.Size(389, 20);
            this.CPnombre.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Ki";
            // 
            // CPki
            // 
            this.CPki.Location = new System.Drawing.Point(57, 55);
            this.CPki.Name = "CPki";
            this.CPki.Size = new System.Drawing.Size(48, 20);
            this.CPki.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(125, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Zeon";
            // 
            // CPzeon
            // 
            this.CPzeon.Location = new System.Drawing.Point(163, 55);
            this.CPzeon.Name = "CPzeon";
            this.CPzeon.Size = new System.Drawing.Size(48, 20);
            this.CPzeon.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(233, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "CV";
            // 
            // CPcv
            // 
            this.CPcv.Location = new System.Drawing.Point(260, 55);
            this.CPcv.Name = "CPcv";
            this.CPcv.Size = new System.Drawing.Size(48, 20);
            this.CPcv.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(334, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Pt. de vida";
            // 
            // CPvida
            // 
            this.CPvida.Location = new System.Drawing.Point(398, 55);
            this.CPvida.Name = "CPvida";
            this.CPvida.Size = new System.Drawing.Size(48, 20);
            this.CPvida.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox20);
            this.groupBox5.Controls.Add(this.comboBox7);
            this.groupBox5.Controls.Add(this.textBox21);
            this.groupBox5.Controls.Add(this.CPA8nombre);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.textBox17);
            this.groupBox5.Controls.Add(this.comboBox6);
            this.groupBox5.Controls.Add(this.textBox18);
            this.groupBox5.Controls.Add(this.CPA7nombre);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Controls.Add(this.comboBox5);
            this.groupBox5.Controls.Add(this.textBox15);
            this.groupBox5.Controls.Add(this.CPA6nombre);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.textBox11);
            this.groupBox5.Controls.Add(this.comboBox4);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.CPA5nombre);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.textBox9);
            this.groupBox5.Controls.Add(this.CPA4nombre);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.CPA3nombre);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.CPA2nombre);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.CPAdano);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.CPA1critico);
            this.groupBox5.Controls.Add(this.CPA1ha);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.CPA1nombre);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(10, 102);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(361, 261);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ataque";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Atq 1";
            // 
            // CPA1nombre
            // 
            this.CPA1nombre.Location = new System.Drawing.Point(44, 42);
            this.CPA1nombre.Name = "CPA1nombre";
            this.CPA1nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA1nombre.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(76, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "Nombre";
            // 
            // CPA1ha
            // 
            this.CPA1ha.Location = new System.Drawing.Point(160, 42);
            this.CPA1ha.Name = "CPA1ha";
            this.CPA1ha.Size = new System.Drawing.Size(41, 20);
            this.CPA1ha.TabIndex = 13;
            // 
            // CPA1critico
            // 
            this.CPA1critico.BackColor = System.Drawing.SystemColors.Window;
            this.CPA1critico.FormattingEnabled = true;
            this.CPA1critico.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.CPA1critico.Location = new System.Drawing.Point(207, 41);
            this.CPA1critico.Name = "CPA1critico";
            this.CPA1critico.Size = new System.Drawing.Size(73, 21);
            this.CPA1critico.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(170, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "HA";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(225, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Critico";
            // 
            // CPAdano
            // 
            this.CPAdano.AutoSize = true;
            this.CPAdano.Location = new System.Drawing.Point(299, 16);
            this.CPAdano.Name = "CPAdano";
            this.CPAdano.Size = new System.Drawing.Size(33, 13);
            this.CPAdano.TabIndex = 18;
            this.CPAdano.Text = "Daño";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.comboBox1.Location = new System.Drawing.Point(207, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(73, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(41, 20);
            this.textBox3.TabIndex = 21;
            // 
            // CPA2nombre
            // 
            this.CPA2nombre.Location = new System.Drawing.Point(44, 68);
            this.CPA2nombre.Name = "CPA2nombre";
            this.CPA2nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA2nombre.TabIndex = 19;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Atq 2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(286, 94);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(61, 20);
            this.textBox5.TabIndex = 28;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.comboBox2.Location = new System.Drawing.Point(207, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(73, 21);
            this.comboBox2.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(160, 94);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(41, 20);
            this.textBox6.TabIndex = 26;
            // 
            // CPA3nombre
            // 
            this.CPA3nombre.Location = new System.Drawing.Point(44, 94);
            this.CPA3nombre.Name = "CPA3nombre";
            this.CPA3nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA3nombre.TabIndex = 24;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Atq 3";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(286, 120);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(61, 20);
            this.textBox8.TabIndex = 33;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.comboBox3.Location = new System.Drawing.Point(207, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(73, 21);
            this.comboBox3.TabIndex = 32;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(160, 120);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(41, 20);
            this.textBox9.TabIndex = 31;
            // 
            // CPA4nombre
            // 
            this.CPA4nombre.Location = new System.Drawing.Point(44, 120);
            this.CPA4nombre.Name = "CPA4nombre";
            this.CPA4nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA4nombre.TabIndex = 29;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 123);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 13);
            this.label27.TabIndex = 30;
            this.label27.Text = "Atq 4";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(286, 146);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(61, 20);
            this.textBox11.TabIndex = 38;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.comboBox4.Location = new System.Drawing.Point(207, 145);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(73, 21);
            this.comboBox4.TabIndex = 37;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(160, 146);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(41, 20);
            this.textBox12.TabIndex = 36;
            // 
            // CPA5nombre
            // 
            this.CPA5nombre.Location = new System.Drawing.Point(44, 146);
            this.CPA5nombre.Name = "CPA5nombre";
            this.CPA5nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA5nombre.TabIndex = 34;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 149);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "Atq 5";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(286, 172);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(61, 20);
            this.textBox14.TabIndex = 43;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.comboBox5.Location = new System.Drawing.Point(207, 171);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(73, 21);
            this.comboBox5.TabIndex = 42;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(160, 172);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(41, 20);
            this.textBox15.TabIndex = 41;
            // 
            // CPA6nombre
            // 
            this.CPA6nombre.Location = new System.Drawing.Point(44, 172);
            this.CPA6nombre.Name = "CPA6nombre";
            this.CPA6nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA6nombre.TabIndex = 39;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 175);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 13);
            this.label29.TabIndex = 40;
            this.label29.Text = "Atq 6";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(286, 198);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(61, 20);
            this.textBox17.TabIndex = 48;
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.comboBox6.Location = new System.Drawing.Point(207, 197);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(73, 21);
            this.comboBox6.TabIndex = 47;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(160, 198);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(41, 20);
            this.textBox18.TabIndex = 46;
            // 
            // CPA7nombre
            // 
            this.CPA7nombre.Location = new System.Drawing.Point(44, 198);
            this.CPA7nombre.Name = "CPA7nombre";
            this.CPA7nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA7nombre.TabIndex = 44;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 201);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 13);
            this.label30.TabIndex = 45;
            this.label30.Text = "Atq 7";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(286, 224);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(61, 20);
            this.textBox20.TabIndex = 53;
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.comboBox7.Location = new System.Drawing.Point(207, 223);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(73, 21);
            this.comboBox7.TabIndex = 52;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(160, 224);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(41, 20);
            this.textBox21.TabIndex = 51;
            // 
            // CPA8nombre
            // 
            this.CPA8nombre.Location = new System.Drawing.Point(44, 224);
            this.CPA8nombre.Name = "CPA8nombre";
            this.CPA8nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA8nombre.TabIndex = 49;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 227);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 13);
            this.label31.TabIndex = 50;
            this.label31.Text = "Atq 8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1069, 562);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Anima Fácil";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTurno)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefensa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
namespace AnimaFacil.Properties
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
    internal class Resources
    {
        private static ResourceManager resourceMan;
        private static CultureInfo resourceCulture;
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (Resources.resourceMan == null)
                {
                    ResourceManager resourceManager = new ResourceManager("AnimaFacil.Properties.Resources", typeof(Resources).Assembly);
                    Resources.resourceMan = resourceManager;
                }
                return Resources.resourceMan;
            }
        }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return Resources.resourceCulture;
            }
            set
            {
                Resources.resourceCulture = value;
            }
        }
        internal Resources()
        {
        }
    }
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"), CompilerGenerated]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
        public static Settings Default
        {
            get
            {
                return Settings.defaultInstance;
            }
        }
    }
}