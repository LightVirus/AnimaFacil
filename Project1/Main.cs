using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
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
        public Personaje PersAGuardar;
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
        private SaveFileDialog saveFileDialogTabla;
        private Button buttonImportar;
        private OpenFileDialog openFileDialogTabla;
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
        private DataGridViewTextBoxColumn VidaMax;
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
        private TextBox CPA1dano;
        private ComboBox CPA1critico;
        private TextBox CPA1ha;
        private Label label22;
        private TextBox CPA1nombre;
        private Label label21;
        private TextBox CPvida;
        private Label label20;
        private TextBox CPA8dano;
        private ComboBox CPA8critico;
        private TextBox CPA8ha;
        private TextBox CPA8nombre;
        private Label label31;
        private TextBox CPA7dano;
        private ComboBox CPA7critico;
        private TextBox CPA7ha;
        private TextBox CPA7nombre;
        private Label label30;
        private TextBox CPA6dano;
        private ComboBox CPA6critico;
        private TextBox CPA6ha;
        private TextBox CPA6nombre;
        private Label label29;
        private TextBox CPA5dano;
        private ComboBox CPA5critico;
        private TextBox CPA5ha;
        private TextBox CPA5nombre;
        private Label label28;
        private TextBox CPA4dano;
        private ComboBox CPA4critico;
        private TextBox CPA4ha;
        private TextBox CPA4nombre;
        private Label label27;
        private TextBox CPA3dano;
        private ComboBox CPA3critico;
        private TextBox CPA3ha;
        private TextBox CPA3nombre;
        private Label label26;
        private TextBox CPA2dano;
        private ComboBox CPA2critico;
        private TextBox CPA2ha;
        private TextBox CPA2nombre;
        private Label label25;
        private GroupBox groupBox7;
        private TextBox CPTAfil;
        private Label label40;
        private GroupBox groupBox6;
        private TextBox CPD8defensa;
        private TextBox CPD8nombre;
        private Label label33;
        private TextBox CPD7defensa;
        private TextBox CPD7nombre;
        private Label label34;
        private TextBox CPD6defensa;
        private TextBox CPD6nombre;
        private Label label35;
        private TextBox CPD5defensa;
        private TextBox CPD5nombre;
        private Label label36;
        private TextBox CPD4defensa;
        private TextBox CPD4nombre;
        private Label label37;
        private TextBox CPD3defensa;
        private TextBox CPD3nombre;
        private Label label38;
        private TextBox CPD2defensa;
        private TextBox CPD2nombre;
        private Label label39;
        private Label label42;
        private TextBox CPD1defensa;
        private Label label43;
        private TextBox CPD1nombre;
        private Label label44;
        private TextBox CPturno;
        private Label label32;
        private TextBox CPTApen;
        private Label label45;
        private TextBox CPTAcon;
        private Label label41;
        private TextBox CPTAfri;
        private Label label46;
        private TextBox CPTAele;
        private Label label47;
        private TextBox CPTAcal;
        private Label label48;
        private TextBox CPTAene;
        private Label label49;
        private Label label15;
        private OpenFileDialog openFileDialogCreador;
        private SaveFileDialog saveFileDialogCreador;
        private Button CPsave;
        private ComboBox CPnatura;
        private Label label51;
        private TextBox CPcansancio;
        private Label label50;
        private ComboBox CPsuerte;
        private Label label52;
        private Button button1;
        private Button CPload;
        private Button button2;
        private CheckBox CPuroboros;
        private Label label53;
        private TextBox CPnotas;
        private Button Cpclean;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private Label label55;
        private Label label54;
        private ComboBox CALatacante;
        private TabPage tabPage5;
        private TextBox CALAdado;
        private Label label56;
        private Button CALcal;
        private RichTextBox CALlog;
        private ComboBox CALdefensa;
        private Label label60;
        private Label label62;
        private ComboBox CALdefensor;
        private TextBox CALAbono;
        private Label label58;
        private ComboBox CALataque;
        private Label label57;
        private RichTextBox CALresultado;
        private TextBox CALDta;
        private Label label59;
        private TextBox CALDbono;
        private Label label61;
        private TextBox CALDdado;
        private Label label64;
        private TextBox CALAta;
        private Label label63;
        Dictionary<string,Personaje> ListaPers = new Dictionary<string, Personaje>();
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
                    if (dataGridViewRow.Cells["DadosT"].Value == null)
                    {
                        num2 = this.d100Anima(tipo, suerte);
                    }
                    else
                    {
                        num2 = int.Parse(dataGridViewRow.Cells["DadosT"].Value.ToString());
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.CALatacante = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxResultadoOp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOperacion = new System.Windows.Forms.ComboBox();
            this.numOperador2 = new System.Windows.Forms.NumericUpDown();
            this.numOperador1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericTurno = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonIniciativas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Personaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DadosT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iniciativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VidaActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VidaMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cpclean = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.CPnotas = new System.Windows.Forms.TextBox();
            this.CPuroboros = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CPload = new System.Windows.Forms.Button();
            this.CPsuerte = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.CPnatura = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.CPcansancio = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.CPsave = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CPTAene = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.CPTAfri = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.CPTAele = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.CPTAcal = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.CPTApen = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.CPTAcon = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.CPTAfil = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CPD8defensa = new System.Windows.Forms.TextBox();
            this.CPD8nombre = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.CPD7defensa = new System.Windows.Forms.TextBox();
            this.CPD7nombre = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.CPD6defensa = new System.Windows.Forms.TextBox();
            this.CPD6nombre = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.CPD5defensa = new System.Windows.Forms.TextBox();
            this.CPD5nombre = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.CPD4defensa = new System.Windows.Forms.TextBox();
            this.CPD4nombre = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.CPD3defensa = new System.Windows.Forms.TextBox();
            this.CPD3nombre = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.CPD2defensa = new System.Windows.Forms.TextBox();
            this.CPD2nombre = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.CPD1defensa = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.CPD1nombre = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.CPturno = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CPA8dano = new System.Windows.Forms.TextBox();
            this.CPA8critico = new System.Windows.Forms.ComboBox();
            this.CPA8ha = new System.Windows.Forms.TextBox();
            this.CPA8nombre = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.CPA7dano = new System.Windows.Forms.TextBox();
            this.CPA7critico = new System.Windows.Forms.ComboBox();
            this.CPA7ha = new System.Windows.Forms.TextBox();
            this.CPA7nombre = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.CPA6dano = new System.Windows.Forms.TextBox();
            this.CPA6critico = new System.Windows.Forms.ComboBox();
            this.CPA6ha = new System.Windows.Forms.TextBox();
            this.CPA6nombre = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.CPA5dano = new System.Windows.Forms.TextBox();
            this.CPA5critico = new System.Windows.Forms.ComboBox();
            this.CPA5ha = new System.Windows.Forms.TextBox();
            this.CPA5nombre = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.CPA4dano = new System.Windows.Forms.TextBox();
            this.CPA4critico = new System.Windows.Forms.ComboBox();
            this.CPA4ha = new System.Windows.Forms.TextBox();
            this.CPA4nombre = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.CPA3dano = new System.Windows.Forms.TextBox();
            this.CPA3critico = new System.Windows.Forms.ComboBox();
            this.CPA3ha = new System.Windows.Forms.TextBox();
            this.CPA3nombre = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.CPA2dano = new System.Windows.Forms.TextBox();
            this.CPA2critico = new System.Windows.Forms.ComboBox();
            this.CPA2ha = new System.Windows.Forms.TextBox();
            this.CPA2nombre = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.CPAdano = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.CPA1dano = new System.Windows.Forms.TextBox();
            this.CPA1critico = new System.Windows.Forms.ComboBox();
            this.CPA1ha = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.CPA1nombre = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CPvida = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CPcv = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CPzeon = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CPki = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CPnombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.saveFileDialogTabla = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTabla = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogCreador = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogCreador = new System.Windows.Forms.SaveFileDialog();
            this.label56 = new System.Windows.Forms.Label();
            this.CALAdado = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.CALataque = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.CALAbono = new System.Windows.Forms.TextBox();
            this.CALdefensa = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.CALdefensor = new System.Windows.Forms.ComboBox();
            this.CALlog = new System.Windows.Forms.RichTextBox();
            this.CALcal = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.CALAta = new System.Windows.Forms.TextBox();
            this.CALDta = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.CALDbono = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.CALDdado = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.CALresultado = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefensa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtaque)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1055, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.buttonImportar);
            this.tabPage1.Controls.Add(this.buttonExportar);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.buttonIniciativas);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1047, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(6, 390);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(891, 167);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CALresultado);
            this.tabPage4.Controls.Add(this.CALDta);
            this.tabPage4.Controls.Add(this.label59);
            this.tabPage4.Controls.Add(this.CALDbono);
            this.tabPage4.Controls.Add(this.label61);
            this.tabPage4.Controls.Add(this.CALDdado);
            this.tabPage4.Controls.Add(this.label64);
            this.tabPage4.Controls.Add(this.CALAta);
            this.tabPage4.Controls.Add(this.label63);
            this.tabPage4.Controls.Add(this.CALcal);
            this.tabPage4.Controls.Add(this.CALlog);
            this.tabPage4.Controls.Add(this.CALdefensa);
            this.tabPage4.Controls.Add(this.label60);
            this.tabPage4.Controls.Add(this.label62);
            this.tabPage4.Controls.Add(this.CALdefensor);
            this.tabPage4.Controls.Add(this.CALAbono);
            this.tabPage4.Controls.Add(this.label58);
            this.tabPage4.Controls.Add(this.CALataque);
            this.tabPage4.Controls.Add(this.label57);
            this.tabPage4.Controls.Add(this.CALAdado);
            this.tabPage4.Controls.Add(this.label56);
            this.tabPage4.Controls.Add(this.label55);
            this.tabPage4.Controls.Add(this.label54);
            this.tabPage4.Controls.Add(this.CALatacante);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(883, 141);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Calculadora Combate Avanzada";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(215, 9);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(0, 13);
            this.label55.TabIndex = 2;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(7, 14);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(50, 13);
            this.label54.TabIndex = 1;
            this.label54.Text = "Atacante";
            // 
            // CALatacante
            // 
            this.CALatacante.FormattingEnabled = true;
            this.CALatacante.Location = new System.Drawing.Point(63, 10);
            this.CALatacante.Name = "CALatacante";
            this.CALatacante.Size = new System.Drawing.Size(121, 21);
            this.CALatacante.TabIndex = 0;
            this.CALatacante.SelectedValueChanged += new System.EventHandler(this.UpdateCALAtacante);
            
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(883, 141);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Calculadora Combate Simple";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 60);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculadora Básica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Resultado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Num.2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Num.1";
            // 
            // textBoxResultadoOp
            // 
            this.textBoxResultadoOp.Location = new System.Drawing.Point(200, 31);
            this.textBoxResultadoOp.Name = "textBoxResultadoOp";
            this.textBoxResultadoOp.ReadOnly = true;
            this.textBoxResultadoOp.Size = new System.Drawing.Size(118, 20);
            this.textBoxResultadoOp.TabIndex = 5;
            this.textBoxResultadoOp.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 35);
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
            this.comboBoxOperacion.Location = new System.Drawing.Point(70, 32);
            this.comboBoxOperacion.Name = "comboBoxOperacion";
            this.comboBoxOperacion.Size = new System.Drawing.Size(41, 21);
            this.comboBoxOperacion.TabIndex = 3;
            this.comboBoxOperacion.SelectedValueChanged += new System.EventHandler(this.comboBoxOperacion_SelectedValueChanged);
            // 
            // numOperador2
            // 
            this.numOperador2.Location = new System.Drawing.Point(117, 32);
            this.numOperador2.Name = "numOperador2";
            this.numOperador2.Size = new System.Drawing.Size(58, 20);
            this.numOperador2.TabIndex = 2;
            this.numOperador2.ValueChanged += new System.EventHandler(this.numOperador2_ValueChanged);
            // 
            // numOperador1
            // 
            this.numOperador1.Location = new System.Drawing.Point(6, 32);
            this.numOperador1.Name = "numOperador1";
            this.numOperador1.Size = new System.Drawing.Size(58, 20);
            this.numOperador1.TabIndex = 1;
            this.numOperador1.ValueChanged += new System.EventHandler(this.numOperador1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.numericTurno);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(899, 412);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(476, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Eliminar personaje seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonImportar
            // 
            this.buttonImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonImportar.Location = new System.Drawing.Point(672, 361);
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
            this.buttonExportar.Location = new System.Drawing.Point(868, 361);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(173, 23);
            this.buttonExportar.TabIndex = 5;
            this.buttonExportar.Text = "Enviar seleccionado al creador";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Fondo Rojo = Pifia";
            // 
            // buttonIniciativas
            // 
            this.buttonIniciativas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIniciativas.Location = new System.Drawing.Point(6, 361);
            this.buttonIniciativas.Name = "buttonIniciativas";
            this.buttonIniciativas.Size = new System.Drawing.Size(169, 23);
            this.buttonIniciativas.TabIndex = 3;
            this.buttonIniciativas.Text = "Calcular nuevas iniciativas";
            this.buttonIniciativas.UseVisualStyleBackColor = true;
            this.buttonIniciativas.Click += new System.EventHandler(this.buttonIniciativas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
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
            this.VidaMax,
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
            this.dataGridView1.Size = new System.Drawing.Size(1040, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.rowsAddednousar);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(rowsRemovednousar);
            // 
            // Personaje
            // 
            this.Personaje.HeaderText = "Personaje";
            this.Personaje.Name = "Personaje";
            this.Personaje.ReadOnly = true;
            this.Personaje.Width = 70;
            // 
            // Turno
            // 
            dataGridViewCellStyle9.Format = "N0";
            this.Turno.DefaultCellStyle = dataGridViewCellStyle9;
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.Width = 71;
            // 
            // DadosT
            // 
            dataGridViewCellStyle10.Format = "N0";
            this.DadosT.DefaultCellStyle = dataGridViewCellStyle10;
            this.DadosT.HeaderText = "Dados Turno";
            this.DadosT.Name = "DadosT";
            this.DadosT.Width = 71;
            // 
            // Iniciativa
            // 
            dataGridViewCellStyle11.Format = "N0";
            this.Iniciativa.DefaultCellStyle = dataGridViewCellStyle11;
            this.Iniciativa.HeaderText = "Iniciativa";
            this.Iniciativa.Name = "Iniciativa";
            this.Iniciativa.ReadOnly = true;
            this.Iniciativa.Width = 71;
            // 
            // VidaActual
            // 
            dataGridViewCellStyle12.Format = "N0";
            this.VidaActual.DefaultCellStyle = dataGridViewCellStyle12;
            this.VidaActual.HeaderText = "Vida";
            this.VidaActual.Name = "VidaActual";
            this.VidaActual.Width = 72;
            // 
            // VidaMax
            // 
            dataGridViewCellStyle13.Format = "N0";
            this.VidaMax.DefaultCellStyle = dataGridViewCellStyle13;
            this.VidaMax.HeaderText = "Vida Total";
            this.VidaMax.Name = "VidaMax";
            this.VidaMax.ReadOnly = true;
            this.VidaMax.Width = 72;
            // 
            // Cansancio
            // 
            dataGridViewCellStyle14.Format = "N0";
            this.Cansancio.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cansancio.HeaderText = "Cansancio";
            this.Cansancio.Name = "Cansancio";
            this.Cansancio.Width = 72;
            // 
            // Ki
            // 
            dataGridViewCellStyle15.Format = "N0";
            this.Ki.DefaultCellStyle = dataGridViewCellStyle15;
            this.Ki.HeaderText = "Ki";
            this.Ki.Name = "Ki";
            this.Ki.Width = 71;
            // 
            // Zeon
            // 
            dataGridViewCellStyle16.Format = "N0";
            this.Zeon.DefaultCellStyle = dataGridViewCellStyle16;
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
            this.tabPage3.Size = new System.Drawing.Size(1047, 563);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Creador Personajes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.Cpclean);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.CPnotas);
            this.groupBox4.Controls.Add(this.CPuroboros);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.CPload);
            this.groupBox4.Controls.Add(this.CPsuerte);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.CPnatura);
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.CPcansancio);
            this.groupBox4.Controls.Add(this.label50);
            this.groupBox4.Controls.Add(this.CPsave);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.CPturno);
            this.groupBox4.Controls.Add(this.label32);
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
            this.groupBox4.Size = new System.Drawing.Size(1034, 550);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personaje";
            // 
            // Cpclean
            // 
            this.Cpclean.Location = new System.Drawing.Point(558, 427);
            this.Cpclean.Name = "Cpclean";
            this.Cpclean.Size = new System.Drawing.Size(101, 23);
            this.Cpclean.TabIndex = 67;
            this.Cpclean.Text = "Vaciar";
            this.Cpclean.UseVisualStyleBackColor = true;
            this.Cpclean.Click += new System.EventHandler(this.Cpclean_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(489, 20);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(35, 13);
            this.label53.TabIndex = 66;
            this.label53.Text = "Notas";
            // 
            // CPnotas
            // 
            this.CPnotas.Location = new System.Drawing.Point(530, 17);
            this.CPnotas.Name = "CPnotas";
            this.CPnotas.Size = new System.Drawing.Size(158, 20);
            this.CPnotas.TabIndex = 65;
            // 
            // CPuroboros
            // 
            this.CPuroboros.AutoSize = true;
            this.CPuroboros.Location = new System.Drawing.Point(556, 68);
            this.CPuroboros.Name = "CPuroboros";
            this.CPuroboros.Size = new System.Drawing.Size(69, 17);
            this.CPuroboros.TabIndex = 64;
            this.CPuroboros.Text = "Uroboros";
            this.CPuroboros.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "Enviar a tabla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CPload
            // 
            this.CPload.Location = new System.Drawing.Point(398, 427);
            this.CPload.Name = "CPload";
            this.CPload.Size = new System.Drawing.Size(135, 23);
            this.CPload.TabIndex = 62;
            this.CPload.Text = "Cargar Personaje";
            this.CPload.UseVisualStyleBackColor = true;
            this.CPload.Click += new System.EventHandler(this.CPload_Click);
            // 
            // CPsuerte
            // 
            this.CPsuerte.BackColor = System.Drawing.SystemColors.Window;
            this.CPsuerte.FormattingEnabled = true;
            this.CPsuerte.Items.AddRange(new object[] {
            "Normal",
            "Buena",
            "Mala"});
            this.CPsuerte.Location = new System.Drawing.Point(411, 84);
            this.CPsuerte.Name = "CPsuerte";
            this.CPsuerte.Size = new System.Drawing.Size(107, 21);
            this.CPsuerte.TabIndex = 61;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(367, 88);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(38, 13);
            this.label52.TabIndex = 60;
            this.label52.Text = "Suerte";
            // 
            // CPnatura
            // 
            this.CPnatura.BackColor = System.Drawing.SystemColors.Window;
            this.CPnatura.FormattingEnabled = true;
            this.CPnatura.Items.AddRange(new object[] {
            "Natura +0",
            "Natura +5/+10",
            "Natura +15"});
            this.CPnatura.Location = new System.Drawing.Point(411, 50);
            this.CPnatura.Name = "CPnatura";
            this.CPnatura.Size = new System.Drawing.Size(107, 21);
            this.CPnatura.TabIndex = 54;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(366, 54);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(39, 13);
            this.label51.TabIndex = 59;
            this.label51.Text = "Natura";
            // 
            // CPcansancio
            // 
            this.CPcansancio.Location = new System.Drawing.Point(299, 85);
            this.CPcansancio.Name = "CPcansancio";
            this.CPcansancio.Size = new System.Drawing.Size(48, 20);
            this.CPcansancio.TabIndex = 58;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(236, 88);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(57, 13);
            this.label50.TabIndex = 57;
            this.label50.Text = "Cansancio";
            // 
            // CPsave
            // 
            this.CPsave.Location = new System.Drawing.Point(398, 392);
            this.CPsave.Name = "CPsave";
            this.CPsave.Size = new System.Drawing.Size(135, 23);
            this.CPsave.TabIndex = 56;
            this.CPsave.Text = "Guardar Personaje";
            this.CPsave.UseVisualStyleBackColor = true;
            this.CPsave.Click += new System.EventHandler(this.CPsave_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CPTAene);
            this.groupBox7.Controls.Add(this.label49);
            this.groupBox7.Controls.Add(this.CPTAfri);
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Controls.Add(this.CPTAele);
            this.groupBox7.Controls.Add(this.label47);
            this.groupBox7.Controls.Add(this.CPTAcal);
            this.groupBox7.Controls.Add(this.label48);
            this.groupBox7.Controls.Add(this.CPTApen);
            this.groupBox7.Controls.Add(this.label45);
            this.groupBox7.Controls.Add(this.CPTAcon);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.CPTAfil);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Location = new System.Drawing.Point(10, 382);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(361, 83);
            this.groupBox7.TabIndex = 55;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "TA\'s";
            // 
            // CPTAene
            // 
            this.CPTAene.Location = new System.Drawing.Point(302, 17);
            this.CPTAene.Name = "CPTAene";
            this.CPTAene.Size = new System.Drawing.Size(41, 20);
            this.CPTAene.TabIndex = 66;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(267, 20);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(29, 13);
            this.label49.TabIndex = 65;
            this.label49.Text = "ENE";
            // 
            // CPTAfri
            // 
            this.CPTAfri.Location = new System.Drawing.Point(210, 52);
            this.CPTAfri.Name = "CPTAfri";
            this.CPTAfri.Size = new System.Drawing.Size(41, 20);
            this.CPTAfri.TabIndex = 64;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(180, 55);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(24, 13);
            this.label46.TabIndex = 63;
            this.label46.Text = "FRI";
            // 
            // CPTAele
            // 
            this.CPTAele.Location = new System.Drawing.Point(126, 52);
            this.CPTAele.Name = "CPTAele";
            this.CPTAele.Size = new System.Drawing.Size(41, 20);
            this.CPTAele.TabIndex = 62;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(93, 55);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(27, 13);
            this.label47.TabIndex = 61;
            this.label47.Text = "ELE";
            // 
            // CPTAcal
            // 
            this.CPTAcal.Location = new System.Drawing.Point(37, 52);
            this.CPTAcal.Name = "CPTAcal";
            this.CPTAcal.Size = new System.Drawing.Size(41, 20);
            this.CPTAcal.TabIndex = 60;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(4, 55);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(27, 13);
            this.label48.TabIndex = 59;
            this.label48.Text = "CAL";
            // 
            // CPTApen
            // 
            this.CPTApen.Location = new System.Drawing.Point(210, 17);
            this.CPTApen.Name = "CPTApen";
            this.CPTApen.Size = new System.Drawing.Size(41, 20);
            this.CPTApen.TabIndex = 58;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(175, 20);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(29, 13);
            this.label45.TabIndex = 57;
            this.label45.Text = "PEN";
            // 
            // CPTAcon
            // 
            this.CPTAcon.Location = new System.Drawing.Point(126, 17);
            this.CPTAcon.Name = "CPTAcon";
            this.CPTAcon.Size = new System.Drawing.Size(41, 20);
            this.CPTAcon.TabIndex = 56;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(90, 20);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 13);
            this.label41.TabIndex = 55;
            this.label41.Text = "CON";
            // 
            // CPTAfil
            // 
            this.CPTAfil.Location = new System.Drawing.Point(37, 17);
            this.CPTAfil.Name = "CPTAfil";
            this.CPTAfil.Size = new System.Drawing.Size(41, 20);
            this.CPTAfil.TabIndex = 54;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(9, 20);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(22, 13);
            this.label40.TabIndex = 0;
            this.label40.Text = "FIL";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CPD8defensa);
            this.groupBox6.Controls.Add(this.CPD8nombre);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.CPD7defensa);
            this.groupBox6.Controls.Add(this.CPD7nombre);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.CPD6defensa);
            this.groupBox6.Controls.Add(this.CPD6nombre);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.CPD5defensa);
            this.groupBox6.Controls.Add(this.CPD5nombre);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.CPD4defensa);
            this.groupBox6.Controls.Add(this.CPD4nombre);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.CPD3defensa);
            this.groupBox6.Controls.Add(this.CPD3nombre);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.CPD2defensa);
            this.groupBox6.Controls.Add(this.CPD2nombre);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.label42);
            this.groupBox6.Controls.Add(this.CPD1defensa);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.CPD1nombre);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Location = new System.Drawing.Point(398, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(261, 261);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Defensa";
            // 
            // CPD8defensa
            // 
            this.CPD8defensa.Location = new System.Drawing.Point(160, 223);
            this.CPD8defensa.Name = "CPD8defensa";
            this.CPD8defensa.Size = new System.Drawing.Size(67, 20);
            this.CPD8defensa.TabIndex = 43;
            // 
            // CPD8nombre
            // 
            this.CPD8nombre.Location = new System.Drawing.Point(44, 223);
            this.CPD8nombre.Name = "CPD8nombre";
            this.CPD8nombre.Size = new System.Drawing.Size(110, 20);
            this.CPD8nombre.TabIndex = 41;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 226);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(33, 13);
            this.label33.TabIndex = 42;
            this.label33.Text = "Def 8";
            // 
            // CPD7defensa
            // 
            this.CPD7defensa.Location = new System.Drawing.Point(160, 197);
            this.CPD7defensa.Name = "CPD7defensa";
            this.CPD7defensa.Size = new System.Drawing.Size(67, 20);
            this.CPD7defensa.TabIndex = 40;
            // 
            // CPD7nombre
            // 
            this.CPD7nombre.Location = new System.Drawing.Point(44, 197);
            this.CPD7nombre.Name = "CPD7nombre";
            this.CPD7nombre.Size = new System.Drawing.Size(110, 20);
            this.CPD7nombre.TabIndex = 38;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 200);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(33, 13);
            this.label34.TabIndex = 39;
            this.label34.Text = "Def 7";
            // 
            // CPD6defensa
            // 
            this.CPD6defensa.Location = new System.Drawing.Point(160, 171);
            this.CPD6defensa.Name = "CPD6defensa";
            this.CPD6defensa.Size = new System.Drawing.Size(67, 20);
            this.CPD6defensa.TabIndex = 37;
            // 
            // CPD6nombre
            // 
            this.CPD6nombre.Location = new System.Drawing.Point(44, 171);
            this.CPD6nombre.Name = "CPD6nombre";
            this.CPD6nombre.Size = new System.Drawing.Size(110, 20);
            this.CPD6nombre.TabIndex = 35;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 174);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(33, 13);
            this.label35.TabIndex = 36;
            this.label35.Text = "Def 6";
            // 
            // CPD5defensa
            // 
            this.CPD5defensa.Location = new System.Drawing.Point(160, 145);
            this.CPD5defensa.Name = "CPD5defensa";
            this.CPD5defensa.Size = new System.Drawing.Size(67, 20);
            this.CPD5defensa.TabIndex = 34;
            // 
            // CPD5nombre
            // 
            this.CPD5nombre.Location = new System.Drawing.Point(44, 145);
            this.CPD5nombre.Name = "CPD5nombre";
            this.CPD5nombre.Size = new System.Drawing.Size(110, 20);
            this.CPD5nombre.TabIndex = 32;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 148);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(33, 13);
            this.label36.TabIndex = 33;
            this.label36.Text = "Def 5";
            // 
            // CPD4defensa
            // 
            this.CPD4defensa.Location = new System.Drawing.Point(160, 120);
            this.CPD4defensa.Name = "CPD4defensa";
            this.CPD4defensa.Size = new System.Drawing.Size(67, 20);
            this.CPD4defensa.TabIndex = 31;
            // 
            // CPD4nombre
            // 
            this.CPD4nombre.Location = new System.Drawing.Point(44, 120);
            this.CPD4nombre.Name = "CPD4nombre";
            this.CPD4nombre.Size = new System.Drawing.Size(110, 20);
            this.CPD4nombre.TabIndex = 29;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 123);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(33, 13);
            this.label37.TabIndex = 30;
            this.label37.Text = "Def 4";
            // 
            // CPD3defensa
            // 
            this.CPD3defensa.Location = new System.Drawing.Point(160, 94);
            this.CPD3defensa.Name = "CPD3defensa";
            this.CPD3defensa.Size = new System.Drawing.Size(67, 20);
            this.CPD3defensa.TabIndex = 26;
            // 
            // CPD3nombre
            // 
            this.CPD3nombre.Location = new System.Drawing.Point(44, 94);
            this.CPD3nombre.Name = "CPD3nombre";
            this.CPD3nombre.Size = new System.Drawing.Size(110, 20);
            this.CPD3nombre.TabIndex = 24;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 97);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(33, 13);
            this.label38.TabIndex = 25;
            this.label38.Text = "Def 3";
            // 
            // CPD2defensa
            // 
            this.CPD2defensa.Location = new System.Drawing.Point(160, 68);
            this.CPD2defensa.Name = "CPD2defensa";
            this.CPD2defensa.Size = new System.Drawing.Size(67, 20);
            this.CPD2defensa.TabIndex = 21;
            // 
            // CPD2nombre
            // 
            this.CPD2nombre.Location = new System.Drawing.Point(44, 68);
            this.CPD2nombre.Name = "CPD2nombre";
            this.CPD2nombre.Size = new System.Drawing.Size(110, 20);
            this.CPD2nombre.TabIndex = 19;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 71);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(33, 13);
            this.label39.TabIndex = 20;
            this.label39.Text = "Def 2";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(171, 16);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 13);
            this.label42.TabIndex = 16;
            this.label42.Text = "Defensa";
            // 
            // CPD1defensa
            // 
            this.CPD1defensa.Location = new System.Drawing.Point(160, 42);
            this.CPD1defensa.Name = "CPD1defensa";
            this.CPD1defensa.Size = new System.Drawing.Size(67, 20);
            this.CPD1defensa.TabIndex = 13;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(76, 16);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 13);
            this.label43.TabIndex = 12;
            this.label43.Text = "Nombre";
            // 
            // CPD1nombre
            // 
            this.CPD1nombre.Location = new System.Drawing.Point(44, 42);
            this.CPD1nombre.Name = "CPD1nombre";
            this.CPD1nombre.Size = new System.Drawing.Size(110, 20);
            this.CPD1nombre.TabIndex = 11;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(6, 45);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(33, 13);
            this.label44.TabIndex = 11;
            this.label44.Text = "Def 1";
            // 
            // CPturno
            // 
            this.CPturno.Location = new System.Drawing.Point(161, 85);
            this.CPturno.Name = "CPturno";
            this.CPturno.Size = new System.Drawing.Size(48, 20);
            this.CPturno.TabIndex = 12;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(120, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 13);
            this.label32.TabIndex = 11;
            this.label32.Text = "Turno";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CPA8dano);
            this.groupBox5.Controls.Add(this.CPA8critico);
            this.groupBox5.Controls.Add(this.CPA8ha);
            this.groupBox5.Controls.Add(this.CPA8nombre);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.CPA7dano);
            this.groupBox5.Controls.Add(this.CPA7critico);
            this.groupBox5.Controls.Add(this.CPA7ha);
            this.groupBox5.Controls.Add(this.CPA7nombre);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.CPA6dano);
            this.groupBox5.Controls.Add(this.CPA6critico);
            this.groupBox5.Controls.Add(this.CPA6ha);
            this.groupBox5.Controls.Add(this.CPA6nombre);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.CPA5dano);
            this.groupBox5.Controls.Add(this.CPA5critico);
            this.groupBox5.Controls.Add(this.CPA5ha);
            this.groupBox5.Controls.Add(this.CPA5nombre);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.CPA4dano);
            this.groupBox5.Controls.Add(this.CPA4critico);
            this.groupBox5.Controls.Add(this.CPA4ha);
            this.groupBox5.Controls.Add(this.CPA4nombre);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.CPA3dano);
            this.groupBox5.Controls.Add(this.CPA3critico);
            this.groupBox5.Controls.Add(this.CPA3ha);
            this.groupBox5.Controls.Add(this.CPA3nombre);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.CPA2dano);
            this.groupBox5.Controls.Add(this.CPA2critico);
            this.groupBox5.Controls.Add(this.CPA2ha);
            this.groupBox5.Controls.Add(this.CPA2nombre);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.CPAdano);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.CPA1dano);
            this.groupBox5.Controls.Add(this.CPA1critico);
            this.groupBox5.Controls.Add(this.CPA1ha);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.CPA1nombre);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Location = new System.Drawing.Point(10, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(361, 261);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ataque";
            // 
            // CPA8dano
            // 
            this.CPA8dano.Location = new System.Drawing.Point(286, 224);
            this.CPA8dano.Name = "CPA8dano";
            this.CPA8dano.Size = new System.Drawing.Size(61, 20);
            this.CPA8dano.TabIndex = 53;
            // 
            // CPA8critico
            // 
            this.CPA8critico.BackColor = System.Drawing.SystemColors.Window;
            this.CPA8critico.FormattingEnabled = true;
            this.CPA8critico.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.CPA8critico.Location = new System.Drawing.Point(207, 223);
            this.CPA8critico.Name = "CPA8critico";
            this.CPA8critico.Size = new System.Drawing.Size(73, 21);
            this.CPA8critico.TabIndex = 52;
            // 
            // CPA8ha
            // 
            this.CPA8ha.Location = new System.Drawing.Point(160, 224);
            this.CPA8ha.Name = "CPA8ha";
            this.CPA8ha.Size = new System.Drawing.Size(41, 20);
            this.CPA8ha.TabIndex = 51;
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
            // CPA7dano
            // 
            this.CPA7dano.Location = new System.Drawing.Point(286, 198);
            this.CPA7dano.Name = "CPA7dano";
            this.CPA7dano.Size = new System.Drawing.Size(61, 20);
            this.CPA7dano.TabIndex = 48;
            // 
            // CPA7critico
            // 
            this.CPA7critico.BackColor = System.Drawing.SystemColors.Window;
            this.CPA7critico.FormattingEnabled = true;
            this.CPA7critico.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.CPA7critico.Location = new System.Drawing.Point(207, 197);
            this.CPA7critico.Name = "CPA7critico";
            this.CPA7critico.Size = new System.Drawing.Size(73, 21);
            this.CPA7critico.TabIndex = 47;
            // 
            // CPA7ha
            // 
            this.CPA7ha.Location = new System.Drawing.Point(160, 198);
            this.CPA7ha.Name = "CPA7ha";
            this.CPA7ha.Size = new System.Drawing.Size(41, 20);
            this.CPA7ha.TabIndex = 46;
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
            // CPA6dano
            // 
            this.CPA6dano.Location = new System.Drawing.Point(286, 172);
            this.CPA6dano.Name = "CPA6dano";
            this.CPA6dano.Size = new System.Drawing.Size(61, 20);
            this.CPA6dano.TabIndex = 43;
            // 
            // CPA6critico
            // 
            this.CPA6critico.BackColor = System.Drawing.SystemColors.Window;
            this.CPA6critico.FormattingEnabled = true;
            this.CPA6critico.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.CPA6critico.Location = new System.Drawing.Point(207, 171);
            this.CPA6critico.Name = "CPA6critico";
            this.CPA6critico.Size = new System.Drawing.Size(73, 21);
            this.CPA6critico.TabIndex = 42;
            // 
            // CPA6ha
            // 
            this.CPA6ha.Location = new System.Drawing.Point(160, 172);
            this.CPA6ha.Name = "CPA6ha";
            this.CPA6ha.Size = new System.Drawing.Size(41, 20);
            this.CPA6ha.TabIndex = 41;
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
            // CPA5dano
            // 
            this.CPA5dano.Location = new System.Drawing.Point(286, 146);
            this.CPA5dano.Name = "CPA5dano";
            this.CPA5dano.Size = new System.Drawing.Size(61, 20);
            this.CPA5dano.TabIndex = 38;
            // 
            // CPA5critico
            // 
            this.CPA5critico.BackColor = System.Drawing.SystemColors.Window;
            this.CPA5critico.FormattingEnabled = true;
            this.CPA5critico.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.CPA5critico.Location = new System.Drawing.Point(207, 145);
            this.CPA5critico.Name = "CPA5critico";
            this.CPA5critico.Size = new System.Drawing.Size(73, 21);
            this.CPA5critico.TabIndex = 37;
            // 
            // CPA5ha
            // 
            this.CPA5ha.Location = new System.Drawing.Point(160, 146);
            this.CPA5ha.Name = "CPA5ha";
            this.CPA5ha.Size = new System.Drawing.Size(41, 20);
            this.CPA5ha.TabIndex = 36;
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
            // CPA4dano
            // 
            this.CPA4dano.Location = new System.Drawing.Point(286, 120);
            this.CPA4dano.Name = "CPA4dano";
            this.CPA4dano.Size = new System.Drawing.Size(61, 20);
            this.CPA4dano.TabIndex = 33;
            // 
            // CPA4critico
            // 
            this.CPA4critico.BackColor = System.Drawing.SystemColors.Window;
            this.CPA4critico.FormattingEnabled = true;
            this.CPA4critico.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.CPA4critico.Location = new System.Drawing.Point(207, 119);
            this.CPA4critico.Name = "CPA4critico";
            this.CPA4critico.Size = new System.Drawing.Size(73, 21);
            this.CPA4critico.TabIndex = 32;
            // 
            // CPA4ha
            // 
            this.CPA4ha.Location = new System.Drawing.Point(160, 120);
            this.CPA4ha.Name = "CPA4ha";
            this.CPA4ha.Size = new System.Drawing.Size(41, 20);
            this.CPA4ha.TabIndex = 31;
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
            // CPA3dano
            // 
            this.CPA3dano.Location = new System.Drawing.Point(286, 94);
            this.CPA3dano.Name = "CPA3dano";
            this.CPA3dano.Size = new System.Drawing.Size(61, 20);
            this.CPA3dano.TabIndex = 28;
            // 
            // CPA3critico
            // 
            this.CPA3critico.BackColor = System.Drawing.SystemColors.Window;
            this.CPA3critico.FormattingEnabled = true;
            this.CPA3critico.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.CPA3critico.Location = new System.Drawing.Point(207, 93);
            this.CPA3critico.Name = "CPA3critico";
            this.CPA3critico.Size = new System.Drawing.Size(73, 21);
            this.CPA3critico.TabIndex = 27;
            // 
            // CPA3ha
            // 
            this.CPA3ha.Location = new System.Drawing.Point(160, 94);
            this.CPA3ha.Name = "CPA3ha";
            this.CPA3ha.Size = new System.Drawing.Size(41, 20);
            this.CPA3ha.TabIndex = 26;
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
            // CPA2dano
            // 
            this.CPA2dano.Location = new System.Drawing.Point(286, 68);
            this.CPA2dano.Name = "CPA2dano";
            this.CPA2dano.Size = new System.Drawing.Size(61, 20);
            this.CPA2dano.TabIndex = 23;
            // 
            // CPA2critico
            // 
            this.CPA2critico.BackColor = System.Drawing.SystemColors.Window;
            this.CPA2critico.FormattingEnabled = true;
            this.CPA2critico.Items.AddRange(new object[] {
            "FIL",
            "CON",
            "PEN",
            "CAL",
            "ELE",
            "FRI",
            "ENE"});
            this.CPA2critico.Location = new System.Drawing.Point(207, 67);
            this.CPA2critico.Name = "CPA2critico";
            this.CPA2critico.Size = new System.Drawing.Size(73, 21);
            this.CPA2critico.TabIndex = 22;
            // 
            // CPA2ha
            // 
            this.CPA2ha.Location = new System.Drawing.Point(160, 68);
            this.CPA2ha.Name = "CPA2ha";
            this.CPA2ha.Size = new System.Drawing.Size(41, 20);
            this.CPA2ha.TabIndex = 21;
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
            // CPAdano
            // 
            this.CPAdano.AutoSize = true;
            this.CPAdano.Location = new System.Drawing.Point(299, 16);
            this.CPAdano.Name = "CPAdano";
            this.CPAdano.Size = new System.Drawing.Size(33, 13);
            this.CPAdano.TabIndex = 18;
            this.CPAdano.Text = "Daño";
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
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(170, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "HA";
            // 
            // CPA1dano
            // 
            this.CPA1dano.Location = new System.Drawing.Point(286, 42);
            this.CPA1dano.Name = "CPA1dano";
            this.CPA1dano.Size = new System.Drawing.Size(61, 20);
            this.CPA1dano.TabIndex = 15;
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
            // CPA1ha
            // 
            this.CPA1ha.Location = new System.Drawing.Point(160, 42);
            this.CPA1ha.Name = "CPA1ha";
            this.CPA1ha.Size = new System.Drawing.Size(41, 20);
            this.CPA1ha.TabIndex = 13;
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
            // CPA1nombre
            // 
            this.CPA1nombre.Location = new System.Drawing.Point(44, 42);
            this.CPA1nombre.Name = "CPA1nombre";
            this.CPA1nombre.Size = new System.Drawing.Size(110, 20);
            this.CPA1nombre.TabIndex = 11;
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
            // CPvida
            // 
            this.CPvida.Location = new System.Drawing.Point(299, 51);
            this.CPvida.Name = "CPvida";
            this.CPvida.Size = new System.Drawing.Size(48, 20);
            this.CPvida.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(235, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Vida Max";
            // 
            // CPcv
            // 
            this.CPcv.Location = new System.Drawing.Point(161, 51);
            this.CPcv.Name = "CPcv";
            this.CPcv.Size = new System.Drawing.Size(48, 20);
            this.CPcv.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(134, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "CV";
            // 
            // CPzeon
            // 
            this.CPzeon.Location = new System.Drawing.Point(57, 85);
            this.CPzeon.Name = "CPzeon";
            this.CPzeon.Size = new System.Drawing.Size(48, 20);
            this.CPzeon.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Zeon";
            // 
            // CPki
            // 
            this.CPki.Location = new System.Drawing.Point(57, 52);
            this.CPki.Name = "CPki";
            this.CPki.Size = new System.Drawing.Size(48, 20);
            this.CPki.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Ki";
            // 
            // CPnombre
            // 
            this.CPnombre.Location = new System.Drawing.Point(57, 17);
            this.CPnombre.Name = "CPnombre";
            this.CPnombre.Size = new System.Drawing.Size(389, 20);
            this.CPnombre.TabIndex = 1;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 563);
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
            // saveFileDialogTabla
            // 
            this.saveFileDialogTabla.DefaultExt = "apj";
            this.saveFileDialogTabla.Filter = "Anima PJ (*.apj)|*.apj";
            this.saveFileDialogTabla.Title = "Guardar personaje...";
            this.saveFileDialogTabla.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogTabla_FileOk);
            // 
            // openFileDialogTabla
            // 
            this.openFileDialogTabla.DefaultExt = "apj";
            this.openFileDialogTabla.Filter = "Anima PJ (*.apj)|*.apj";
            this.openFileDialogTabla.Title = "Cargar personaje...";
            this.openFileDialogTabla.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogTabla_FileOk);
            // 
            // openFileDialogCreador
            // 
            this.openFileDialogCreador.DefaultExt = "apj";
            this.openFileDialogCreador.Filter = "Anima PJ (*.apj)|*.apj";
            this.openFileDialogCreador.Title = "Cargar personaje...";
            this.openFileDialogCreador.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogCreador_FileOk);
            // 
            // saveFileDialogCreador
            // 
            this.saveFileDialogCreador.DefaultExt = "apj";
            this.saveFileDialogCreador.Filter = "Anima PJ (*.apj)|*.apj";
            this.saveFileDialogCreador.Title = "Guardar personaje...";
            this.saveFileDialogCreador.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogCreador_FileOk);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(390, 14);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(33, 13);
            this.label56.TabIndex = 3;
            this.label56.Text = "Dado";
            this.label56.Click += new System.EventHandler(this.label56_Click);
            // 
            // CALAdado
            // 
            this.CALAdado.Location = new System.Drawing.Point(429, 11);
            this.CALAdado.Name = "CALAdado";
            this.CALAdado.Size = new System.Drawing.Size(42, 20);
            this.CALAdado.TabIndex = 4;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(206, 14);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(41, 13);
            this.label57.TabIndex = 5;
            this.label57.Text = "Ataque";
            // 
            // CALataque
            // 
            this.CALataque.FormattingEnabled = true;
            this.CALataque.Location = new System.Drawing.Point(253, 10);
            this.CALataque.Name = "CALataque";
            this.CALataque.Size = new System.Drawing.Size(121, 21);
            this.CALataque.TabIndex = 6;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(486, 14);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(70, 13);
            this.label58.TabIndex = 7;
            this.label58.Text = "Bonos / Pen.";
            // 
            // CALAbono
            // 
            this.CALAbono.Location = new System.Drawing.Point(562, 12);
            this.CALAbono.Name = "CALAbono";
            this.CALAbono.Size = new System.Drawing.Size(43, 20);
            this.CALAbono.TabIndex = 8;
            this.CALAbono.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CALdefensa
            // 
            this.CALdefensa.FormattingEnabled = true;
            this.CALdefensa.Location = new System.Drawing.Point(253, 46);
            this.CALdefensa.Name = "CALdefensa";
            this.CALdefensa.Size = new System.Drawing.Size(121, 21);
            this.CALdefensa.TabIndex = 14;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(206, 49);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 13);
            this.label60.TabIndex = 13;
            this.label60.Text = "Defensa";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(7, 49);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(50, 13);
            this.label62.TabIndex = 10;
            this.label62.Text = "Defensor";
            // 
            // CALdefensor
            // 
            this.CALdefensor.FormattingEnabled = true;
            this.CALdefensor.Location = new System.Drawing.Point(63, 45);
            this.CALdefensor.Name = "CALdefensor";
            this.CALdefensor.Size = new System.Drawing.Size(121, 21);
            this.CALdefensor.TabIndex = 9;
            this.CALdefensor.SelectedValueChanged += new System.EventHandler(this.UpdateCALDefensor);
            // 
            // CALlog
            // 
            this.CALlog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CALlog.Location = new System.Drawing.Point(717, 10);
            this.CALlog.Name = "CALlog";
            this.CALlog.ReadOnly = true;
            this.CALlog.Size = new System.Drawing.Size(160, 125);
            this.CALlog.TabIndex = 17;
            this.CALlog.Text = "";
            // 
            // CALcal
            // 
            this.CALcal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CALcal.Location = new System.Drawing.Point(15, 89);
            this.CALcal.Name = "CALcal";
            this.CALcal.Size = new System.Drawing.Size(169, 23);
            this.CALcal.TabIndex = 10;
            this.CALcal.Text = "Calcular";
            this.CALcal.UseVisualStyleBackColor = true;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(621, 15);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(48, 13);
            this.label63.TabIndex = 18;
            this.label63.Text = "Mod. TA";
            // 
            // CALAta
            // 
            this.CALAta.Location = new System.Drawing.Point(675, 12);
            this.CALAta.Name = "CALAta";
            this.CALAta.Size = new System.Drawing.Size(27, 20);
            this.CALAta.TabIndex = 19;
            // 
            // CALDta
            // 
            this.CALDta.Location = new System.Drawing.Point(675, 47);
            this.CALDta.Name = "CALDta";
            this.CALDta.Size = new System.Drawing.Size(27, 20);
            this.CALDta.TabIndex = 25;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(621, 50);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(48, 13);
            this.label59.TabIndex = 24;
            this.label59.Text = "Mod. TA";
            // 
            // CALDbono
            // 
            this.CALDbono.Location = new System.Drawing.Point(562, 47);
            this.CALDbono.Name = "CALDbono";
            this.CALDbono.Size = new System.Drawing.Size(43, 20);
            this.CALDbono.TabIndex = 23;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(486, 49);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(70, 13);
            this.label61.TabIndex = 22;
            this.label61.Text = "Bonos / Pen.";
            // 
            // CALDdado
            // 
            this.CALDdado.Location = new System.Drawing.Point(429, 46);
            this.CALDdado.Name = "CALDdado";
            this.CALDdado.Size = new System.Drawing.Size(42, 20);
            this.CALDdado.TabIndex = 21;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(390, 49);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(33, 13);
            this.label64.TabIndex = 20;
            this.label64.Text = "Dado";
            // 
            // CALresultado
            // 
            this.CALresultado.BackColor = System.Drawing.SystemColors.Control;
            this.CALresultado.Location = new System.Drawing.Point(190, 73);
            this.CALresultado.Name = "CALresultado";
            this.CALresultado.ReadOnly = true;
            this.CALresultado.Size = new System.Drawing.Size(521, 62);
            this.CALresultado.TabIndex = 26;
            this.CALresultado.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1069, 613);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Anima Fácil";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefensa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtaque)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperador1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            Personaje perstemp = new Personaje();
            ListaPers.TryGetValue(dataGridView1.CurrentRow.Cells["Personaje"].Value.ToString(), out perstemp);
            Pers2Creador(perstemp);
        }
        private void rowsAddednousar(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateCALPrincipal();
        }
        private void rowsRemovednousar(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateCALPrincipal();
        }
        

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void saveFileDialogTabla_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = this.saveFileDialogTabla.FileName;
            //this.escribirFicheroTabla(fileName);
        }
        
        private void buttonImportar_Click(object sender, EventArgs e)
        {
            this.openFileDialogTabla.ShowDialog();
        }



        private void openFileDialogTabla_FileOk(object sender, CancelEventArgs e)
        {
            Personaje perstemp = new Personaje();
            BinaryFormatter BF = new BinaryFormatter();
            string fileName = this.openFileDialogTabla.FileName;
            FileStream FS = new FileStream(fileName, FileMode.Open);
            try
            {
                perstemp = (Personaje)BF.Deserialize(FS);
            }
            catch (SerializationException error)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + error.Message);
                throw;
            }
            finally
            {
                FS.Close();
            }
            Pers2Table(perstemp);
        }

        private void saveFileDialogCreador_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = this.saveFileDialogCreador.FileName;
            escribirficheroCreador(fileName);
            
        }

        void escribirficheroCreador(string filename)
        {
            
            BinaryFormatter BF = new BinaryFormatter();
            
            FileStream FS = new FileStream(filename, FileMode.Create);
            

            try
            {
                BF.Serialize(FS, PersAGuardar);
            }
            catch (SerializationException error)
            {
                Console.WriteLine("Failed to serialize. Reason: " + error.Message);
                throw;
            }
            finally
            {
                FS.Close();
            }
            
        }

        private void CPsave_Click(object sender, EventArgs e)
        {
            string fileName = "Vacio";
            if (CPnombre.Text != null)
            {
                fileName = CPnombre.Text;
            }
            PersAGuardar = Creador2Pers();

            this.saveFileDialogCreador.FileName = fileName;
            this.saveFileDialogCreador.ShowDialog();
        }

        int ParseNullableInt(string value)
        {
            if (value == null || value.Trim() == string.Empty || value == "")
            {
                return 0;
            }
            else
            {
                try
                {
                    return int.Parse(value);
                }
                catch
                {
                    return 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ListaPers.Remove(dataGridView1.CurrentRow.Cells["Personaje"].Value.ToString());
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            
        }

        private void CPload_Click(object sender, EventArgs e)
        {
            openFileDialogCreador.ShowDialog();
        }

        private void openFileDialogCreador_FileOk(object sender, CancelEventArgs e)
        {
            Personaje perstemp = new Personaje();
            BinaryFormatter BF = new BinaryFormatter();
            string fileName = this.openFileDialogCreador.FileName;
            FileStream FS = new FileStream(fileName, FileMode.Open);
            try
            {
                perstemp = (Personaje)BF.Deserialize(FS);
            }
            catch (SerializationException error)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + error.Message);
                throw;
            }
            finally
            {
                FS.Close();
            }

            Pers2Creador(perstemp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personaje perstemp = Creador2Pers();
            Pers2Table(perstemp);       
        }

        Personaje Creador2Pers()
        {
            Personaje perstemp = new Personaje();

            perstemp.Nombre = CPnombre.Text;
            perstemp.Ki = ParseNullableInt(CPki.Text);
            perstemp.Zeon = ParseNullableInt(CPzeon.Text);
            perstemp.CV = ParseNullableInt(CPcv.Text);
            perstemp.Turno = ParseNullableInt(CPturno.Text);
            perstemp.Vida = ParseNullableInt(CPvida.Text);
            perstemp.Cansancio = ParseNullableInt(CPcansancio.Text);
            perstemp.Natura = CPnatura.Text;
            perstemp.Suerte = CPsuerte.Text;
            perstemp.Uroboros = CPuroboros.Checked;
            perstemp.Notas = CPnotas.Text;

            perstemp.ListaAtaques[0].Nombre = CPA1nombre.Text;
            perstemp.ListaAtaques[1].Nombre = CPA2nombre.Text;
            perstemp.ListaAtaques[2].Nombre = CPA3nombre.Text;
            perstemp.ListaAtaques[3].Nombre = CPA4nombre.Text;
            perstemp.ListaAtaques[4].Nombre = CPA5nombre.Text;
            perstemp.ListaAtaques[5].Nombre = CPA6nombre.Text;
            perstemp.ListaAtaques[6].Nombre = CPA7nombre.Text;
            perstemp.ListaAtaques[7].Nombre = CPA8nombre.Text;

            perstemp.ListaAtaques[0].HA = ParseNullableInt(CPA1ha.Text);
            perstemp.ListaAtaques[1].HA = ParseNullableInt(CPA2ha.Text);
            perstemp.ListaAtaques[2].HA = ParseNullableInt(CPA3ha.Text);
            perstemp.ListaAtaques[3].HA = ParseNullableInt(CPA4ha.Text);
            perstemp.ListaAtaques[4].HA = ParseNullableInt(CPA5ha.Text);
            perstemp.ListaAtaques[5].HA = ParseNullableInt(CPA6ha.Text);
            perstemp.ListaAtaques[6].HA = ParseNullableInt(CPA7ha.Text);
            perstemp.ListaAtaques[7].HA = ParseNullableInt(CPA8ha.Text);

            perstemp.ListaAtaques[0].Critico = CPA1critico.Text;
            perstemp.ListaAtaques[1].Critico = CPA2critico.Text;
            perstemp.ListaAtaques[2].Critico = CPA3critico.Text;
            perstemp.ListaAtaques[3].Critico = CPA4critico.Text;
            perstemp.ListaAtaques[4].Critico = CPA5critico.Text;
            perstemp.ListaAtaques[5].Critico = CPA6critico.Text;
            perstemp.ListaAtaques[6].Critico = CPA7critico.Text;
            perstemp.ListaAtaques[7].Critico = CPA8critico.Text;

            perstemp.ListaAtaques[0].Dano = ParseNullableInt(CPA1dano.Text);
            perstemp.ListaAtaques[1].Dano = ParseNullableInt(CPA2dano.Text);
            perstemp.ListaAtaques[2].Dano = ParseNullableInt(CPA3dano.Text);
            perstemp.ListaAtaques[3].Dano = ParseNullableInt(CPA4dano.Text);
            perstemp.ListaAtaques[4].Dano = ParseNullableInt(CPA5dano.Text);
            perstemp.ListaAtaques[5].Dano = ParseNullableInt(CPA6dano.Text);
            perstemp.ListaAtaques[6].Dano = ParseNullableInt(CPA7dano.Text);
            perstemp.ListaAtaques[7].Dano = ParseNullableInt(CPA8dano.Text);

            perstemp.ListaDefensa[0].Nombre = CPD1nombre.Text;
            perstemp.ListaDefensa[1].Nombre = CPD2nombre.Text;
            perstemp.ListaDefensa[2].Nombre = CPD3nombre.Text;
            perstemp.ListaDefensa[3].Nombre = CPD4nombre.Text;
            perstemp.ListaDefensa[4].Nombre = CPD5nombre.Text;
            perstemp.ListaDefensa[5].Nombre = CPD6nombre.Text;
            perstemp.ListaDefensa[6].Nombre = CPD7nombre.Text;
            perstemp.ListaDefensa[7].Nombre = CPD8nombre.Text;

            perstemp.ListaDefensa[0].Def = ParseNullableInt(CPD1defensa.Text);
            perstemp.ListaDefensa[1].Def = ParseNullableInt(CPD2defensa.Text);
            perstemp.ListaDefensa[2].Def = ParseNullableInt(CPD3defensa.Text);
            perstemp.ListaDefensa[3].Def = ParseNullableInt(CPD4defensa.Text);
            perstemp.ListaDefensa[4].Def = ParseNullableInt(CPD5defensa.Text);
            perstemp.ListaDefensa[5].Def = ParseNullableInt(CPD6defensa.Text);
            perstemp.ListaDefensa[6].Def = ParseNullableInt(CPD7defensa.Text);
            perstemp.ListaDefensa[7].Def = ParseNullableInt(CPD8defensa.Text);

            perstemp.FIL = ParseNullableInt(CPTAfil.Text);
            perstemp.CAL = ParseNullableInt(CPTAcal.Text);
            perstemp.CON = ParseNullableInt(CPTAcon.Text);
            perstemp.ELE = ParseNullableInt(CPTAele.Text);
            perstemp.PEN = ParseNullableInt(CPTApen.Text);
            perstemp.FRI = ParseNullableInt(CPTAfri.Text);
            perstemp.ENE = ParseNullableInt(CPTAene.Text);

            return perstemp;

        }

        void Pers2Creador(Personaje perstemp)
        {
            CPnombre.Text = perstemp.Nombre;
            CPki.Text = perstemp.Ki.ToString();
            CPzeon.Text = perstemp.Zeon.ToString();
            CPcv.Text = perstemp.CV.ToString();
            CPturno.Text = perstemp.Turno.ToString();
            CPvida.Text = perstemp.Vida.ToString();
            CPcansancio.Text = perstemp.Cansancio.ToString();
            CPnatura.Text = perstemp.Natura;
            CPsuerte.Text = perstemp.Suerte;
            CPuroboros.Checked = perstemp.Uroboros;
            CPnotas.Text = perstemp.Notas;

            CPA1nombre.Text = perstemp.ListaAtaques[0].Nombre;
            CPA2nombre.Text = perstemp.ListaAtaques[1].Nombre;
            CPA3nombre.Text = perstemp.ListaAtaques[2].Nombre;
            CPA4nombre.Text = perstemp.ListaAtaques[3].Nombre;
            CPA5nombre.Text = perstemp.ListaAtaques[4].Nombre;
            CPA6nombre.Text = perstemp.ListaAtaques[5].Nombre;
            CPA7nombre.Text = perstemp.ListaAtaques[6].Nombre;
            CPA8nombre.Text = perstemp.ListaAtaques[7].Nombre;

            CPA1ha.Text = perstemp.ListaAtaques[0].HA.ToString();
            CPA2ha.Text = perstemp.ListaAtaques[1].HA.ToString();
            CPA3ha.Text = perstemp.ListaAtaques[2].HA.ToString();
            CPA4ha.Text = perstemp.ListaAtaques[3].HA.ToString();
            CPA5ha.Text = perstemp.ListaAtaques[4].HA.ToString();
            CPA6ha.Text = perstemp.ListaAtaques[5].HA.ToString();
            CPA7ha.Text = perstemp.ListaAtaques[6].HA.ToString();
            CPA8ha.Text = perstemp.ListaAtaques[7].HA.ToString();

            CPA1critico.Text = perstemp.ListaAtaques[0].Critico;
            CPA2critico.Text = perstemp.ListaAtaques[1].Critico;
            CPA3critico.Text = perstemp.ListaAtaques[2].Critico;
            CPA4critico.Text = perstemp.ListaAtaques[3].Critico;
            CPA5critico.Text = perstemp.ListaAtaques[4].Critico;
            CPA6critico.Text = perstemp.ListaAtaques[5].Critico;
            CPA7critico.Text = perstemp.ListaAtaques[6].Critico;
            CPA8critico.Text = perstemp.ListaAtaques[7].Critico;

            CPA1dano.Text = perstemp.ListaAtaques[0].Dano.ToString();
            CPA2dano.Text = perstemp.ListaAtaques[1].Dano.ToString();
            CPA3dano.Text = perstemp.ListaAtaques[2].Dano.ToString();
            CPA4dano.Text = perstemp.ListaAtaques[3].Dano.ToString();
            CPA5dano.Text = perstemp.ListaAtaques[4].Dano.ToString();
            CPA6dano.Text = perstemp.ListaAtaques[5].Dano.ToString();
            CPA7dano.Text = perstemp.ListaAtaques[6].Dano.ToString();
            CPA8dano.Text = perstemp.ListaAtaques[7].Dano.ToString();

            CPD1nombre.Text = perstemp.ListaDefensa[0].Nombre;
            CPD2nombre.Text = perstemp.ListaDefensa[1].Nombre;
            CPD3nombre.Text = perstemp.ListaDefensa[2].Nombre;
            CPD4nombre.Text = perstemp.ListaDefensa[3].Nombre;
            CPD5nombre.Text = perstemp.ListaDefensa[4].Nombre;
            CPD6nombre.Text = perstemp.ListaDefensa[5].Nombre;
            CPD7nombre.Text = perstemp.ListaDefensa[6].Nombre;
            CPD8nombre.Text = perstemp.ListaDefensa[7].Nombre;

            CPD1defensa.Text = perstemp.ListaDefensa[0].Def.ToString();
            CPD2defensa.Text = perstemp.ListaDefensa[1].Def.ToString();
            CPD3defensa.Text = perstemp.ListaDefensa[2].Def.ToString();
            CPD4defensa.Text = perstemp.ListaDefensa[3].Def.ToString();
            CPD5defensa.Text = perstemp.ListaDefensa[4].Def.ToString();
            CPD6defensa.Text = perstemp.ListaDefensa[5].Def.ToString();
            CPD7defensa.Text = perstemp.ListaDefensa[6].Def.ToString();
            CPD8defensa.Text = perstemp.ListaDefensa[7].Def.ToString();

            CPTAfil.Text = perstemp.FIL.ToString();
            CPTAcal.Text = perstemp.CAL.ToString();
            CPTAcon.Text = perstemp.CON.ToString();
            CPTAele.Text = perstemp.ELE.ToString();
            CPTApen.Text = perstemp.PEN.ToString();
            CPTAfri.Text = perstemp.FRI.ToString();
            CPTAene.Text = perstemp.ENE.ToString();
        }

        void Pers2Table(Personaje perstemp)
        {
            if(perstemp.Nombre != null && perstemp.Nombre != "")
            {
                bool Haskey;
                int NombreMas = 0;
                Haskey = ListaPers.ContainsKey(perstemp.Nombre);
                string test = perstemp.Nombre;
                while (Haskey)
                {
                    NombreMas++;
                    test = perstemp.Nombre;
                    test = test + NombreMas;
                    Haskey = ListaPers.ContainsKey(test);
                }
                perstemp.Nombre = test;
                ListaPers.Add(perstemp.Nombre, perstemp);
                dataGridView1.Rows.Add();
                int i = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[i].Cells["Personaje"].Value = perstemp.Nombre;
                dataGridView1.Rows[i].Cells["Turno"].Value = perstemp.Turno;
                dataGridView1.Rows[i].Cells["VidaActual"].Value = perstemp.Vida;
                dataGridView1.Rows[i].Cells["VidaMax"].Value = perstemp.Vida;
                dataGridView1.Rows[i].Cells["Cansancio"].Value = perstemp.Cansancio;
                dataGridView1.Rows[i].Cells["Ki"].Value = perstemp.Ki;
                dataGridView1.Rows[i].Cells["Zeon"].Value = perstemp.Zeon;
                dataGridView1.Rows[i].Cells["CV"].Value = perstemp.CV;
                dataGridView1.Rows[i].Cells["Natura"].Value = perstemp.Natura;
                dataGridView1.Rows[i].Cells["Notas"].Value = perstemp.Notas;
                dataGridView1.Rows[i].Cells["Suerte"].Value = perstemp.Suerte;
                dataGridView1.Rows[i].Cells["Uroboros"].Value = perstemp.Uroboros;
                dataGridView1.Rows[i].Cells["Notas"].Value = perstemp.Notas;
            }
            
        }

        void UpdateCALPrincipal()
        {
            CALatacante.Items.Clear();
            CALdefensor.Items.Clear();
            CALataque.Items.Clear();
            CALdefensa.Items.Clear();
            CALAdado.Clear();
            CALDdado.Clear();
            CALAbono.Clear();
            CALDbono.Clear();
            CALAta.Clear();
            CALDta.Clear();

            foreach (KeyValuePair<string, Personaje> Pers in ListaPers)
            {
                CALatacante.Items.Add(Pers.Key);
                CALdefensor.Items.Add(Pers.Key);
            }
        }

        void UpdateCALAtacante(object sender, EventArgs e)
        {
            Personaje perstemp;
            ListaPers.TryGetValue(CALatacante.SelectedValue.ToString(), out perstemp);
            foreach (Personaje.Ataque Ata in perstemp.ListaAtaques)
            {
                if(Ata.Nombre != null && Ata.Nombre !="")
                {
                    if(Ata.Critico != null && Ata.Critico != "")
                    {

                    }
                }

            }
        }

        void UpdateCALDefensor(object sender, EventArgs e)
        {

        }

        private void Cpclean_Click(object sender, EventArgs e)
        {
            CPnombre.Clear();
            CPki.Clear();
            CPzeon.Clear();
            CPcv.Clear();
            CPturno.Clear();
            CPvida.Clear();
            CPcansancio.Clear();            
            CPnotas.Clear();
            CPnatura.SelectedIndex = -1;
            CPsuerte.SelectedIndex = -1;
            CPuroboros.Checked = false;


            CPA1nombre.Clear();
            CPA2nombre.Clear();
            CPA3nombre.Clear();
            CPA4nombre.Clear();
            CPA5nombre.Clear();
            CPA6nombre.Clear();
            CPA7nombre.Clear();
            CPA8nombre.Clear();

            CPA1ha.Clear();
            CPA2ha.Clear();
            CPA3ha.Clear();
            CPA4ha.Clear();
            CPA5ha.Clear();
            CPA6ha.Clear();
            CPA7ha.Clear();
            CPA8ha.Clear();

            CPA1critico.SelectedIndex = -1;
            CPA2critico.SelectedIndex = -1;
            CPA3critico.SelectedIndex = -1;
            CPA4critico.SelectedIndex = -1;
            CPA5critico.SelectedIndex = -1;
            CPA6critico.SelectedIndex = -1;
            CPA7critico.SelectedIndex = -1;
            CPA8critico.SelectedIndex = -1;

            CPA1dano.Clear();
            CPA2dano.Clear();
            CPA3dano.Clear();
            CPA4dano.Clear();
            CPA5dano.Clear();
            CPA6dano.Clear();
            CPA7dano.Clear();
            CPA8dano.Clear();

            CPD1nombre.Clear();
            CPD2nombre.Clear();
            CPD3nombre.Clear();
            CPD4nombre.Clear();
            CPD5nombre.Clear();
            CPD6nombre.Clear();
            CPD7nombre.Clear();
            CPD8nombre.Clear();

            CPD1defensa.Clear();
            CPD2defensa.Clear();
            CPD3defensa.Clear();
            CPD4defensa.Clear();
            CPD5defensa.Clear();
            CPD6defensa.Clear();
            CPD7defensa.Clear();
            CPD8defensa.Clear();

            CPTAfil.Clear();
            CPTAcal.Clear();
            CPTAcon.Clear();
            CPTAele.Clear();
            CPTApen.Clear();
            CPTAfri.Clear();
            CPTAene.Clear();
        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

    [Serializable()]
    public class Personaje
    {
        public string Nombre;
        public int Cansancio;
        public int Turno;
        public int Ki;
        public int Zeon;
        public int CV;
        public int Vida;
        public string Natura;
        public string Suerte;
        public string Notas;
        public bool Uroboros;
        public Ataque[] ListaAtaques = new Ataque[8];
        public Defensa[] ListaDefensa = new Defensa[8];

        [Serializable()]
        public struct Ataque
        {
            public string Nombre;
            public int HA;
            public string Critico;
            public int Dano;
        }
        [Serializable()]
        public struct Defensa
        {
            public string Nombre;
            public int Def;
        }

        public int FIL;
        public int CAL;
        public int CON;
        public int ELE;
        public int PEN;
        public int FRI;
        public int ENE;
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