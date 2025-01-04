namespace ProjetoFinal1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            labelTitulo = new Label();
            panel2 = new Panel();
            notificationLabel = new Label();
            resultLabel1 = new Label();
            resultLabel = new Label();
            panel3 = new Panel();
            assembleButton = new Button();
            cpuTextBox = new TextBox();
            storageTextBox = new TextBox();
            labelArm = new Label();
            strategyComboBox = new ComboBox();
            computerTypeComboBox = new ComboBox();
            labelEstilo = new Label();
            ramTextBox = new TextBox();
            labelTipo = new Label();
            labelCpu = new Label();
            labelRam = new Label();
            label1 = new Label();
            labelEstiloPC = new Label();
            labelConfig = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 121);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(428, 41);
            label2.Name = "label2";
            label2.Size = new Size(309, 30);
            label2.TabIndex = 1;
            label2.Text = "FÁBRICA DE COMPUTADORES";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(66, 34);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(198, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Montar Computador";
            // 
            // panel2
            // 
            panel2.Controls.Add(notificationLabel);
            panel2.Controls.Add(resultLabel1);
            panel2.Controls.Add(resultLabel);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(labelEstiloPC);
            panel2.Controls.Add(labelConfig);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(1083, 538);
            panel2.TabIndex = 2;
            // 
            // notificationLabel
            // 
            notificationLabel.Anchor = AnchorStyles.Top;
            notificationLabel.AutoSize = true;
            notificationLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notificationLabel.Location = new Point(364, 480);
            notificationLabel.Name = "notificationLabel";
            notificationLabel.Size = new Size(187, 25);
            notificationLabel.TabIndex = 5;
            notificationLabel.Text = "Aguardando Dados...";
            // 
            // resultLabel1
            // 
            resultLabel1.Anchor = AnchorStyles.Top;
            resultLabel1.AutoSize = true;
            resultLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel1.Location = new Point(365, 304);
            resultLabel1.Name = "resultLabel1";
            resultLabel1.Size = new Size(175, 25);
            resultLabel1.TabIndex = 5;
            resultLabel1.Text = "Aguardando Dados";
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.Top;
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(364, 128);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(177, 25);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "Agurdando Dados...";
            // 
            // panel3
            // 
            panel3.Controls.Add(assembleButton);
            panel3.Controls.Add(cpuTextBox);
            panel3.Controls.Add(storageTextBox);
            panel3.Controls.Add(labelArm);
            panel3.Controls.Add(strategyComboBox);
            panel3.Controls.Add(computerTypeComboBox);
            panel3.Controls.Add(labelEstilo);
            panel3.Controls.Add(ramTextBox);
            panel3.Controls.Add(labelTipo);
            panel3.Controls.Add(labelTitulo);
            panel3.Controls.Add(labelCpu);
            panel3.Controls.Add(labelRam);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 538);
            panel3.TabIndex = 4;
            // 
            // assembleButton
            // 
            assembleButton.BackColor = SystemColors.ControlLightLight;
            assembleButton.FlatStyle = FlatStyle.Flat;
            assembleButton.Location = new Point(104, 474);
            assembleButton.Name = "assembleButton";
            assembleButton.Size = new Size(122, 31);
            assembleButton.TabIndex = 5;
            assembleButton.Text = "Montar";
            assembleButton.UseVisualStyleBackColor = false;
            assembleButton.Click += assembleButton_Click;
            // 
            // cpuTextBox
            // 
            cpuTextBox.Location = new Point(76, 114);
            cpuTextBox.Name = "cpuTextBox";
            cpuTextBox.Size = new Size(178, 23);
            cpuTextBox.TabIndex = 0;
            // 
            // storageTextBox
            // 
            storageTextBox.Location = new Point(76, 270);
            storageTextBox.Name = "storageTextBox";
            storageTextBox.Size = new Size(178, 23);
            storageTextBox.TabIndex = 2;
            // 
            // labelArm
            // 
            labelArm.AutoSize = true;
            labelArm.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelArm.Location = new Point(83, 230);
            labelArm.Name = "labelArm";
            labelArm.Size = new Size(164, 25);
            labelArm.TabIndex = 1;
            labelArm.Text = "Armazenamento:";
            // 
            // strategyComboBox
            // 
            strategyComboBox.FormattingEnabled = true;
            strategyComboBox.Location = new Point(76, 426);
            strategyComboBox.Name = "strategyComboBox";
            strategyComboBox.Size = new Size(178, 23);
            strategyComboBox.TabIndex = 4;
            // 
            // computerTypeComboBox
            // 
            computerTypeComboBox.FormattingEnabled = true;
            computerTypeComboBox.Location = new Point(76, 348);
            computerTypeComboBox.Name = "computerTypeComboBox";
            computerTypeComboBox.Size = new Size(178, 23);
            computerTypeComboBox.TabIndex = 3;
            // 
            // labelEstilo
            // 
            labelEstilo.AutoSize = true;
            labelEstilo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstilo.Location = new Point(133, 386);
            labelEstilo.Name = "labelEstilo";
            labelEstilo.Size = new Size(64, 25);
            labelEstilo.TabIndex = 1;
            labelEstilo.Text = "Estilo:";
            // 
            // ramTextBox
            // 
            ramTextBox.Location = new Point(76, 192);
            ramTextBox.Name = "ramTextBox";
            ramTextBox.Size = new Size(178, 23);
            ramTextBox.TabIndex = 1;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(137, 308);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(57, 25);
            labelTipo.TabIndex = 1;
            labelTipo.Text = "Tipo:";
            // 
            // labelCpu
            // 
            labelCpu.AutoSize = true;
            labelCpu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCpu.Location = new Point(138, 74);
            labelCpu.Name = "labelCpu";
            labelCpu.Size = new Size(55, 25);
            labelCpu.TabIndex = 1;
            labelCpu.Text = "CPU:";
            // 
            // labelRam
            // 
            labelRam.AutoSize = true;
            labelRam.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRam.Location = new Point(135, 152);
            labelRam.Name = "labelRam";
            labelRam.Size = new Size(60, 25);
            labelRam.TabIndex = 1;
            labelRam.Text = "RAM:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(630, 386);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(165, 37);
            label1.TabIndex = 1;
            label1.Text = "Notificação";
            // 
            // labelEstiloPC
            // 
            labelEstiloPC.Anchor = AnchorStyles.Top;
            labelEstiloPC.AutoSize = true;
            labelEstiloPC.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstiloPC.Location = new Point(563, 210);
            labelEstiloPC.Name = "labelEstiloPC";
            labelEstiloPC.Size = new Size(298, 37);
            labelEstiloPC.TabIndex = 1;
            labelEstiloPC.Text = "Estilo do Computador";
            // 
            // labelConfig
            // 
            labelConfig.Anchor = AnchorStyles.Top;
            labelConfig.AutoSize = true;
            labelConfig.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConfig.Location = new Point(554, 34);
            labelConfig.Name = "labelConfig";
            labelConfig.Size = new Size(316, 37);
            labelConfig.TabIndex = 1;
            labelConfig.Text = "Configuração Escolhida";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1083, 659);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(1099, 698);
            Name = "MainForm";
            Text = "Linha de Montagem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitulo;
        private Panel panel2;
        private TextBox storageTextBox;
        private Label labelRam;
        private TextBox cpuTextBox;
        private Label labelCpu;
        private TextBox ramTextBox;
        private Label labelArm;
        private ComboBox computerTypeComboBox;
        private Label labelTipo;
        private Panel panel3;
        private ComboBox strategyComboBox;
        private Label labelEstilo;
        private Label resultLabel;
        private Button assembleButton;
        private Label labelConfig;
        private Label resultLabel1;
        private Label labelEstiloPC;
        private Label notificationLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
