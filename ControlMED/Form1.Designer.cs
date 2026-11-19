namespace ControlMED
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            títuloEncabezado = new Label();
            Fondo = new Panel();
            gbGestionInventario = new GroupBox();
            cbMedicamento = new ComboBox();
            buttonEliminar = new Button();
            buttonLeer = new Button();
            label1 = new Label();
            buttonCrear = new Button();
            textBox1 = new TextBox();
            idMedicamento = new Label();
            buttonActualizarExist = new Button();
            modExistencia = new NumericUpDown();
            labeNvaExistencia = new Label();
            dgvInventario = new DataGridView();
            buttonBuscar = new Button();
            Med = new TextBox();
            LabelMed = new Label();
            cbSucursal = new ComboBox();
            selecSucursal = new Label();
            ColumnMed = new DataGridViewTextBoxColumn();
            idInventario = new DataGridViewTextBoxColumn();
            ColumnExistencia = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            Fondo.SuspendLayout();
            gbGestionInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modExistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(títuloEncabezado);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1217, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // títuloEncabezado
            // 
            títuloEncabezado.AutoSize = true;
            títuloEncabezado.BackColor = Color.Transparent;
            títuloEncabezado.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            títuloEncabezado.ForeColor = Color.LightYellow;
            títuloEncabezado.Location = new Point(20, 17);
            títuloEncabezado.Name = "títuloEncabezado";
            títuloEncabezado.Size = new Size(392, 46);
            títuloEncabezado.TabIndex = 0;
            títuloEncabezado.Text = "KITTY PATITAS SUAVES";
            títuloEncabezado.Click += label1_Click;
            // 
            // Fondo
            // 
            Fondo.BorderStyle = BorderStyle.FixedSingle;
            Fondo.Controls.Add(gbGestionInventario);
            Fondo.Controls.Add(dgvInventario);
            Fondo.Controls.Add(buttonBuscar);
            Fondo.Controls.Add(Med);
            Fondo.Controls.Add(LabelMed);
            Fondo.Controls.Add(cbSucursal);
            Fondo.Controls.Add(selecSucursal);
            Fondo.Dock = DockStyle.Fill;
            Fondo.Location = new Point(0, 80);
            Fondo.Name = "Fondo";
            Fondo.Size = new Size(1217, 671);
            Fondo.TabIndex = 1;
            Fondo.Paint += panel2_Paint;
            // 
            // gbGestionInventario
            // 
            gbGestionInventario.Controls.Add(cbMedicamento);
            gbGestionInventario.Controls.Add(buttonEliminar);
            gbGestionInventario.Controls.Add(buttonLeer);
            gbGestionInventario.Controls.Add(label1);
            gbGestionInventario.Controls.Add(buttonCrear);
            gbGestionInventario.Controls.Add(textBox1);
            gbGestionInventario.Controls.Add(idMedicamento);
            gbGestionInventario.Controls.Add(buttonActualizarExist);
            gbGestionInventario.Controls.Add(modExistencia);
            gbGestionInventario.Controls.Add(labeNvaExistencia);
            gbGestionInventario.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbGestionInventario.ForeColor = Color.DarkSlateGray;
            gbGestionInventario.Location = new Point(30, 401);
            gbGestionInventario.Name = "gbGestionInventario";
            gbGestionInventario.Size = new Size(950, 219);
            gbGestionInventario.TabIndex = 6;
            gbGestionInventario.TabStop = false;
            gbGestionInventario.Text = "Gestión de inventario";
            // 
            // cbMedicamento
            // 
            cbMedicamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedicamento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMedicamento.FormattingEnabled = true;
            cbMedicamento.Location = new Point(182, 96);
            cbMedicamento.Name = "cbMedicamento";
            cbMedicamento.Size = new Size(160, 31);
            cbMedicamento.TabIndex = 16;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.SteelBlue;
            buttonEliminar.Cursor = Cursors.Hand;
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(500, 156);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(150, 35);
            buttonEliminar.TabIndex = 15;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonLeer
            // 
            buttonLeer.BackColor = Color.SteelBlue;
            buttonLeer.Cursor = Cursors.Hand;
            buttonLeer.FlatAppearance.BorderSize = 0;
            buttonLeer.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonLeer.FlatStyle = FlatStyle.Flat;
            buttonLeer.ForeColor = Color.White;
            buttonLeer.Location = new Point(260, 156);
            buttonLeer.Name = "buttonLeer";
            buttonLeer.Size = new Size(150, 35);
            buttonLeer.TabIndex = 14;
            buttonLeer.Text = "Leer";
            buttonLeer.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 99);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 13;
            label1.Text = "Medicamento:";
            label1.Click += label1_Click_3;
            // 
            // buttonCrear
            // 
            buttonCrear.BackColor = Color.SteelBlue;
            buttonCrear.Cursor = Cursors.Hand;
            buttonCrear.FlatAppearance.BorderSize = 0;
            buttonCrear.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonCrear.FlatStyle = FlatStyle.Flat;
            buttonCrear.ForeColor = Color.White;
            buttonCrear.Location = new Point(20, 156);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(150, 35);
            buttonCrear.TabIndex = 12;
            buttonCrear.Text = "Crear";
            buttonCrear.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(561, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(64, 30);
            textBox1.TabIndex = 11;
            // 
            // idMedicamento
            // 
            idMedicamento.AutoSize = true;
            idMedicamento.Location = new Point(448, 45);
            idMedicamento.Name = "idMedicamento";
            idMedicamento.Size = new Size(107, 23);
            idMedicamento.TabIndex = 10;
            idMedicamento.Text = "Id inventario";
            idMedicamento.Click += label1_Click_2;
            // 
            // buttonActualizarExist
            // 
            buttonActualizarExist.BackColor = Color.SteelBlue;
            buttonActualizarExist.Cursor = Cursors.Hand;
            buttonActualizarExist.FlatAppearance.BorderSize = 0;
            buttonActualizarExist.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonActualizarExist.FlatStyle = FlatStyle.Flat;
            buttonActualizarExist.ForeColor = Color.White;
            buttonActualizarExist.ImageAlign = ContentAlignment.MiddleRight;
            buttonActualizarExist.Location = new Point(275, 36);
            buttonActualizarExist.Name = "buttonActualizarExist";
            buttonActualizarExist.Size = new Size(129, 35);
            buttonActualizarExist.TabIndex = 9;
            buttonActualizarExist.Text = "Actualizar";
            buttonActualizarExist.UseVisualStyleBackColor = false;
            // 
            // modExistencia
            // 
            modExistencia.Location = new Point(182, 40);
            modExistencia.Name = "modExistencia";
            modExistencia.Size = new Size(64, 30);
            modExistencia.TabIndex = 8;
            modExistencia.TextAlign = HorizontalAlignment.Center;
            // 
            // labeNvaExistencia
            // 
            labeNvaExistencia.AutoSize = true;
            labeNvaExistencia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeNvaExistencia.ForeColor = Color.DarkSlateGray;
            labeNvaExistencia.Location = new Point(20, 45);
            labeNvaExistencia.Name = "labeNvaExistencia";
            labeNvaExistencia.Size = new Size(140, 23);
            labeNvaExistencia.TabIndex = 7;
            labeNvaExistencia.Text = "Nueva existencia";
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { ColumnMed, idInventario, ColumnExistencia });
            dgvInventario.Location = new Point(30, 150);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(950, 245);
            dgvInventario.TabIndex = 5;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.SteelBlue;
            buttonBuscar.Cursor = Cursors.Hand;
            buttonBuscar.FlatAppearance.BorderSize = 0;
            buttonBuscar.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.ForeColor = Color.White;
            buttonBuscar.Location = new Point(616, 88);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(110, 34);
            buttonBuscar.TabIndex = 4;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // Med
            // 
            Med.Location = new Point(279, 90);
            Med.Name = "Med";
            Med.Size = new Size(300, 30);
            Med.TabIndex = 3;
            // 
            // LabelMed
            // 
            LabelMed.AutoSize = true;
            LabelMed.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelMed.ForeColor = Color.DarkSlateGray;
            LabelMed.Location = new Point(30, 90);
            LabelMed.Name = "LabelMed";
            LabelMed.Size = new Size(230, 25);
            LabelMed.TabIndex = 2;
            LabelMed.Text = "Nombre de medicamento:";
            LabelMed.Click += label1_Click_1;
            // 
            // cbSucursal
            // 
            cbSucursal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSucursal.FormattingEnabled = true;
            cbSucursal.Location = new Point(127, 27);
            cbSucursal.Name = "cbSucursal";
            cbSucursal.Size = new Size(220, 33);
            cbSucursal.TabIndex = 1;
            cbSucursal.SelectedIndexChanged += cbSucursal_SelectedIndexChanged;
            // 
            // selecSucursal
            // 
            selecSucursal.AutoSize = true;
            selecSucursal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selecSucursal.ForeColor = Color.DarkSlateGray;
            selecSucursal.Location = new Point(30, 30);
            selecSucursal.Name = "selecSucursal";
            selecSucursal.Size = new Size(85, 25);
            selecSucursal.TabIndex = 0;
            selecSucursal.Text = "Sucursal:";
            // 
            // ColumnMed
            // 
            ColumnMed.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnMed.FillWeight = 75F;
            ColumnMed.HeaderText = "Medicamento";
            ColumnMed.MinimumWidth = 6;
            ColumnMed.Name = "ColumnMed";
            ColumnMed.ReadOnly = true;
            // 
            // idInventario
            // 
            idInventario.HeaderText = "Id Inventario";
            idInventario.MinimumWidth = 6;
            idInventario.Name = "idInventario";
            idInventario.ReadOnly = true;
            idInventario.Visible = false;
            // 
            // ColumnExistencia
            // 
            ColumnExistencia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnExistencia.FillWeight = 30F;
            ColumnExistencia.HeaderText = "Existencia";
            ColumnExistencia.MinimumWidth = 6;
            ColumnExistencia.Name = "ColumnExistencia";
            ColumnExistencia.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1217, 751);
            Controls.Add(Fondo);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kitty Patitas Suaves - INVENTARIO";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Fondo.ResumeLayout(false);
            Fondo.PerformLayout();
            gbGestionInventario.ResumeLayout(false);
            gbGestionInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)modExistencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label títuloEncabezado;
        private Panel Fondo;
        private Panel panel3;
        private Label selecSucursal;
        private ComboBox cbSucursal;
        private Label LabelMed;
        private TextBox Med;
        private Button buttonBuscar;
        private DataGridView dgvInventario;
        private GroupBox gbGestionInventario;
        private Label labeNvaExistencia;
        private NumericUpDown modExistencia;
        private Button buttonActualizarExist;
        private Label idMedicamento;
        private TextBox textBox1;
        private Button buttonCrear;
        private Label label1;
        private Button buttonLeer;
        private Button buttonEliminar;
        private ComboBox cbMedicamento;
        private DataGridViewTextBoxColumn ColumnMed;
        private DataGridViewTextBoxColumn idInventario;
        private DataGridViewTextBoxColumn ColumnExistencia;
    }
}
