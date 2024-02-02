
namespace Restaurante_RZJG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBNombreR = new System.Windows.Forms.Label();
            this.lBNombreC = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.gBDatos = new System.Windows.Forms.GroupBox();
            this.horaSeleccionada = new System.Windows.Forms.Label();
            this.lBHora = new System.Windows.Forms.Label();
            this.tBNumPersonas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBNpersonas = new System.Windows.Forms.RadioButton();
            this.rB4personas = new System.Windows.Forms.RadioButton();
            this.rB3personas = new System.Windows.Forms.RadioButton();
            this.rB2personas = new System.Windows.Forms.RadioButton();
            this.rB1personas = new System.Windows.Forms.RadioButton();
            this.lBPersonas = new System.Windows.Forms.Label();
            this.lBDia = new System.Windows.Forms.Label();
            this.cBDias = new System.Windows.Forms.ComboBox();
            this.lBHorarios = new System.Windows.Forms.Label();
            this.listBHorarios = new System.Windows.Forms.ListBox();
            this.gBDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBNombreR
            // 
            this.lBNombreR.AutoSize = true;
            this.lBNombreR.BackColor = System.Drawing.Color.Transparent;
            this.lBNombreR.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBNombreR.ForeColor = System.Drawing.Color.Indigo;
            this.lBNombreR.Location = new System.Drawing.Point(229, 9);
            this.lBNombreR.Name = "lBNombreR";
            this.lBNombreR.Size = new System.Drawing.Size(451, 38);
            this.lBNombreR.TabIndex = 0;
            this.lBNombreR.Text = "RESTAURANTE \"LUZ DE LUNA\"";
            // 
            // lBNombreC
            // 
            this.lBNombreC.AutoSize = true;
            this.lBNombreC.BackColor = System.Drawing.Color.Transparent;
            this.lBNombreC.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBNombreC.ForeColor = System.Drawing.Color.SpringGreen;
            this.lBNombreC.Location = new System.Drawing.Point(12, 97);
            this.lBNombreC.Name = "lBNombreC";
            this.lBNombreC.Size = new System.Drawing.Size(218, 19);
            this.lBNombreC.TabIndex = 1;
            this.lBNombreC.Text = "Nombre del cliente:";
            // 
            // nombreCliente
            // 
            this.nombreCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCliente.ForeColor = System.Drawing.Color.Silver;
            this.nombreCliente.Location = new System.Drawing.Point(236, 91);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(355, 29);
            this.nombreCliente.TabIndex = 2;
            this.nombreCliente.Text = "Nombre,Apellidos";
            this.nombreCliente.TextChanged += new System.EventHandler(this.nombreCliente_TextChanged);
            this.nombreCliente.DoubleClick += new System.EventHandler(this.nombreCliente_DoubleClick);
            this.nombreCliente.Leave += new System.EventHandler(this.nombreCliente_Leave);
            // 
            // gBDatos
            // 
            this.gBDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gBDatos.Controls.Add(this.horaSeleccionada);
            this.gBDatos.Controls.Add(this.lBHora);
            this.gBDatos.Controls.Add(this.tBNumPersonas);
            this.gBDatos.Controls.Add(this.label1);
            this.gBDatos.Controls.Add(this.rBNpersonas);
            this.gBDatos.Controls.Add(this.rB4personas);
            this.gBDatos.Controls.Add(this.rB3personas);
            this.gBDatos.Controls.Add(this.rB2personas);
            this.gBDatos.Controls.Add(this.rB1personas);
            this.gBDatos.Controls.Add(this.lBPersonas);
            this.gBDatos.Controls.Add(this.lBDia);
            this.gBDatos.Controls.Add(this.cBDias);
            this.gBDatos.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gBDatos.Location = new System.Drawing.Point(16, 145);
            this.gBDatos.Name = "gBDatos";
            this.gBDatos.Size = new System.Drawing.Size(587, 238);
            this.gBDatos.TabIndex = 3;
            this.gBDatos.TabStop = false;
            this.gBDatos.Text = "Datos de Reservación:";
            // 
            // horaSeleccionada
            // 
            this.horaSeleccionada.AutoSize = true;
            this.horaSeleccionada.BackColor = System.Drawing.Color.White;
            this.horaSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.horaSeleccionada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaSeleccionada.ForeColor = System.Drawing.Color.Silver;
            this.horaSeleccionada.Location = new System.Drawing.Point(311, 50);
            this.horaSeleccionada.Name = "horaSeleccionada";
            this.horaSeleccionada.Size = new System.Drawing.Size(257, 18);
            this.horaSeleccionada.TabIndex = 15;
            this.horaSeleccionada.Text = "Selecciona uno de los horarios disponibles";
            // 
            // lBHora
            // 
            this.lBHora.AutoSize = true;
            this.lBHora.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBHora.ForeColor = System.Drawing.Color.Black;
            this.lBHora.Location = new System.Drawing.Point(247, 52);
            this.lBHora.Name = "lBHora";
            this.lBHora.Size = new System.Drawing.Size(58, 16);
            this.lBHora.TabIndex = 14;
            this.lBHora.Text = "Hora:";
            // 
            // tBNumPersonas
            // 
            this.tBNumPersonas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNumPersonas.ForeColor = System.Drawing.Color.Silver;
            this.tBNumPersonas.Location = new System.Drawing.Point(132, 182);
            this.tBNumPersonas.Name = "tBNumPersonas";
            this.tBNumPersonas.Size = new System.Drawing.Size(162, 26);
            this.tBNumPersonas.TabIndex = 13;
            this.tBNumPersonas.Text = "Num Personas";
            this.tBNumPersonas.Visible = false;
            this.tBNumPersonas.Enter += new System.EventHandler(this.tBNumPersonas_Enter);
            this.tBNumPersonas.Leave += new System.EventHandler(this.tBNumPersonas_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Específica:";
            // 
            // rBNpersonas
            // 
            this.rBNpersonas.AutoSize = true;
            this.rBNpersonas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBNpersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rBNpersonas.Location = new System.Drawing.Point(132, 126);
            this.rBNpersonas.Name = "rBNpersonas";
            this.rBNpersonas.Size = new System.Drawing.Size(162, 22);
            this.rBNpersonas.TabIndex = 11;
            this.rBNpersonas.TabStop = true;
            this.rBNpersonas.Text = "Más de 4 Personas";
            this.rBNpersonas.UseVisualStyleBackColor = true;
            this.rBNpersonas.CheckedChanged += new System.EventHandler(this.rBNpersonas_CheckedChanged);
            // 
            // rB4personas
            // 
            this.rB4personas.AutoSize = true;
            this.rB4personas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB4personas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rB4personas.Location = new System.Drawing.Point(6, 210);
            this.rB4personas.Name = "rB4personas";
            this.rB4personas.Size = new System.Drawing.Size(106, 22);
            this.rB4personas.TabIndex = 10;
            this.rB4personas.TabStop = true;
            this.rB4personas.Text = "4 Personas";
            this.rB4personas.UseVisualStyleBackColor = true;
            this.rB4personas.CheckedChanged += new System.EventHandler(this.rB4personas_CheckedChanged);
            // 
            // rB3personas
            // 
            this.rB3personas.AutoSize = true;
            this.rB3personas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB3personas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rB3personas.Location = new System.Drawing.Point(6, 182);
            this.rB3personas.Name = "rB3personas";
            this.rB3personas.Size = new System.Drawing.Size(106, 22);
            this.rB3personas.TabIndex = 9;
            this.rB3personas.TabStop = true;
            this.rB3personas.Text = "3 Personas";
            this.rB3personas.UseVisualStyleBackColor = true;
            this.rB3personas.CheckedChanged += new System.EventHandler(this.rB3personas_CheckedChanged);
            // 
            // rB2personas
            // 
            this.rB2personas.AutoSize = true;
            this.rB2personas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB2personas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rB2personas.Location = new System.Drawing.Point(6, 154);
            this.rB2personas.Name = "rB2personas";
            this.rB2personas.Size = new System.Drawing.Size(106, 22);
            this.rB2personas.TabIndex = 8;
            this.rB2personas.TabStop = true;
            this.rB2personas.Text = "2 Personas";
            this.rB2personas.UseVisualStyleBackColor = true;
            this.rB2personas.CheckedChanged += new System.EventHandler(this.rB2personas_CheckedChanged);
            // 
            // rB1personas
            // 
            this.rB1personas.AutoSize = true;
            this.rB1personas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB1personas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rB1personas.Location = new System.Drawing.Point(6, 126);
            this.rB1personas.Name = "rB1personas";
            this.rB1personas.Size = new System.Drawing.Size(98, 22);
            this.rB1personas.TabIndex = 7;
            this.rB1personas.Text = "1 Persona";
            this.rB1personas.UseVisualStyleBackColor = true;
            this.rB1personas.CheckedChanged += new System.EventHandler(this.rB1personas_CheckedChanged);
            // 
            // lBPersonas
            // 
            this.lBPersonas.AutoSize = true;
            this.lBPersonas.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBPersonas.ForeColor = System.Drawing.Color.Black;
            this.lBPersonas.Location = new System.Drawing.Point(6, 98);
            this.lBPersonas.Name = "lBPersonas";
            this.lBPersonas.Size = new System.Drawing.Size(178, 16);
            this.lBPersonas.TabIndex = 6;
            this.lBPersonas.Text = "Reservación para:";
            // 
            // lBDia
            // 
            this.lBDia.AutoSize = true;
            this.lBDia.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBDia.ForeColor = System.Drawing.Color.Black;
            this.lBDia.Location = new System.Drawing.Point(6, 50);
            this.lBDia.Name = "lBDia";
            this.lBDia.Size = new System.Drawing.Size(48, 16);
            this.lBDia.TabIndex = 5;
            this.lBDia.Text = "Día:";
            // 
            // cBDias
            // 
            this.cBDias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDias.FormattingEnabled = true;
            this.cBDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cBDias.Location = new System.Drawing.Point(60, 45);
            this.cBDias.Name = "cBDias";
            this.cBDias.Size = new System.Drawing.Size(161, 26);
            this.cBDias.TabIndex = 4;
            this.cBDias.SelectedIndexChanged += new System.EventHandler(this.cBDias_SelectedIndexChanged);
            // 
            // lBHorarios
            // 
            this.lBHorarios.AutoSize = true;
            this.lBHorarios.BackColor = System.Drawing.Color.Transparent;
            this.lBHorarios.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBHorarios.ForeColor = System.Drawing.Color.SpringGreen;
            this.lBHorarios.Location = new System.Drawing.Point(656, 101);
            this.lBHorarios.Name = "lBHorarios";
            this.lBHorarios.Size = new System.Drawing.Size(240, 19);
            this.lBHorarios.TabIndex = 4;
            this.lBHorarios.Text = "Horarios disponibles:";
            // 
            // listBHorarios
            // 
            this.listBHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBHorarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBHorarios.FormattingEnabled = true;
            this.listBHorarios.ItemHeight = 18;
            this.listBHorarios.Items.AddRange(new object[] {
            "Elija un día de la semana"});
            this.listBHorarios.Location = new System.Drawing.Point(660, 145);
            this.listBHorarios.Name = "listBHorarios";
            this.listBHorarios.Size = new System.Drawing.Size(236, 238);
            this.listBHorarios.TabIndex = 5;
            this.listBHorarios.DoubleClick += new System.EventHandler(this.listBHorarios_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante_RZJG.Properties.Resources.restaurant;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.listBHorarios);
            this.Controls.Add(this.lBHorarios);
            this.Controls.Add(this.gBDatos);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.lBNombreC);
            this.Controls.Add(this.lBNombreR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBDatos.ResumeLayout(false);
            this.gBDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBNombreR;
        private System.Windows.Forms.Label lBNombreC;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.GroupBox gBDatos;
        private System.Windows.Forms.RadioButton rB1personas;
        private System.Windows.Forms.Label lBPersonas;
        private System.Windows.Forms.Label lBDia;
        private System.Windows.Forms.ComboBox cBDias;
        private System.Windows.Forms.RadioButton rBNpersonas;
        private System.Windows.Forms.RadioButton rB4personas;
        private System.Windows.Forms.RadioButton rB3personas;
        private System.Windows.Forms.RadioButton rB2personas;
        private System.Windows.Forms.Label lBHora;
        private System.Windows.Forms.TextBox tBNumPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lBHorarios;
        private System.Windows.Forms.ListBox listBHorarios;
        private System.Windows.Forms.Label horaSeleccionada;
    }
}

