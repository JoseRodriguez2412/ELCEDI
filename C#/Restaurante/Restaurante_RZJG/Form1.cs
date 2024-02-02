using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_RZJG
{
    public partial class Form1 : Form
    {
        /// /Se declaran e inicializan variables y arreglos que se necesitarán
        string[] clientes = new string[10];
        string[] personas = new string[10];
        string[] diaSeleccionado;
        string[] horariosLunes = {"08:30 a.m", "10:00 a.m", "11:45 a.m", "02:50 p.m", "03:10 p.m",
                                  "05:00 p.m", "06:20 p.m", "07:25 p.m", "08:15 p.m", "10:30 p.m"};
        string[] horariosMartes = {"08:45 a.m", "09:30 a.m", "12:00 p.m", "02:40 p.m", "03:50 p.m",
                                  "04:00 p.m", "06:00 p.m", "07:45 p.m", "08:10 p.m", "09:30 p.m"};
        string[] horariosMiercoles = {"08:00 a.m", "10:00 a.m", "11:30 a.m", "02:10 p.m", "03:20 p.m",
                                  "04:20 p.m", "05:40 p.m", "07:15 p.m", "08:40 p.m", "09:00 p.m"};
        string[] horariosJueves = {"09:00 a.m", "09:45 a.m", "12:15 p.m", "02:55 p.m", "04:05 p.m",
                                  "04:15 p.m", "05:45 p.m", "07:30 p.m", "08:25 p.m", "09:45 p.m"};
        string[] horariosViernes = {"09:35 a.m", "10:20 a.m", "12:50 p.m", "03:30 p.m", "04:40 p.m",
                                  "04:50 p.m", "05:10 p.m", "08:35 p.m", "09:00 p.m", "10:20 p.m"};
        string[] horariosSabado = {"08:45 a.m", "09:30 a.m", "12:00 p.m", "02:40 p.m", "03:50 p.m",
                                  "04:00 p.m", "06:00 p.m", "07:45 p.m", "08:10 p.m", "09:30 p.m"};
        string[] horariosDomingo = {"08:00 a.m", "08:35 a.m", "11:05 a.m", "01:45 p.m", "02:50 p.m"};
        int n = 0;
        int reserv = 0;
        string seleccion = "";
        bool completa = false;

        public Form1()
        {
            InitializeComponent();
        }

        //Se crea un función para verificar que todos los campos del formulario han sido llenados
        public void verificar_Reservacion()
        {
            if (nombreCliente.Text == "" || nombreCliente.Text == "Nombre,Apellidos")
            {
                completa = false;
            }
            else
            {
                if (cBDias.Text == "")
                {
                    completa = false;
                }
                else
                {
                    if (horaSeleccionada.Text == "Selecciona uno de los horarios disponible")
                    {
                        completa = false;
                    }
                    else
                    {
                        if (rB1personas.Checked == false)
                        {
                            if (rB2personas.Checked == false)
                            {
                                if (rB3personas.Checked == false)
                                {
                                    if (rB4personas.Checked == false)
                                    {
                                        if (rBNpersonas.Checked == false)
                                        {
                                            completa = false;
                                        }
                                        else
                                        {
                                            if (tBNumPersonas.Text != "" && tBNumPersonas.Text != "Num Personas")
                                            {
                                                completa = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        completa = true;
                                    }
                                }
                                else
                                {
                                    completa = true;
                                }
                            }
                            else
                            {
                                completa = true;
                            }
                        }
                        else
                        {
                            completa = true;
                        }
                    }
                }
            }

            //Si falta algún campo por llenar se mandará un mensaje de advertencia
            if (completa == false)
            {
                MessageBox.Show("¡Por favor llene todos los campos!", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rB1personas.Checked = false;
                rB2personas.Checked = false;
                rB3personas.Checked = false;
                rB4personas.Checked = false;
                rBNpersonas.Checked = false;
            }
            else
            {
                //Si todos los campos del formulario son llenados, se manda un mensaje confirmando la reservación
                //Además todos los campos (controles) vuelven a su estado inicial
                MessageBox.Show("N° de reservación: 00" + (reserv + 1).ToString() + "\nCliente: " + clientes[n-1] + "\nReservación para: "
                         + personas[n-1], "¡Su reservación fue registrada exitosamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reserv += 1;

                nombreCliente.Text = "Nombre,Apellidos";
                nombreCliente.ForeColor = Color.Silver;
                cBDias.Text = "";
                listBHorarios.Items.Clear();
                listBHorarios.BeginUpdate();
                listBHorarios.Items.Add("Elija un día de la semana");
                listBHorarios.EndUpdate();
                horaSeleccionada.Text = "Selecciona uno de los horarios disponibles";
                horaSeleccionada.Font = new Font("Arial", 10, FontStyle.Regular);
                horaSeleccionada.ForeColor = Color.Silver;
                rB1personas.Checked = false;
                rB2personas.Checked = false;
                rB3personas.Checked = false;
                rB4personas.Checked = false;
                rBNpersonas.Checked = false;
                tBNumPersonas.Text = "Num Personas";
                tBNumPersonas.ForeColor = Color.Silver;
                tBNumPersonas.Visible = false;
            }
        }

        //Se "limpia" el TextBox para poder ingresar el dato necesario para la reservación
        //una vez que se entra al control (el control obtiene el foco)
        private void tBNumPersonas_Enter(object sender, EventArgs e)
        {
            tBNumPersonas.Text = "";
            tBNumPersonas.ForeColor = Color.Black;
        }

        //Se "limpia" el TextBox para poder ingresar el dato necesario para la reservación
        //una vez que se presiona doble clic en el control
        private void nombreCliente_DoubleClick(object sender, EventArgs e)
        {
            nombreCliente.Text = "";
            nombreCliente.ForeColor = Color.Black;
        }

        //Se valida que se ingrese un nombre o caracteres alfabéticos al TextBox
        //una vez que se sale del control (otro control obtiene el foco)
        private void nombreCliente_Leave(object sender, EventArgs e)
        {
            if (nombreCliente.Text == "Nombre,Apellidos" || nombreCliente.Text == "")
            {
                nombreCliente.BackColor = Color.Red;
            }
            else
            {
                try
                {
                    int.Parse(nombreCliente.Text);
                    nombreCliente.BackColor = Color.Red;
                }
                catch
                {
                    //Se guarda el nombre en el arreglo de clientes
                    nombreCliente.BackColor = Color.White;
                    clientes[n] = nombreCliente.Text;
                    n += 1;
                }
            }
        }

        //Se valida que se ingrese un nombre o caracteres alfabéticos al TextBox
        //una vez que la propiedad Text del control cambia de valor
        private void nombreCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(nombreCliente.Text) >= 0)
                {
                    nombreCliente.BackColor = Color.Red;
                }
            }
            catch
            {
                nombreCliente.BackColor = Color.White;
            }
        }

        //Se muestra la lista de horarios (en el ListBox) disponibles para un día seleccionado (del ComboBox)
        private void cBDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBDias.SelectedIndex)
            {
                case 0:
                    //Se eliminan los elementos actuales del ListBox y se muestran los horarios correspondientes
                    //al día seleccionado en el ComboBox, los cuales estan almacenados en arreglos
                    listBHorarios.Items.Clear();
                    listBHorarios.BeginUpdate();
                    for (int i = 0; i < horariosLunes.Length; i++)
                    {
                        listBHorarios.Items.Add(horariosLunes[i]);
                    }
                    listBHorarios.EndUpdate();
                    diaSeleccionado = horariosLunes;
                    break;
                case 1:
                    listBHorarios.Items.Clear();
                    listBHorarios.BeginUpdate();
                    for (int i = 0; i < horariosMartes.Length; i++)
                    {
                        listBHorarios.Items.Add(horariosMartes[i]);
                    }
                    listBHorarios.EndUpdate();
                    diaSeleccionado = horariosMartes;
                    break;
                case 2:
                    listBHorarios.Items.Clear();
                    listBHorarios.BeginUpdate();
                    for (int i = 0; i < horariosMiercoles.Length; i++)
                    {
                        listBHorarios.Items.Add(horariosMiercoles[i]);
                    }
                    listBHorarios.EndUpdate();
                    diaSeleccionado = horariosMiercoles;
                    break;
                case 3:
                    listBHorarios.Items.Clear();
                    listBHorarios.BeginUpdate();
                    for (int i = 0; i < horariosJueves.Length; i++)
                    {
                        listBHorarios.Items.Add(horariosJueves[i]);
                    }
                    listBHorarios.EndUpdate();
                    diaSeleccionado = horariosJueves;
                    break;
                case 4:
                    listBHorarios.Items.Clear();
                    listBHorarios.BeginUpdate();
                    for (int i = 0; i < horariosViernes.Length; i++)
                    {
                        listBHorarios.Items.Add(horariosViernes[i]);
                    }
                    listBHorarios.EndUpdate();
                    diaSeleccionado = horariosViernes;
                    break;
                case 5:
                    listBHorarios.Items.Clear();
                    listBHorarios.BeginUpdate();
                    for (int i = 0; i < horariosSabado.Length; i++)
                    {
                        listBHorarios.Items.Add(horariosSabado[i]);
                    }
                    listBHorarios.EndUpdate();
                    diaSeleccionado = horariosSabado;
                    break;
                case 6:
                    listBHorarios.Items.Clear();
                    listBHorarios.BeginUpdate();
                    for (int i = 0; i < horariosDomingo.Length; i++)
                    {
                        listBHorarios.Items.Add(horariosDomingo[i]);
                    }
                    listBHorarios.EndUpdate();
                    diaSeleccionado = horariosDomingo;
                    break;
            }
        }

        //Se selecciona una hora de la lista de horarios disponibles que aparece en el ListBox
        //El valor o texto del item seleccionado se muestra en un Label
        private void listBHorarios_DoubleClick(object sender, EventArgs e)
        {
            seleccion = listBHorarios.Text;
            diaSeleccionado[listBHorarios.SelectedIndex] = "";
            horaSeleccionada.Text = seleccion;
            horaSeleccionada.ForeColor = Color.Black;
            horaSeleccionada.Font = new Font("Tahoma", 12, FontStyle.Italic);
            listBHorarios.Items.RemoveAt(listBHorarios.SelectedIndex);
        }

        //Se selecciona el número de personas para las que será la reservación y se guarda el dato en el arreglo personas
        // además se verifica que ya hayan sido llenados los demás campos del formulario
        private void rBNpersonas_CheckedChanged(object sender, EventArgs e)
        {
            tBNumPersonas.Visible = true;
        }

        private void tBNumPersonas_Leave(object sender, EventArgs e)
        {
            personas[n-1] = tBNumPersonas.Text;
            verificar_Reservacion();
        }

        private void rB4personas_CheckedChanged(object sender, EventArgs e)
        {
            if (rB4personas.Checked == true)
            {
                personas[n-1] = rB4personas.Text;
                verificar_Reservacion();
            }
        }

        private void rB3personas_CheckedChanged(object sender, EventArgs e)
        {
            if (rB3personas.Checked == true)
            {
                personas[n-1] = rB3personas.Text;
                verificar_Reservacion();
            }
        }

        private void rB2personas_CheckedChanged(object sender, EventArgs e)
        {
            if (rB2personas.Checked == true)
            {
                personas[n-1] = rB2personas.Text;
                verificar_Reservacion();
            }
        }

        private void rB1personas_CheckedChanged(object sender, EventArgs e)
        {
            if (rB1personas.Checked == true)
            {
                personas[n - 1] = rB1personas.Text;
                verificar_Reservacion();
            }
        }
    }
}
