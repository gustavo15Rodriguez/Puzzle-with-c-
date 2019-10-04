namespace Rompecabezas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImageBrowse = new System.Windows.Forms.Button();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.groupBoxPuzzle = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelContador = new System.Windows.Forms.Label();
            this.startNow = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxGuia = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.startNow.SuspendLayout();
            this.status.SuspendLayout();
            this.groupBoxGuia.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonImageBrowse);
            this.groupBox1.Controls.Add(this.textBoxImagePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar una imagen";
            // 
            // buttonImageBrowse
            // 
            this.buttonImageBrowse.Location = new System.Drawing.Point(619, 20);
            this.buttonImageBrowse.Name = "buttonImageBrowse";
            this.buttonImageBrowse.Size = new System.Drawing.Size(85, 20);
            this.buttonImageBrowse.TabIndex = 1;
            this.buttonImageBrowse.Text = "...";
            this.buttonImageBrowse.UseVisualStyleBackColor = true;
            this.buttonImageBrowse.Click += new System.EventHandler(this.ButtonImageBrowse_Click);
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(7, 20);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(606, 20);
            this.textBoxImagePath.TabIndex = 0;
            // 
            // groupBoxPuzzle
            // 
            this.groupBoxPuzzle.Location = new System.Drawing.Point(13, 88);
            this.groupBoxPuzzle.Name = "groupBoxPuzzle";
            this.groupBoxPuzzle.Size = new System.Drawing.Size(444, 360);
            this.groupBoxPuzzle.TabIndex = 1;
            this.groupBoxPuzzle.TabStop = false;
            this.groupBoxPuzzle.Text = "Puzzle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.labelContador);
            this.groupBox2.Location = new System.Drawing.Point(13, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo restante";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 32);
            this.progressBar1.Maximum = 900;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(735, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.Location = new System.Drawing.Point(338, 16);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(0, 13);
            this.labelContador.TabIndex = 0;
            // 
            // startNow
            // 
            this.startNow.Controls.Add(this.btnStart);
            this.startNow.Location = new System.Drawing.Point(464, 88);
            this.startNow.Name = "startNow";
            this.startNow.Size = new System.Drawing.Size(297, 54);
            this.startNow.TabIndex = 3;
            this.startNow.TabStop = false;
            this.startNow.Text = "¿Quieres intentarlo?";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Empezar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click_1);
            // 
            // status
            // 
            this.status.Controls.Add(this.labelStatus);
            this.status.Location = new System.Drawing.Point(463, 148);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(297, 41);
            this.status.TabIndex = 4;
            this.status.TabStop = false;
            this.status.Text = "Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(7, 20);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBoxGuia
            // 
            this.groupBoxGuia.Controls.Add(this.label1);
            this.groupBoxGuia.Location = new System.Drawing.Point(464, 195);
            this.groupBoxGuia.Name = "groupBoxGuia";
            this.groupBoxGuia.Size = new System.Drawing.Size(297, 253);
            this.groupBoxGuia.TabIndex = 5;
            this.groupBoxGuia.TabStop = false;
            this.groupBoxGuia.Text = "Imagen de guia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.groupBoxGuia);
            this.Controls.Add(this.status);
            this.Controls.Add(this.startNow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPuzzle);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi rompecabezas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.startNow.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.groupBoxGuia.ResumeLayout(false);
            this.groupBoxGuia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImageBrowse;
        private System.Windows.Forms.TextBox textBoxImagePath;
        private System.Windows.Forms.GroupBox groupBoxPuzzle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox startNow;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox status;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBoxGuia;
        private System.Windows.Forms.Label label1;
    }
}

