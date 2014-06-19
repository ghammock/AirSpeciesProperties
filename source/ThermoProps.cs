using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirSpeciesProperties
{
    interface IThermoProps
    {
        // Temperature [units: K].
        double Temperature { get; set; }

        // Pressure [units: MPa].
        double Pressure { get; set; }

        // Molecular weight [units: kg/kmol].
        double MolecularWeight { get; set; }

        // Gas constant [units: kJ/kg-K].
        double GasConstant { get; set; }

        // Internal energy [units: kJ/kg].
        double InternalEnergy { get; set; }

        // Enthalpy [units: kJ/kg].
        double Enthalpy { get; set; }

        // Entropy [units: kJ/kg-K].
        double Entropy { get; set; }

        // Specific heat [units: kJ/kg-K].
        double Cp { get; set; }

        // Specific heat [units: kJ/kg-K].
        double Cv { get; set; }

        // Ratio of specific heats [-dimensionless-].
        double Gamma { get; set; }

        // Speed of sound [units: m/s].
        double SoundSpeed { get; set; }

        // Gas density [units: kg/m^3].
        double Density { get; set; }

        // Z, the compressibility [-dimensionless-].
        double Compressibility { get; set; }

        // Gibbs function [units: kJ/kg].
        double GibbsEnergy { get; set; }

        // Helmholtz function [units: kJ/kg].
        double HelmholtzEnergy { get; set; }

        // Dynamic viscosity [units: kg/m-s].
        double DynamicViscosity { get; set; }

        // Kinematic viscosity [units: m^2/s].
        double KinematicViscosity { get; set; }

        // Thermal conductivity [units: W/m-K].
        double ThermalConductivity { get; set; }
    }

    class ThermoProps : IThermoProps
    {
        private double _temperature;
        private double _pressure;
        private double _molWeight;
        private double _gasConstant;
        private double _intEnergy;
        private double _enthalpy;
        private double _entropy;
        private double _cp;
        private double _cv;
        private double _gamma;
        private double _soundSpeed;
        private double _density;
        private double _comp;
        private double _gibbs;
        private double _helm;
        private double _mu;  // dynamic viscosity.
        private double _nu;  // kinematic viscosity.
        private double _k;   // thermal conductivity.

        // Temperature [units: K].
        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        // Pressure [units: MPa].
        public double Pressure
        {
            get { return _pressure; }
            set { _pressure = value; }
        }

        // Molecular weight [units: kg/kmol].
        public double MolecularWeight
        {
            get { return _molWeight; }
            set { _molWeight = value; }
        }

        // Gas constant [units: kJ/kg-K].
        public double GasConstant
        {
            get { return _gasConstant; }
            set { _gasConstant = value; }
        }

        // Internal energy [units: kJ/kg].
        public double InternalEnergy
        {
            get { return _intEnergy; }
            set { _intEnergy = value; }
        }

        // Enthalpy [units: kJ/kg].
        public double Enthalpy
        {
            get { return _enthalpy; }
            set { _enthalpy = value; }
        }

        // Entropy [units: kJ/kg-K].
        public double Entropy
        {
            get { return _entropy; }
            set { _entropy = value; }
        }

        // Specific heat [units: kJ/kg-K].
        public double Cp
        {
            get { return _cp; }
            set { _cp = value; }
        }

        // Specific heat [units: kJ/kg-K].
        public double Cv
        {
            get { return _cv; }
            set { _cv = value; }
        }

        // Ratio of specific heats [-dimensionless-].
        public double Gamma
        {
            get { return _gamma; }
            set { _gamma = value; }
        }

        // Speed of sound [units: m/s].
        public double SoundSpeed
        {
            get { return _soundSpeed; }
            set { _soundSpeed = value; }
        }

        // Gas density [units: kg/m^3].
        public double Density
        {
            get { return _density; }
            set { _density = value; }
        }

        // Z, the compressibility [-dimensionless-].
        public double Compressibility
        {
            get { return _comp; }
            set { _comp = value; }
        }

        // Gibbs function [units: kJ/kg].
        public double GibbsEnergy
        {
            get { return _gibbs; }
            set { _gibbs = value; }
        }

        // Helmholtz function [units: kJ/kg].
        public double HelmholtzEnergy
        {
            get { return _helm; }
            set { _helm = value; }
        }

        // Dynamic viscosity [units: kg/m-s].
        public double DynamicViscosity
        {
            get { return _mu; }
            set { _mu = value; }
        }

        // Dynamic viscosity [units: kg/m-s].
        public double KinematicViscosity
        {
            get { return _nu; }
            set { _nu = value; }
        }

        // Thermal conductivity [units: W/m-K].
        public double ThermalConductivity
        {
            get { return _k; }
            set { _k = value; }
        }
    }
}
