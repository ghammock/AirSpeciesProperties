

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AirSpeciesProperties
{
    public partial class GasPropsMainWindow : Form
    {
        private string defaultOutputText =  "Input both a temperature and pressure and "
                                          + "select a gas species from the drop down box.";

        private bool validTemperature = false;
        private bool validPressure = false;

        Species N2 = new Species();
        Species N = new Species();
        Species N_plus = new Species();
        Species O2 = new Species();
        Species O = new Species();
        Species O_plus = new Species();
        Species NO = new Species();
        Species NO_plus = new Species();
        Species e_gas = new Species();

        public GasPropsMainWindow()
        {
            InitializeComponent();
            PropertiesOutputTextBox.Text = defaultOutputText;
            SpeciesSelector.SelectedIndex = 0;
            InitializeSpecies();
        }

        private void InitializeSpecies()
        {
            double reducedMass;

            // Diatomic Nitrogen
            reducedMass = Species.calculateReducedMass(14.008, 14.008);

            N2.Name = "Nitrogen, Diatomic";
            N2.Formula = "N2";
            N2.MolecularWeight = 28.0134;
            N2.calculateMass();
            N2.Radius = 1.08758e-10;
            N2.MomentOfInertia = reducedMass * Math.Pow(N2.Radius, 2.0);
            N2.IsMonatomic = false;
            N2.IsSymmetric = true;
            N2.setWaveNumber(235755.0);
            N2.setDissociationEnergy(6580058280.0);

            // Monatomic Nitrogen
            N.Name = "Nitrogen, Monatomic";
            N.Formula = "N";
            N.MolecularWeight = 14.008;
            N.calculateMass();
            N.Radius = 65.0e-12;
            N.MomentOfInertia = 0.0;
            N.IsMonatomic = true;
            N.IsSymmetric = true;
            N.setWaveNumber(0.0);
            N.setDissociationEnergy(19957977573.5);

            N.AddElectronicState(      0.0, 4.0);
            N.AddElectronicState(1922390.0, 6.0);
            N.AddElectronicState(1922310.0, 4.0);
            N.AddElectronicState(2884000.0, 5.0);
            N.AddElectronicState(8328550.0, 2.0);

            // Nitrogen Ion (+)
            N_plus.Name = "Nitrogen Ion (+)";
            N_plus.Formula = "N+";
            N_plus.MolecularWeight = 14.00615;
            N_plus.calculateMass();
            N_plus.Radius = 65.0e-12;
            N_plus.MomentOfInertia = 0.0;
            N_plus.IsMonatomic = true;
            N_plus.IsSymmetric = true;
            N_plus.setWaveNumber(0.0);
            N_plus.setEnthalpyOfFormation(1873152.0);

            N_plus.AddElectronicState(      0.0, 1.0);
            N_plus.AddElectronicState(   4870.0, 3.0);
            N_plus.AddElectronicState(  13080.0, 5.0);
            N_plus.AddElectronicState(1531620.0, 5.0);
            N_plus.AddElectronicState(3268880.0, 1.0);
            N_plus.AddElectronicState(4678460.0, 5.0);

            // Diatomic Oxygen
            reducedMass = Species.calculateReducedMass(16.0, 16.0);

            O2.Name = "Oxygen, Diatomic";
            O2.Formula = "O2";
            O2.MolecularWeight = 31.9988;
            O2.calculateMass();
            O2.Radius = 1.2074e-10;
            O2.MomentOfInertia = reducedMass * Math.Pow(O2.Radius, 2.0);
            O2.IsMonatomic = false;
            O2.IsSymmetric = true;
            O2.setWaveNumber(158024.6);
            O2.setEnthalpyOfFormation(0.0);

            // Monatomic Oxygen
            O.Name = "Oxygen, Monatomic";
            O.Formula = "O";
            O.MolecularWeight = 16.000;
            O.calculateMass();
            O.Radius = 60.0e-12;
            O.MomentOfInertia = 0.0;
            O.IsMonatomic = true;
            O.IsSymmetric = false;
            O.setWaveNumber(0.0);
            O.setDissociationEnergy(8.19608E-19);

            O.AddElectronicState(      0.0, 5.0);
            O.AddElectronicState(  15850.0, 3.0);
            O.AddElectronicState(  22650.0, 1.0);
            O.AddElectronicState(1586770.0, 5.0);
            O.AddElectronicState(3379240.0, 1.0);

            // Oxygen Ion (+)
            O_plus.Name = "Oxygen Ion (+)";
            O_plus.Formula = "O+";
            O_plus.MolecularWeight = 15.99885;
            O_plus.calculateMass();
            O_plus.Radius = 60.0e-12;
            O_plus.MomentOfInertia = 0.0;
            O_plus.IsMonatomic = true;
            O_plus.IsSymmetric = true;
            O_plus.setWaveNumber(0.0);
            O_plus.setEnthalpyOfFormation(314040.0);

            O_plus.AddElectronicState(      0.0, 4.0);
            O_plus.AddElectronicState(2681070.0, 6.0);
            O_plus.AddElectronicState(2683050.0, 4.0);
            O_plus.AddElectronicState(4046690.0, 4.0);
            O_plus.AddElectronicState(4046840.0, 2.0);

            // Nitrogen Oxide
            reducedMass = Species.calculateReducedMass(14.008, 16.0);

            NO.Name = "Nitrogen Oxide";
            NO.Formula = "NO";
            NO.MolecularWeight = 30.008;
            NO.calculateMass();
            NO.Radius = 1.1508e-10;
            NO.MomentOfInertia = reducedMass * Math.Pow(NO.Radius, 2.0);
            NO.IsMonatomic = false;
            NO.IsSymmetric = false;
            NO.setWaveNumber(190360.0);
            NO.setDissociationEnergy(1.03821E-18);

            // Nitrogen Oxide Ion
            reducedMass = Species.calculateReducedMass(14.008, 16.0);

            NO_plus.Name = "Nitrogen Oxide Ion";
            NO_plus.Formula = "NO+";
            NO_plus.MolecularWeight = 30.00555;
            NO_plus.calculateMass();
            NO_plus.Radius = 1.0619e-10;
            NO_plus.MomentOfInertia = reducedMass * Math.Pow(NO_plus.Radius, 2.0);
            NO_plus.IsMonatomic = false;
            NO_plus.IsSymmetric = false;
            NO_plus.setWaveNumber(237710.0);
            NO_plus.setEnthalpyOfFormation(983995.0);

            NO_plus.AddElectronicState(0.0, 1.0);

            // Electron Gas
            e_gas.Name = "Electron Gas";
            e_gas.Formula = "e-";
            e_gas.MolecularWeight = 0.00054858;
            e_gas.calculateMass();
            e_gas.Radius = 10e-22;
            e_gas.MomentOfInertia = 0.0;
            e_gas.IsMonatomic = true;
            e_gas.IsSymmetric = false;
            e_gas.setWaveNumber(0.0);
            e_gas.setEnthalpyOfFormation(0.0);

            e_gas.AddElectronicState(0.0, 2.0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (PropertiesOutputTextBox.Text == defaultOutputText)
            {
                MessageBox.Show("There is nothing to save.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream filestream = new FileStream(SaveFileDialog.FileName, FileMode.Create);
                    StreamWriter stream = new StreamWriter(filestream);
                    stream.Write(PropertiesOutputTextBox.Text);
                    stream.Close();
                    filestream.Close();
                }
            }
        }  // End method saveToolStripMenuItem1_Click().

        private void TemperatureInput_TextChanged(object sender, EventArgs e)
        {
            if ((TemperatureInput.Text.Length > 0) && !IO.validNumber(TemperatureInput.Text))
            {
                TemperatureInput.BackColor = System.Drawing.Color.FromArgb(255, 255, 192, 192);
                validTemperature = false;
            }
            else
            {
                TemperatureInput.BackColor = System.Drawing.SystemColors.Window;

                if (TemperatureInput.Text.Length > 0)
                    validTemperature = true;
                else
                    validTemperature = false;
            }

            if (validPressure && validTemperature)
                CalculateButton.Enabled = true;
            else
                CalculateButton.Enabled = false;
        }

        private void PressureInput_TextChanged(object sender, EventArgs e)
        {
            if ((PressureInput.Text.Length > 0) && !IO.validNumber(PressureInput.Text))
            {
                PressureInput.BackColor = System.Drawing.Color.FromArgb(255, 255, 192, 192);
                validPressure = false;
            }
            else
            {
                PressureInput.BackColor = System.Drawing.SystemColors.Window;

                if (PressureInput.Text.Length > 0)
                    validPressure = true;
                else
                    validPressure = false;
            }

            if (validPressure && validTemperature)
                CalculateButton.Enabled = true;
            else
                CalculateButton.Enabled = false;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Species currentSpecies = new Species();

            switch (SpeciesSelector.SelectedIndex)
            {
                case 0:
                    currentSpecies = N2;
                    break;

                case 1:
                    currentSpecies = N;
                    break;

                case 2:
                    currentSpecies = N_plus;
                    break;

                case 3:
                    currentSpecies = O2;
                    break;

                case 4:
                    currentSpecies = O;
                    break;

                case 5:
                    currentSpecies = O_plus;
                    break;

                case 6:
                    currentSpecies = NO;
                    break;

                case 7:
                    currentSpecies = NO_plus;
                    break;

                case 8:
                    currentSpecies = e_gas;
                    break;

                default:
                    return;
            }

            ThermoProps data = new ThermoProps();

            data = currentSpecies.calculateProperties(Double.Parse(TemperatureInput.Text),
                                                      Double.Parse(PressureInput.Text));

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(currentSpecies.Name + " - " + currentSpecies.Formula);

            int strLength =  currentSpecies.Name.Length
                           + currentSpecies.Formula.Length
                           + 3;

            for (int i = 0; i < strLength; ++i)
                sb.Append('=');
            sb.AppendLine();
            sb.AppendLine();

            sb.AppendLine(String.Format("{0,-22}", "Temperature: ")
                          + String.Format("{0:g}", data.Temperature)
                          + " K");

            sb.AppendLine(String.Format("{0,-22}", "Pressure: ")
                          + String.Format("{0:g}", data.Pressure)
                          + " MPa");

            sb.AppendLine(String.Format("{0,-22}", "Molecular Weight: ")
                          + String.Format("{0:g}", data.MolecularWeight));

            sb.AppendLine(String.Format("{0,-22}", "Gas Constant: ")
                          + String.Format("{0:g5}", data.GasConstant)
                          + " kJ/kg-K");

            sb.AppendLine(String.Format("{0,-22}", "Internal Energy: ")
                          + String.Format("{0:g6}", data.InternalEnergy)
                          + " kJ/kg");

            sb.AppendLine(String.Format("{0,-22}", "Enthalpy: ")
                          + String.Format("{0:g6}", data.Enthalpy)
                          + " kJ/kg");

            sb.AppendLine(String.Format("{0,-22}", "Entropy: ")
                          + String.Format("{0:g6}", data.Entropy)
                          + " kJ/kg-K");

            sb.AppendLine(String.Format("{0,-22}", "cp: ")
                          + String.Format("{0:g6}", data.Cp)
                          + " kJ/kg-K");

            sb.AppendLine(String.Format("{0,-22}", "cv: ")
                          + String.Format("{0:g6}", data.Cv)
                          + " kJ/kg-K");

            sb.AppendLine(String.Format("{0,-22}", "Gamma: ")
                          + String.Format("{0:g5}", data.Gamma));

            sb.AppendLine(String.Format("{0,-22}", "Sound Speed: ")
                          + String.Format("{0:g5}", data.SoundSpeed)
                          + " m/s");

            sb.AppendLine(String.Format("{0,-22}", "Density: ")
                          + String.Format("{0:g5}", data.Density)
                          + " kg/m^3");

            sb.AppendLine(String.Format("{0,-22}", "Compressibility: ")
                          + String.Format("{0:g4}", data.Compressibility));

            sb.AppendLine(String.Format("{0,-22}", "Dynamic Viscosity: ")
                          + String.Format("{0:0.0###e-0}", data.DynamicViscosity)
                          + " kg/m-s");

            sb.AppendLine(String.Format("{0,-22}", "Kinematic Viscosity: ")
                          + String.Format("{0:0.0###e-0}", data.KinematicViscosity)
                          + " m^2/s");

            sb.AppendLine(String.Format("{0,-22}", "Thermal Conductivity: ")
                          + String.Format("{0:g6}", data.ThermalConductivity)
                          + " W/m-K");

            sb.AppendLine(String.Format("{0,-22}", "Gibbs Free Energy: ")
                          + String.Format("{0:0.0###e-0}", data.GibbsEnergy)
                          + " kJ/kg");

            sb.Append(String.Format("{0,-22}", "Helmholtz Enthalpy: ")
                      + String.Format("{0:0.0###e-0}", data.HelmholtzEnergy)
                      + " kJ/kg");
            // Last line (i.e. no line terminator).

            PropertiesOutputTextBox.Text = sb.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
        }

        private void SpeciesSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PropertiesOutputTextBox.Text != defaultOutputText)
                CalculateButton_Click(sender, e);
        }

        private void PressureInput_KeyDown(object sender, KeyEventArgs e)
        {
            if ((CalculateButton.Enabled) && (e.KeyCode == Keys.Enter))
                CalculateButton_Click(sender, e);
        }

        private void TemperatureInput_KeyDown(object sender, KeyEventArgs e)
        {
            if ((CalculateButton.Enabled) && (e.KeyCode == Keys.Enter))
                CalculateButton_Click(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PropertiesOutputTextBox.Text != defaultOutputText)
                Clipboard.SetText(PropertiesOutputTextBox.Text);
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferencesWindow rw = new ReferencesWindow();
            rw.Show();
        }
    }
}
