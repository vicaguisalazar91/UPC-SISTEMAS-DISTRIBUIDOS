namespace UI
{
    partial class frmSkier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFederation = new System.Windows.Forms.ComboBox();
            this.dtpSkierBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtSkierDocument = new System.Windows.Forms.TextBox();
            this.txtSkierFullName = new System.Windows.Forms.TextBox();
            this.txtSkierId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSkierFind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvSkier = new System.Windows.Forms.DataGridView();
            this.NumberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FederationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkier)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.guardarToolStripMenuItem.Text = "Nuevo";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.actualizarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFederation);
            this.groupBox1.Controls.Add(this.dtpSkierBirthday);
            this.groupBox1.Controls.Add(this.txtSkierDocument);
            this.groupBox1.Controls.Add(this.txtSkierFullName);
            this.groupBox1.Controls.Add(this.txtSkierId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(487, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(384, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Esquiadores:";
            // 
            // cmbFederation
            // 
            this.cmbFederation.FormattingEnabled = true;
            this.cmbFederation.Location = new System.Drawing.Point(116, 109);
            this.cmbFederation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFederation.Name = "cmbFederation";
            this.cmbFederation.Size = new System.Drawing.Size(264, 21);
            this.cmbFederation.TabIndex = 9;
            // 
            // dtpSkierBirthday
            // 
            this.dtpSkierBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSkierBirthday.Location = new System.Drawing.Point(116, 87);
            this.dtpSkierBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSkierBirthday.Name = "dtpSkierBirthday";
            this.dtpSkierBirthday.Size = new System.Drawing.Size(84, 20);
            this.dtpSkierBirthday.TabIndex = 8;
            this.dtpSkierBirthday.Value = new System.DateTime(2017, 12, 9, 0, 0, 0, 0);
            // 
            // txtSkierDocument
            // 
            this.txtSkierDocument.Location = new System.Drawing.Point(116, 67);
            this.txtSkierDocument.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkierDocument.Name = "txtSkierDocument";
            this.txtSkierDocument.Size = new System.Drawing.Size(84, 20);
            this.txtSkierDocument.TabIndex = 7;
            // 
            // txtSkierFullName
            // 
            this.txtSkierFullName.Location = new System.Drawing.Point(116, 47);
            this.txtSkierFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkierFullName.Name = "txtSkierFullName";
            this.txtSkierFullName.Size = new System.Drawing.Size(264, 20);
            this.txtSkierFullName.TabIndex = 6;
            // 
            // txtSkierId
            // 
            this.txtSkierId.Location = new System.Drawing.Point(116, 27);
            this.txtSkierId.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkierId.Name = "txtSkierId";
            this.txtSkierId.Size = new System.Drawing.Size(76, 20);
            this.txtSkierId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Federación afiliada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Macimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro. de DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos y Nombres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Esquiador:";
            // 
            // txtSkierFind
            // 
            this.txtSkierFind.Location = new System.Drawing.Point(109, 27);
            this.txtSkierFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkierFind.Name = "txtSkierFind";
            this.txtSkierFind.Size = new System.Drawing.Size(290, 20);
            this.txtSkierFind.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Buscar Esquiador:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(403, 27);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 22);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvSkier
            // 
            this.dgvSkier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberId,
            this.SkierName,
            this.Birthdate,
            this.FederationID});
            this.dgvSkier.Location = new System.Drawing.Point(10, 53);
            this.dgvSkier.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSkier.Name = "dgvSkier";
            this.dgvSkier.RowTemplate.Height = 24;
            this.dgvSkier.Size = new System.Drawing.Size(473, 256);
            this.dgvSkier.TabIndex = 5;
            // 
            // NumberId
            // 
            this.NumberId.DataPropertyName = "NumberId";
            this.NumberId.HeaderText = "NumberId";
            this.NumberId.Name = "NumberId";
            // 
            // SkierName
            // 
            this.SkierName.DataPropertyName = "SkierName";
            this.SkierName.HeaderText = "SkierName";
            this.SkierName.Name = "SkierName";
            // 
            // Birthdate
            // 
            this.Birthdate.DataPropertyName = "Birthdate";
            this.Birthdate.HeaderText = "Birthdate";
            this.Birthdate.Name = "Birthdate";
            // 
            // FederationID
            // 
            this.FederationID.DataPropertyName = "FederationID";
            this.FederationID.HeaderText = "FederationID";
            this.FederationID.Name = "FederationID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(796, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSkier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSkier);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSkierFind);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSkier";
            this.Text = "Mantenimiento de Esquiadores";
            this.Load += new System.EventHandler(this.frmSkier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFederation;
        private System.Windows.Forms.DateTimePicker dtpSkierBirthday;
        private System.Windows.Forms.TextBox txtSkierDocument;
        private System.Windows.Forms.TextBox txtSkierFullName;
        private System.Windows.Forms.TextBox txtSkierId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSkierFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvSkier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FederationID;
    }
}