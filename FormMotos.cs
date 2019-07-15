using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ManejoInventariosBD
{
    public partial class FormMotos : Form
    {
        public int rdbChecked;
        private bool fail;
        private bool cond1;
        private bool cond2;
        private bool cond3;
        private bool cond4;
        private bool cond5;
        CrearTabla ctm = new CrearTabla();
       
        public static MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;Database=patiosd1c");

        string tipo1;
        public FormMotos(string tipo)
        {
            

            InitializeComponent();
            this.tipo1 = tipo;
            
            
            
           

            
        }

        Moto motoreg = new Moto();

        private void FormMotos_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ctm.recibetabla("motivos");
            comboBox1.DisplayMember = "Motivo";

            comboBox2.DataSource = ctm.tablaor("autoridad", "Autoridad", "Formulario_Asociado", "Ambos", "Moto");
            comboBox2.DisplayMember = "Autoridad";

            comboBoxColor.DataSource = ctm.tablaor("colores", "Color", "Form_Asociado", "Ambos", "Moto");
            comboBoxColor.DisplayMember = "Color";
        }



        


        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (!((tableLayoutPanel2.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel3.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel4.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel5.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel6.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel7.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel8.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel9.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel10.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel11.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel12.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel13.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel14.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel15.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel16.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel17.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel18.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel19.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel20.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel22.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel23.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel24.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel25.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel26.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel27.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel28.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel29.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel30.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel31.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel32.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel33.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel34.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel35.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel36.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel37.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel38.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel39.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
                (tableLayoutPanel40.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&

                (panel1.Controls.OfType<RadioButton>().Any(x => x.Checked)) && (panel2.Controls.OfType<RadioButton>().Any(x => x.Checked))
                ))
            {
                MessageBox.Show("Registros incompletos, intente nuevamente");
                cond1 = true;
            }
            else
                cond1 = false;





            string color = comboBoxColor.Text;
            if (
                (color == "Blanco" || color == "Negro" || color == "Rojo" || color == "Verde" || color == "Azul" || color == "Amarillo" || color == "Naranja")
                )
            {
                motoreg.SetColor(color);
                cond4 = false;
            }
            else
            {
                MessageBox.Show("Error al insertar color");
                cond4 = true;
            }

            
                
            if (textBoxplaca.Text.Length == 6 || textBoxplaca.Text.Length == 7 )
            {
                cond5 = false;
                
            }
            else
            {
                MessageBox.Show("La placa que ha ingresado no es valida");
                cond5 = true;
            }



            if (comboBox1.Text != "Patios" && comboBox1.Text != "Accidente")
            {
                MessageBox.Show("Motivo de ingreso no valido, intente nuevamente");
                cond2 = true;
            }
            else
                cond2 = false;

            if (comboBox2.Text != "Policía" && comboBox2.Text != "Transito" && comboBox2.Text != "Policia de Tránsito y Transporte" && comboBox2.Text != "Juzgado" && comboBox2.Text != "Fiscalía" && comboBox2.Text != "Otro")
            {
                MessageBox.Show("Autoridad que ingresa no valida, intente nuevamente");
                
                cond3 = true;
            }
            else
                cond3 = false;
            int parsedValue;

            

            if (textBox6.Text == "")
            {
                fail = true;
                MessageBox.Show("No ha insertado un número de inventario");
                
                
            }
            
            if (!int.TryParse(textBox6.Text, out parsedValue))
            {
                MessageBox.Show("El número de inventario no acepta caracteres");
                return;
            }
            else if((!(int.TryParse(textBox6.Text, out parsedValue))))
            {
                int i = int.Parse(textBox6.Text);
                if (!(i <= 9999 && i >= 1000) )
                {
                    MessageBox.Show("No ha insertado un número de inventario valido");
                    fail = true;
                    return;
                }
            }
            else
                fail = false;



            


            if (fail == false && cond1==false && cond2 == false && cond3 == false && cond4 == false && cond5 == false)
            {


                //De aquí hacia arriba todo funciona

                if (this.radioButton1.Checked == true)
                    motoreg.SetFarola("B");
                if (this.radioButton2.Checked == true)
                    motoreg.SetFarola("R");
                if (this.radioButton3.Checked == true)
                    motoreg.SetFarola("M");
                if (this.radioButton4.Checked == true)
                    motoreg.SetFarola("N/A");
                if (this.radioButton5.Checked == true)
                    motoreg.SetFarola("N/V");

                if (this.radioButton6.Checked == true)
                    motoreg.SetExploradora("B");
                if (this.radioButton7.Checked == true)
                    motoreg.SetExploradora("R");
                if (this.radioButton8.Checked == true)
                    motoreg.SetExploradora("M");
                if (this.radioButton9.Checked == true)
                    motoreg.SetExploradora("N/A");
                if (this.radioButton10.Checked == true)
                    motoreg.SetExploradora("N/V");

                if (this.radioButton11.Checked == true)
                    motoreg.SetCarenaje("B");
                if (this.radioButton12.Checked == true)
                    motoreg.SetCarenaje("R");
                if (this.radioButton13.Checked == true)
                    motoreg.SetCarenaje("M");
                if (this.radioButton14.Checked == true)
                    motoreg.SetCarenaje("N/A");
                if (this.radioButton15.Checked == true)
                    motoreg.SetCarenaje("N/V");

                if (this.radioButton16.Checked == true)
                    motoreg.SetPito("B");
                if (this.radioButton17.Checked == true)
                    motoreg.SetPito("R");
                if (this.radioButton18.Checked == true)
                    motoreg.SetPito("M");
                if (this.radioButton19.Checked == true)
                    motoreg.SetPito("N/A");
                if (this.radioButton20.Checked == true)
                    motoreg.SetPito("N/V");

                if (this.radioButton21.Checked == true)
                    motoreg.SetGBDel("B");
                if (this.radioButton22.Checked == true)
                    motoreg.SetGBDel("R");
                if (this.radioButton23.Checked == true)
                    motoreg.SetGBDel("M");
                if (this.radioButton24.Checked == true)
                    motoreg.SetGBDel("N/A");
                if (this.radioButton25.Checked == true)
                    motoreg.SetGBDel("N/V");

                if (this.radioButton26.Checked == true)
                    motoreg.SetFrenoDisco("B");
                if (this.radioButton27.Checked == true)
                    motoreg.SetFrenoDisco("R");
                if (this.radioButton28.Checked == true)
                    motoreg.SetFrenoDisco("M");
                if (this.radioButton29.Checked == true)
                    motoreg.SetFrenoDisco("N/A");
                if (this.radioButton30.Checked == true)
                    motoreg.SetFrenoDisco("N/V");

                if (this.radioButton31.Checked == true)
                    motoreg.SetTablero("B");
                if (this.radioButton32.Checked == true)
                    motoreg.SetTablero("R");
                if (this.radioButton33.Checked == true)
                    motoreg.SetTablero("M");
                if (this.radioButton34.Checked == true)
                    motoreg.SetTablero("N/A");
                if (this.radioButton35.Checked == true)
                    motoreg.SetTablero("N/V");

                if (this.radioButton36.Checked == true)
                    motoreg.SetDirDelIzq("B");
                if (this.radioButton37.Checked == true)
                    motoreg.SetDirDelIzq("R");
                if (this.radioButton38.Checked == true)
                    motoreg.SetDirDelIzq("M");
                if (this.radioButton39.Checked == true)
                    motoreg.SetDirDelIzq("N/A");
                if (this.radioButton40.Checked == true)
                    motoreg.SetDirDelIzq("N/V");

                if (this.radioButton41.Checked == true)
                    motoreg.SetEspizq("B");
                if (this.radioButton42.Checked == true)
                    motoreg.SetEspizq("R");
                if (this.radioButton43.Checked == true)
                    motoreg.SetEspizq("M");
                if (this.radioButton44.Checked == true)
                    motoreg.SetEspizq("N/A");
                if (this.radioButton45.Checked == true)
                    motoreg.SetEspizq("N/V");

                if (this.radioButton46.Checked == true)
                    motoreg.SetManDirIzq("B");
                if (this.radioButton47.Checked == true)
                    motoreg.SetManDirIzq("R");
                if (this.radioButton48.Checked == true)
                    motoreg.SetManDirIzq("M");
                if (this.radioButton49.Checked == true)
                    motoreg.SetManDirIzq("N/A");
                if (this.radioButton50.Checked == true)
                    motoreg.SetManDirIzq("N/V");

                if (this.radioButton51.Checked == true)
                    motoreg.SetManIzq("B");
                if (this.radioButton52.Checked == true)
                    motoreg.SetManIzq("R");
                if (this.radioButton53.Checked == true)
                    motoreg.SetManIzq("M");
                if (this.radioButton54.Checked == true)
                    motoreg.SetManIzq("N/A");
                if (this.radioButton55.Checked == true)
                    motoreg.SetManIzq("N/V");

                if (this.radioButton56.Checked == true)
                    motoreg.SetPrManIzq("B");
                if (this.radioButton57.Checked == true)
                    motoreg.SetPrManIzq("R");
                if (this.radioButton58.Checked == true)
                    motoreg.SetPrManIzq("M");
                if (this.radioButton59.Checked == true)
                    motoreg.SetPrManIzq("N/A");
                if (this.radioButton60.Checked == true)
                    motoreg.SetPrManIzq("N/V");

                if (this.radioButton61.Checked == true)
                    motoreg.SetDirDelDer("B");
                if (this.radioButton62.Checked == true)
                    motoreg.SetDirDelDer("R");
                if (this.radioButton63.Checked == true)
                    motoreg.SetDirDelDer("M");
                if (this.radioButton64.Checked == true)
                    motoreg.SetDirDelDer("N/A");
                if (this.radioButton65.Checked == true)
                    motoreg.SetDirDelDer("N/V");

                if (this.radioButton66.Checked == true)
                    motoreg.SetEspDer("B");
                if (this.radioButton67.Checked == true)
                    motoreg.SetEspDer("R");
                if (this.radioButton68.Checked == true)
                    motoreg.SetEspDer("M");
                if (this.radioButton69.Checked == true)
                    motoreg.SetEspDer("N/A");
                if (this.radioButton70.Checked == true)
                    motoreg.SetEspDer("N/V");

                if (this.radioButton71.Checked == true)
                    motoreg.SetManDirDer("B");
                if (this.radioButton72.Checked == true)
                    motoreg.SetManDirDer("R");
                if (this.radioButton73.Checked == true)
                    motoreg.SetManDirDer("M");
                if (this.radioButton74.Checked == true)
                    motoreg.SetManDirDer("N/A");
                if (this.radioButton75.Checked == true)
                    motoreg.SetManDirDer("N/V");

                if (this.radioButton76.Checked == true)
                    motoreg.SetManFreDer("B");
                if (this.radioButton77.Checked == true)
                    motoreg.SetManFreDer("R");
                if (this.radioButton78.Checked == true)
                    motoreg.SetManFreDer("M");
                if (this.radioButton79.Checked == true)
                    motoreg.SetManFreDer("N/A");
                if (this.radioButton80.Checked == true)
                    motoreg.SetManFreDer("N/V");

                if (this.radioButton81.Checked == true)
                    motoreg.SetPrManFreDer("B");
                if (this.radioButton82.Checked == true)
                    motoreg.SetPrManFreDer("R");
                if (this.radioButton83.Checked == true)
                    motoreg.SetPrManFreDer("M");
                if (this.radioButton84.Checked == true)
                    motoreg.SetPrManFreDer("N/A");
                if (this.radioButton85.Checked == true)
                    motoreg.SetPrManFreDer("N/V");

                if (this.radioButton86.Checked == true)
                    motoreg.SetTanCom("B");
                if (this.radioButton87.Checked == true)
                    motoreg.SetTanCom("R");
                if (this.radioButton88.Checked == true)
                    motoreg.SetTanCom("M");
                if (this.radioButton89.Checked == true)
                    motoreg.SetTanCom("N/A");
                if (this.radioButton90.Checked == true)
                    motoreg.SetTanCom("N/V");

                if (this.radioButton91.Checked == true)
                    motoreg.SetTTanCom("B");
                if (this.radioButton92.Checked == true)
                    motoreg.SetTTanCom("R");
                if (this.radioButton93.Checked == true)
                    motoreg.SetTTanCom("M");
                if (this.radioButton94.Checked == true)
                    motoreg.SetTTanCom("N/A");
                if (this.radioButton95.Checked == true)
                    motoreg.SetTTanCom("N/V");

                //De aquí hacia arriba es la primera mitad, falta modificarla acorde al documento

                if (this.radioButton186.Checked == true)
                    motoreg.SetBarbero("B");
                if (this.radioButton187.Checked == true)
                    motoreg.SetBarbero("R");
                if (this.radioButton188.Checked == true)
                    motoreg.SetBarbero("M");
                if (this.radioButton189.Checked == true)
                    motoreg.SetBarbero("N/A");
                if (this.radioButton190.Checked == true)
                    motoreg.SetBarbero("N/V");

                if (this.radioButton181.Checked == true)
                    motoreg.SetPata("B");
                if (this.radioButton182.Checked == true)
                    motoreg.SetPata("R");
                if (this.radioButton183.Checked == true)
                    motoreg.SetPata("M");
                if (this.radioButton184.Checked == true)
                    motoreg.SetPata("N/A");
                if (this.radioButton185.Checked == true)
                    motoreg.SetPata("N/V");

                if (this.radioButton176.Checked == true)
                    motoreg.SetGato("B");
                if (this.radioButton177.Checked == true)
                    motoreg.SetGato("R");
                if (this.radioButton178.Checked == true)
                    motoreg.SetGato("M");
                if (this.radioButton179.Checked == true)
                    motoreg.SetGato("N/A");
                if (this.radioButton180.Checked == true)
                    motoreg.SetGato("N/V");

                if (this.radioButton171.Checked == true)
                    motoreg.SetTapLatIzq("B");
                if (this.radioButton172.Checked == true)
                    motoreg.SetTapLatIzq("R");
                if (this.radioButton173.Checked == true)
                    motoreg.SetTapLatIzq("M");
                if (this.radioButton174.Checked == true)
                    motoreg.SetTapLatIzq("N/A");
                if (this.radioButton175.Checked == true)
                    motoreg.SetTapLatIzq("N/V");

                if (this.radioButton166.Checked == true)
                    motoreg.SetGCad("B");
                if (this.radioButton167.Checked == true)
                    motoreg.SetGCad("R");
                if (this.radioButton168.Checked == true)
                    motoreg.SetGCad("M");
                if (this.radioButton169.Checked == true)
                    motoreg.SetGCad("N/A");
                if (this.radioButton170.Checked == true)
                    motoreg.SetGCad("N/V");

                if (this.radioButton161.Checked == true)
                    motoreg.SetSillin("B");
                if (this.radioButton162.Checked == true)
                    motoreg.SetSillin("R");
                if (this.radioButton163.Checked == true)
                    motoreg.SetSillin("M");
                if (this.radioButton164.Checked == true)
                    motoreg.SetSillin("N/A");
                if (this.radioButton165.Checked == true)
                    motoreg.SetSillin("N/V");

                if (this.radioButton156.Checked == true)
                    motoreg.SetParrilla("B");
                if (this.radioButton157.Checked == true)
                    motoreg.SetParrilla("R");
                if (this.radioButton158.Checked == true)
                    motoreg.SetParrilla("M");
                if (this.radioButton159.Checked == true)
                    motoreg.SetParrilla("N/A");
                if (this.radioButton160.Checked == true)
                    motoreg.SetParrilla("N/V");

                if (this.radioButton151.Checked == true)
                    motoreg.SetGBarTra("B");
                if (this.radioButton152.Checked == true)
                    motoreg.SetGBarTra("R");
                if (this.radioButton153.Checked == true)
                    motoreg.SetGBarTra("M");
                if (this.radioButton154.Checked == true)
                    motoreg.SetGBarTra("N/A");
                if (this.radioButton155.Checked == true)
                    motoreg.SetGBarTra("N/V");

                if (this.radioButton146.Checked == true)
                    motoreg.SetDirTraIzq("B");
                if (this.radioButton147.Checked == true)
                    motoreg.SetDirTraIzq("R");
                if (this.radioButton148.Checked == true)
                    motoreg.SetDirTraIzq("M");
                if (this.radioButton149.Checked == true)
                    motoreg.SetDirTraIzq("N/A");
                if (this.radioButton150.Checked == true)
                    motoreg.SetDirTraIzq("N/V");

                if (this.radioButton141.Checked == true)
                    motoreg.SetAmortiguadores("B");
                if (this.radioButton142.Checked == true)
                    motoreg.SetAmortiguadores("R");
                if (this.radioButton143.Checked == true)
                    motoreg.SetAmortiguadores("M");
                if (this.radioButton144.Checked == true)
                    motoreg.SetAmortiguadores("N/A");
                if (this.radioButton145.Checked == true)
                    motoreg.SetAmortiguadores("N/V");

                if (this.radioButton136.Checked == true)
                    motoreg.SetExosto("B");
                if (this.radioButton137.Checked == true)
                    motoreg.SetExosto("R");
                if (this.radioButton138.Checked == true)
                    motoreg.SetExosto("M");
                if (this.radioButton139.Checked == true)
                    motoreg.SetExosto("N/A");
                if (this.radioButton140.Checked == true)
                    motoreg.SetExosto("N/V");

                if (this.radioButton131.Checked == true)
                    motoreg.SetPlaca("B");
                if (this.radioButton132.Checked == true)
                    motoreg.SetPlaca("R");
                if (this.radioButton133.Checked == true)
                    motoreg.SetPlaca("M");
                if (this.radioButton134.Checked == true)
                    motoreg.SetPlaca("N/A");
                if (this.radioButton135.Checked == true)
                    motoreg.SetPlaca("N/V");

                if (this.radioButton126.Checked == true)
                    motoreg.SetDirTraDer("B");
                if (this.radioButton127.Checked == true)
                    motoreg.SetDirTraDer("R");
                if (this.radioButton128.Checked == true)
                    motoreg.SetDirTraDer("M");
                if (this.radioButton129.Checked == true)
                    motoreg.SetDirTraDer("N/A");
                if (this.radioButton130.Checked == true)
                    motoreg.SetDirTraDer("N/V");

                if (this.radioButton121.Checked == true)
                    motoreg.SetTapLatDer("B");
                if (this.radioButton122.Checked == true)
                    motoreg.SetTapLatDer("R");
                if (this.radioButton123.Checked == true)
                    motoreg.SetTapLatDer("M");
                if (this.radioButton124.Checked == true)
                    motoreg.SetTapLatDer("N/A");
                if (this.radioButton125.Checked == true)
                    motoreg.SetTapLatDer("N/V");

                if (this.radioButton116.Checked == true)
                    motoreg.SetBateriaa("B");
                if (this.radioButton117.Checked == true)
                    motoreg.SetBateriaa("R");
                if (this.radioButton118.Checked == true)
                    motoreg.SetBateriaa("M");
                if (this.radioButton119.Checked == true)
                    motoreg.SetBateriaa("N/A");
                if (this.radioButton120.Checked == true)
                    motoreg.SetBateriaa("N/V");

                if (this.radioButton111.Checked == true)
                    motoreg.SetTacos("B");
                if (this.radioButton112.Checked == true)
                    motoreg.SetTacos("R");
                if (this.radioButton113.Checked == true)
                    motoreg.SetTacos("M");
                if (this.radioButton114.Checked == true)
                    motoreg.SetTacos("N/A");
                if (this.radioButton115.Checked == true)
                    motoreg.SetTacos("N/V");

                if (this.radioButton106.Checked == true)
                    motoreg.SetPalFrePie("B");
                if (this.radioButton107.Checked == true)
                    motoreg.SetPalFrePie("R");
                if (this.radioButton108.Checked == true)
                    motoreg.SetPalFrePie("M");
                if (this.radioButton109.Checked == true)
                    motoreg.SetPalFrePie("N/A");
                if (this.radioButton110.Checked == true)
                    motoreg.SetPalFrePie("N/V");

                if (this.radioButton101.Checked == true)
                    motoreg.SetCran("B");
                if (this.radioButton102.Checked == true)
                    motoreg.SetCran("R");
                if (this.radioButton103.Checked == true)
                    motoreg.SetCran("M");
                if (this.radioButton104.Checked == true)
                    motoreg.SetCran("N/A");
                if (this.radioButton105.Checked == true)
                    motoreg.SetCran("N/V");

                if (this.radioButton96.Checked == true)
                    motoreg.SetOtros("B");
                if (this.radioButton97.Checked == true)
                    motoreg.SetOtros("R");
                if (this.radioButton98.Checked == true)
                    motoreg.SetOtros("M");
                if (this.radioButton99.Checked == true)
                    motoreg.SetOtros("N/A");
                if (this.radioButton100.Checked == true)
                    motoreg.SetOtros("N/V");



                if (this.radioButton191.Checked == true)
                    motoreg.Setdebegrua(1);
                if (this.radioButton192.Checked == true)
                    motoreg.Setdebegrua(0);

                if (this.radioButton194.Checked == true)
                    motoreg.Setdejallaves(1);
                if (this.radioButton193.Checked == true)
                    motoreg.Setdejallaves(0);

                //Asignadas todas las variables asignables
                

                motoreg.SetPlacaNum(textBoxplaca.Text);
                motoreg.SetMarca(textBoxmarca.Text);
                Propietario p1 = new Propietario();
                if (textBox1.Text.Length != 0)
                    p1.nombre = textBox1.Text;
                else
                    p1.nombre = null;
                if (textBox2.Text.Length != 0)
                    p1.cedula = Int32.Parse(textBox2.Text);
                else
                    p1.cedula = null;
                if(textBox3.Text.Length!=0)
                    p1.direccion =(textBox3.Text);
                else
                    p1.direccion = null;
                if (textBox4.Text.Length != 0)
                    p1.telefono = Int32.Parse(textBox4.Text);
                else p1.telefono = null;
                motoreg.setInventario(Int32.Parse(textBox6.Text));
                motoreg.setAutoridad(comboBox2.Text);
                motoreg.setFechaEntrada(dateTimePicker1.Value);
                motoreg.setHoraEntrada(dateTimePicker1.Value);
                motoreg.setMotivo(comboBox1.Text);





                //De aquí hacia abajo todo funciona
                motoreg.runQuery(tipo1,Form1.obtenervalor,p1,textBox5.Text);
                MessageBox.Show("Registro exitoso");
                
                Form4 f = new Form4();
                this.Dispose();
                f.Show();
            }
            


            

        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("El campo 'Propietario' solo acepta caracteres, intente nuevamente");
                return;
            }
            else if(textBox1.Text != "")
            {
                groupBox1.Visible = true;
                
            }
            else if (textBox1.Text == "")
            {
                groupBox1.Visible = false;
            }

        }

        private void FormMotos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form4 f = new Form4();
            this.Dispose();
            f.Show();
        }
    }
}

