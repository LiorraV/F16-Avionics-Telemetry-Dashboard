using System;
using System.Drawing;
using System.Windows.Forms;

namespace AvionicsDashboard
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer telemetryTimer;
        private Random randomGenerator;

        // Flight metrics variables
        private int currentAltitude = 0;
        private int currentAirspeed = 0;
        private double currentFuel = 100.0;
        private int timeElapsed = 0; // Timestamp for the black box

        public Form1()
        {
            InitializeComponent();

            randomGenerator = new Random();
            telemetryTimer = new System.Windows.Forms.Timer();
            telemetryTimer.Interval = 500;
            telemetryTimer.Tick += TelemetryTimer_Tick;
        }

        private void TelemetryTimer_Tick(object sender, EventArgs e)
        {
            timeElapsed++;

            // 1. Altitude
            currentAltitude += randomGenerator.Next(50, 150);
            lblAltitude.Text = "Altitude: " + currentAltitude + " ft";
            if (currentAltitude > 1000) lblAltitude.ForeColor = Color.Red;
            else lblAltitude.ForeColor = Color.Lime;

            // 2. Airspeed
            currentAirspeed += randomGenerator.Next(-5, 15);
            if (currentAirspeed < 0) currentAirspeed = 0;
            lblAirspeed.Text = "Airspeed: " + currentAirspeed + " knots";

            // 3. Fuel & Progress Bar
            currentFuel -= randomGenerator.NextDouble() * 1.5;
            if (currentFuel < 0) currentFuel = 0;
            lblFuel.Text = "Fuel: " + Math.Round(currentFuel, 1) + " %";

            // Update Progress Bar
            prgFuel.Value = (int)currentFuel;

            if (currentFuel < 20.0) lblFuel.ForeColor = Color.Red;
            else lblFuel.ForeColor = Color.Lime;

            // 4. Black Box Logging
            string logEntry = $"T+{timeElapsed * 0.5}s | ALT: {currentAltitude} | SPD: {currentAirspeed} | FUEL: {Math.Round(currentFuel, 1)}%";
            lstBlackBox.Items.Add(logEntry);

            // Auto-scroll to the newest log entry
            lstBlackBox.TopIndex = lstBlackBox.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (telemetryTimer.Enabled)
            {
                telemetryTimer.Stop();
                button1.Text = "Start Telemetry";
                lstBlackBox.Items.Add("--- SYSTEM PAUSED ---");
            }
            else
            {
                telemetryTimer.Start();
                button1.Text = "Stop Telemetry";

                // Reset metrics
                currentAltitude = 0;
                currentAirspeed = 250;
                currentFuel = 100.0;
                timeElapsed = 0;

                lblAltitude.ForeColor = Color.Lime;
                lblAirspeed.ForeColor = Color.Lime;
                lblFuel.ForeColor = Color.Lime;

                prgFuel.Value = 100;
                lstBlackBox.Items.Clear();
                lstBlackBox.Items.Add("--- SYSTEM START ---");
            }
        }

        // Empty events to prevent designer errors
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}