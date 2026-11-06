namespace AvionicsDashboard
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
            lblAltitude = new Label();
            button1 = new Button();
            lblAirspeed = new Label();
            lblFuel = new Label();
            prgFuel = new ProgressBar();
            lstBlackBox = new ListBox();
            SuspendLayout();
            // 
            // lblAltitude
            // 
            lblAltitude.AutoSize = true;
            lblAltitude.BackColor = Color.White;
            lblAltitude.Location = new Point(92, 108);
            lblAltitude.Name = "lblAltitude";
            lblAltitude.Size = new Size(91, 20);
            lblAltitude.TabIndex = 0;
            lblAltitude.Text = "Altitude: 0 ft";
            // 
            // button1
            // 
            button1.Location = new Point(210, 104);
            button1.Name = "button1";
            button1.Size = new Size(147, 29);
            button1.TabIndex = 1;
            button1.Text = "Start Telemetry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblAirspeed
            // 
            lblAirspeed.AutoSize = true;
            lblAirspeed.BackColor = Color.Snow;
            lblAirspeed.FlatStyle = FlatStyle.Flat;
            lblAirspeed.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAirspeed.ForeColor = Color.Lime;
            lblAirspeed.Location = new Point(114, 193);
            lblAirspeed.Name = "lblAirspeed";
            lblAirspeed.Size = new Size(64, 18);
            lblAirspeed.TabIndex = 2;
            lblAirspeed.Text = "label1";
            // 
            // lblFuel
            // 
            lblFuel.AutoSize = true;
            lblFuel.BackColor = Color.Snow;
            lblFuel.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuel.ForeColor = Color.Lime;
            lblFuel.Location = new Point(114, 213);
            lblFuel.Name = "lblFuel";
            lblFuel.Size = new Size(65, 18);
            lblFuel.TabIndex = 3;
            lblFuel.Text = "label2";
            // 
            // prgFuel
            // 
            prgFuel.Location = new Point(114, 234);
            prgFuel.Name = "prgFuel";
            prgFuel.Size = new Size(125, 29);
            prgFuel.TabIndex = 4;
            // 
            // lstBlackBox
            // 
            lstBlackBox.FormattingEnabled = true;
            lstBlackBox.Location = new Point(603, 272);
            lstBlackBox.Name = "lstBlackBox";
            lstBlackBox.Size = new Size(185, 164);
            lstBlackBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBlackBox);
            Controls.Add(prgFuel);
            Controls.Add(lblFuel);
            Controls.Add(lblAirspeed);
            Controls.Add(button1);
            Controls.Add(lblAltitude);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltitude;
        private Button button1;
        private Label lblAirspeed;
        private Label lblFuel;
        private ProgressBar prgFuel;
        private ListBox lstBlackBox;
    }
}
