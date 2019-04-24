using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledz_gui
{
    public partial class MainWondow : Form
    {
        int[] ResArray = { 10, 11, 12, 13, 15, 16, 18, 20, 22, 24, 27, 30, 33, 36, 39, 43, 47, 51, 56, 62, 68, 75, 82, 91, 100, 110, 120, 130, 150, 160, 180, 200, 220, 240, 270, 300, 330, 360, 390, 430, 470, 510, 560, 620, 680, 750, 820, 910, 1000, 1100, 1200, 1300, 1500, 1600, 1800, 2000, 2200, 2400, 2700, 3000, 3300, 3600, 3900, 4300, 4700, 4750, 5100, 5600, 6200, 6800, 7500, 8200, 9100, 10000, 11000, 12000, 13000, 15000, 16000, 18000, 20000, 22000, 24000, 27000, 30000, 33000, 36000, 39000, 43000, 47000, 51000, 56000, 62000, 68000, 75000, 82000, 91000, 100000, 110000, 120000, 130000, 150000, 160000, 180000, 200000, 220000, 240000, 270000, 300000, 330000, 360000, 390000, 430000, 470000, 510000, 560000, 620000, 680000, 750000, 820000, 910000, 1000000, 1100000, 1200000, 1300000, 1500000, 1600000, 1800000, 2000000, 2200000, 2400000, 2700000, 3000000, 3300000, 3600000, 3900000, 4300000, 4700000, 4750000, 5100000 };
        string PowerAbbr;
        string ResAbbr;
        public MainWondow()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorLabel.ForeColor = Color.Black;
            errorLabel.Text = "";
            float SourceVoltage = float.Parse(SourceVoltageBox.Text);
            float LoadVoltage = float.Parse(LoadVoltageBox.Text);
            double LoadCurrent = double.Parse(LoadCurrentBox.Text);
            if (LoadVoltage > SourceVoltage)
            {
                LoadVoltageBox.Text = "";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Text = "Напряжение выше источника!";
            }

            else
            {
                double CalculatedResistance = (SourceVoltage - LoadVoltage) / (LoadCurrent / 1000);
                double CalculatedPower = Math.Pow(LoadCurrent, 2) * CalculatedResistance / 1000;
                if (CalculatedPower >= 1000)
                {
                    CalculatedPower = CalculatedPower / 1000;
                    PowerAbbr = "Вт";
                }

                else if (CalculatedPower < 1000)
                {
                    PowerAbbr = "мВт";
                }

                double MidResistance = Math.Ceiling(CalculatedResistance);
                int arrIndex = 0;
                do
                {
                    arrIndex++;
                }
                while (MidResistance >= ResArray[arrIndex]);
                double EndResistance = ResArray[arrIndex];                

                if (EndResistance >= 1000)
                {
                    EndResistance = EndResistance / 1000;
                    ResAbbr = "кОм";
                }
                else if (EndResistance < 1000)
                {
                    ResAbbr = "Ом";
                }

                ResultLabel.Text = EndResistance.ToString() + ResAbbr + "  " + CalculatedPower.ToString() + PowerAbbr;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new About();
            frm.Show();
        }

        private void MainWondow_Load(object sender, EventArgs e)
        {

        }
    }
}
