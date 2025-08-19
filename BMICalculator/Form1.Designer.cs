namespace BMICalculator {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome = new System.Windows.Forms.Label();
            this.pibICon = new System.Windows.Forms.PictureBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.txbBMI = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibICon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(195, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(200, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Calculate your BMI";
            // 
            // pibICon
            // 
            this.pibICon.Image = global::BMICalculator.Properties.Resources.imageArchiveBMIcIcon;
            this.pibICon.Location = new System.Drawing.Point(12, 12);
            this.pibICon.Name = "pibICon";
            this.pibICon.Size = new System.Drawing.Size(151, 125);
            this.pibICon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibICon.TabIndex = 1;
            this.pibICon.TabStop = false;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Location = new System.Drawing.Point(103, 147);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(85, 23);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Location = new System.Drawing.Point(106, 196);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(82, 23);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height:";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.BackColor = System.Drawing.Color.Transparent;
            this.lblBMI.Location = new System.Drawing.Point(108, 327);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(55, 23);
            this.lblBMI.TabIndex = 4;
            this.lblBMI.Text = "BMI:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(182, 359);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 23);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbWeight
            // 
            this.txbWeight.Location = new System.Drawing.Point(199, 144);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(211, 32);
            this.txbWeight.TabIndex = 6;
            this.txbWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbWeight_KeyDown);
            this.txbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbWeight_KeyPress);
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(199, 193);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(211, 32);
            this.txbHeight.TabIndex = 7;
            this.txbHeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbHeight_KeyDown);
            this.txbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHeight_KeyPress);
            // 
            // txbBMI
            // 
            this.txbBMI.Enabled = false;
            this.txbBMI.Location = new System.Drawing.Point(169, 324);
            this.txbBMI.Name = "txbBMI";
            this.txbBMI.Size = new System.Drawing.Size(241, 32);
            this.txbBMI.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(112, 244);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(300, 57);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BMICalculator.Properties.Resources.imageBackGround02;
            this.ClientSize = new System.Drawing.Size(478, 413);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbBMI);
            this.Controls.Add(this.txbHeight);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.pibICon);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            ((System.ComponentModel.ISupportInitialize)(this.pibICon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pibICon;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.TextBox txbBMI;
        private System.Windows.Forms.Button btnCalculate;
    }
}

