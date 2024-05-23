namespace PPAI_CU_24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbFechaDesde = new DateTimePicker();
            cmbFechaHasta = new DateTimePicker();
            label4 = new Label();
            cmbTipoReseña = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            grbTipoVisualizacion = new GroupBox();
            rdPantalla = new RadioButton();
            rdExcel = new RadioButton();
            rdPDF = new RadioButton();
            btnLimpiarDatos = new Button();
            btnGenerarRanking = new Button();
            grbTipoVisualizacion.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(299, 35);
            label1.TabIndex = 0;
            label1.Text = "Generar ranking de vino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 106);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 140);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha hasta:";
            // 
            // cmbFechaDesde
            // 
            cmbFechaDesde.Location = new Point(155, 106);
            cmbFechaDesde.Name = "cmbFechaDesde";
            cmbFechaDesde.Size = new Size(272, 27);
            cmbFechaDesde.TabIndex = 3;
            // 
            // cmbFechaHasta
            // 
            cmbFechaHasta.Location = new Point(155, 140);
            cmbFechaHasta.Name = "cmbFechaHasta";
            cmbFechaHasta.Size = new Size(272, 27);
            cmbFechaHasta.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(19, 62);
            label4.Name = "label4";
            label4.Size = new Size(408, 28);
            label4.TabIndex = 5;
            label4.Text = "Seleccione fechas de consideracion de reseña:";
            // 
            // cmbTipoReseña
            // 
            cmbTipoReseña.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReseña.FormattingEnabled = true;
            cmbTipoReseña.Location = new Point(155, 232);
            cmbTipoReseña.Name = "cmbTipoReseña";
            cmbTipoReseña.Size = new Size(151, 28);
            cmbTipoReseña.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 235);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 7;
            label5.Text = "Reseñas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(19, 196);
            label6.Name = "label6";
            label6.Size = new Size(253, 28);
            label6.TabIndex = 8;
            label6.Text = "Seleccione tipos de reseñas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(19, 276);
            label7.Name = "label7";
            label7.Size = new Size(291, 28);
            label7.TabIndex = 9;
            label7.Text = "Seleccione tipo de visualizacion:";
            // 
            // grbTipoVisualizacion
            // 
            grbTipoVisualizacion.Controls.Add(rdPantalla);
            grbTipoVisualizacion.Controls.Add(rdExcel);
            grbTipoVisualizacion.Controls.Add(rdPDF);
            grbTipoVisualizacion.Location = new Point(155, 307);
            grbTipoVisualizacion.Name = "grbTipoVisualizacion";
            grbTipoVisualizacion.Size = new Size(98, 113);
            grbTipoVisualizacion.TabIndex = 10;
            grbTipoVisualizacion.TabStop = false;
            // 
            // rdPantalla
            // 
            rdPantalla.AutoSize = true;
            rdPantalla.Location = new Point(13, 85);
            rdPantalla.Name = "rdPantalla";
            rdPantalla.Size = new Size(82, 24);
            rdPantalla.TabIndex = 2;
            rdPantalla.TabStop = true;
            rdPantalla.Text = "Pantalla";
            rdPantalla.UseVisualStyleBackColor = true;
            // 
            // rdExcel
            // 
            rdExcel.AutoSize = true;
            rdExcel.Location = new Point(13, 55);
            rdExcel.Name = "rdExcel";
            rdExcel.Size = new Size(64, 24);
            rdExcel.TabIndex = 1;
            rdExcel.TabStop = true;
            rdExcel.Text = "Excel";
            rdExcel.UseVisualStyleBackColor = true;
            // 
            // rdPDF
            // 
            rdPDF.AutoSize = true;
            rdPDF.Location = new Point(13, 25);
            rdPDF.Name = "rdPDF";
            rdPDF.Size = new Size(56, 24);
            rdPDF.TabIndex = 0;
            rdPDF.TabStop = true;
            rdPDF.Text = "PDF";
            rdPDF.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarDatos
            // 
            btnLimpiarDatos.Location = new Point(365, 516);
            btnLimpiarDatos.Name = "btnLimpiarDatos";
            btnLimpiarDatos.Size = new Size(94, 48);
            btnLimpiarDatos.TabIndex = 11;
            btnLimpiarDatos.Text = "Limpiar Datos";
            btnLimpiarDatos.UseVisualStyleBackColor = true;
            btnLimpiarDatos.Click += btnLimpiarDatos_Click;
            // 
            // btnGenerarRanking
            // 
            btnGenerarRanking.Location = new Point(465, 516);
            btnGenerarRanking.Name = "btnGenerarRanking";
            btnGenerarRanking.Size = new Size(94, 48);
            btnGenerarRanking.TabIndex = 12;
            btnGenerarRanking.Text = "Generar Ranking";
            btnGenerarRanking.UseVisualStyleBackColor = true;
            btnGenerarRanking.Click += btnGenerarRanking_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 577);
            Controls.Add(btnGenerarRanking);
            Controls.Add(btnLimpiarDatos);
            Controls.Add(grbTipoVisualizacion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbTipoReseña);
            Controls.Add(label4);
            Controls.Add(cmbFechaHasta);
            Controls.Add(cmbFechaDesde);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interfaz generar reporte ranking de vino";
            Load += Form1_Load;
            grbTipoVisualizacion.ResumeLayout(false);
            grbTipoVisualizacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker cmbFechaDesde;
        private DateTimePicker cmbFechaHasta;
        private Label label4;
        private ComboBox cmbTipoReseña;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox grbTipoVisualizacion;
        private RadioButton rdPDF;
        private RadioButton rdPantalla;
        private RadioButton rdExcel;
        private Button btnLimpiarDatos;
        private Button btnGenerarRanking;
    }
}
