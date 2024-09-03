using System;
using System.Drawing;
using System.Windows.Forms;

namespace kr_sii
{
    public partial class Form1 : Form
    {
        Conclusions conclusions = new Conclusions();

        public Form1()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            pictureBoxColor.BackColor = Color.Transparent;

            conclusions.GetData(Convert.ToDouble(textBoxAngle.Text), 
                Convert.ToDouble(textBoxPsi.Text), Convert.ToDouble(textBoxTeta.Text));

            chartImage.Image = conclusions.GetChart();

            textBoxType.Text = conclusions.GetPitchingType();
            textBoxBayes.Text = Convert.ToString(Data.Bayes * 100) + "%";
            textBoxShortliff.Text = Convert.ToString(Data.Shortliff * 100) + "%";

            if (conclusions.GetPitchingType() == "Бортовая качка")
                pictureBoxColor.BackColor = Color.Orange;

            if (conclusions.GetPitchingType() == "Килевая качка")
                pictureBoxColor.BackColor = Color.Yellow;

            if (conclusions.GetPitchingType() == "Параметрическая качка")
                pictureBoxColor.BackColor = Color.Red;
        }
    }
}
