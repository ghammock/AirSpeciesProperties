using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirSpeciesProperties
{
    class Species
    {
        /******************************************************
        **                 C# Properties                     **
        ******************************************************/

        /// <summary>
        /// The name of the species.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// The molecular formula of the species.
        /// </summary>
        public string Formula
        {
            get { return _formula; }
            set { _formula = value; }
        }

        /// <summary>
        /// The temperature of the species [units: K].
        /// </summary>
        public double Temperature
        {
            get { return _temp; }
            set { _temp = value; }
        }

        /// <summary>
        /// The partial pressure of the species [units: Pa].
        /// </summary>
        public double Pressure
        {
            get { return _press; }
            set { _press = value; }
        }

        /// <summary>
        /// The molecular weight of the particle/molecule.
        /// </summary>
        public double MolecularWeight
        {
            get { return _molWeight; }
            set { _molWeight = value; }
        }

        /// <summary>
        /// The mass of the particle/molecule [units: kg].
        /// </summary>
        public double Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        /// <summary>
        /// The radius of the particle if it's modelled as a sphere [units: m].
        /// </summary>
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        /// <summary>
        /// The moment of inertia I = ur^2 [units: kg-m^2].
        /// </summary>
        public double MomentOfInertia
        {
            get { return _momInertia; }
            set { _momInertia = value; }
        }

        /// <summary>
        /// The wave number of the molecule [units: 1/m].
        /// </summary>
        public double WaveNumber
        {
            get { return _waveNumber; }
        }

        /// <summary>
        /// The vibrational freq. of the molecule [units: Hz].
        /// </summary>
        public double Frequency
        {
            get { return _freq; }
        }

        /// <summary>
        /// The enthalpy of formation [units: J/mol].
        /// </summary>
        public double FormationEnthalpy
        {
            get { return _enthForm; }
        }

        /// <summary>
        /// A flag to set for monatomic particles.
        /// <para>True for monatomic particles (e.g. N).</para>
        /// <para>False for polyatomic molecules (e.g. NO, N2, etc.).</para>
        /// </summary>
        public bool IsMonatomic
        {
            get { return _isMonatomic; }
            set { _isMonatomic = value; }
        }

        /// <summary>
        /// A flag to set for symmetric molecules (not useful for monatomic molecules).
        /// <para>True for symmetric molecules (e.g. N2)</para>
        /// <para>False for non-symmetric molecules (e.g. NO).</para>
        /// </summary>
        public bool IsSymmetric
        {
            get { return _isSymmetric; }
            set { _isSymmetric = value; }
        }

        /// <summary>
        /// The electronic levels (epsilon[i]) of a given species.
        /// </summary>
        public List<double> ElectronicLevel
        {
            get { return _elecLevel; }
        }

        /// <summary>
        /// The degeneracies (g[i]) of a given species.
        /// </summary>
        public List<double> ElectronicMult
        {
            get { return _elecMult; }
        }

        /// <summary>
        /// The zero-point energy of the species [units: J].
        /// </summary>
        public double ZeroPointEnergy
        {
            get { return _zpEnergy; }
            set { _zpEnergy = value; }
        }

        /// <summary>
        /// The energy of dissociation [units: J].
        /// </summary>
        public double DissociationEnergy
        {
            get { return _dissEnergy; }
        }

        /******************************************************
        **                Class Constants                    **
        ******************************************************/
        public const double Na = 6.02214129E23;  // Avagadro's constant [units: 1/mol].
        public const double k  = 1.3806488E-23;  // Boltzmann's constant [units: J/K].
        public const double h  = 6.62606957E-34; // Plank's constant [units: J-s].
        public const double pi = 3.141592653589; // ratio of circle's circumference to diameter.
        public const double c  = 2.997925E8;     // Speed of light in vacuum [units: m/s].
        public const double R_bar = k * Na;      // Universal gas constant [units: J/mol-K].

        /******************************************************
        **                      Members                      **
        ******************************************************/
        private string _name;     // The name of the species.
        private string _formula;  // The molecular formula of the species.

        private double _temp;  // The input temperature [units: K].
        private double _press; // The input pressure [units: Pa].

        private double _molWeight;   // The molecular weight of the particle.
        private double _mass;        // The mass of the particle [units: kg].
        private double _radius;      // The "radius" of the particle assuming a sphere [units: m].
        private double _momInertia;  // The moment of inertia I = ur^2 [units: kg-m^2].
        private double _waveNumber;  // The wave number of the molecule [units: 1/m].
        private double _freq;        // The vibrational freq. of the molecule [units: Hz].
        private double _enthForm;    // The enthalpy of formation [units: J/mol].

        private bool _isMonatomic; // True for monatomic particles (e.g. N).
                                   // False for polyatomic molecules (e.g. NO, N2, etc.).

        private bool _isSymmetric; // True for symmetric molecules (e.g. N2).
                                   // False for non-symmetric molecules (e.g. NO).

        private List<double> _elecLevel = new List<double>();  // The electronic levels (epsilon[i]).
        private List<double> _elecMult = new List<double>();   // The degeneracies (g[i]).

        private double _zpEnergy;    // Zero-point energy [units: J].
        private double _dissEnergy;  // The energy of dissociation [units: J].

        /// <summary>
        /// Add and electronic state to the species.
        /// </summary>
        /// <param name="electronicLevel">The electronic level, epsilon, to be added
        /// to the state [units: 1/m].</param>
        /// <param name="degeneracy">The electronic multiplier (degeneracy)
        /// to be added to the state.</param>
        public void AddElectronicState(double electronicLevel, double degeneracy)
        {
            const double lengthConst = h * c / k;  // units: m.

            // The epsilon values that are typically given in tables are
            // actually:
            //            eps / (h * c), having units of 1 / length.
            //
            // This converts those values to a dimensionless constant for later use.

            _elecLevel.Add(electronicLevel * lengthConst);
            _elecMult.Add(degeneracy);
        }

        /// <summary>
        /// Set the wave number (omegaE) of the molecule [units: 1/m].
        /// </summary>
        /// <param name="omegaE">The wave number of the molecule [units: 1/m].</param>
        public void setWaveNumber (double omegaE)
        {
            _waveNumber = omegaE;  // units: 1/m.
            _freq  = omegaE * c;   // units: Hz.

            // Calculate the zero-point energy [units: J].
            _zpEnergy   = h * c * _waveNumber / 2.0;
        }

        /// <summary>
        /// Store the dissociation energy [units: J].
        /// </summary>
        /// <param name="dissociationEnergy">The dissociation energy of the molecule.</param>
        public void setDissociationEnergy(double dissociationEnergy)
        {
            _dissEnergy = dissociationEnergy;
            _enthForm = -1.0 * Na * _dissEnergy;
        }

        /// <summary>
        /// Store the enthalpy of formation [units: J/mol].
        /// </summary>
        /// <param name="enthalpyOfFormation">The value of h[f] to store.</param>
        public void setEnthalpyOfFormation (double enthalpyOfFormation)
        {
            _enthForm = enthalpyOfFormation;
            _dissEnergy = -1.0 * _enthForm / Na;
        }

        /// <summary>
        /// Set the vibrational frequency of the molecule [units: Hz].
        /// </summary>
        /// <param name="frequency">The vibrational frequency of the molecule [units: Hz].</param>
        public void setVibrationalFrequency (double frequency)
        {
            _waveNumber = frequency / c;  // units: 1/m.
            _freq  = frequency;           // units: Hz.

            // Calculate the zero-point energy [units: J].
            _zpEnergy   = h * c * _waveNumber / 2.0;
        }

        /// <summary>
        /// Calculate the thermodynamic properties of the species given the temperature and pressure.
        /// </summary>
        /// <param name="temperature">The temperature of the species in K.</param>
        /// <param name="pressure">The partial pressure of the species in MPa.</param>
        public ThermoProps calculateProperties(double temperature, double pressure)
        {
            ThermoProps output = new ThermoProps();

            Temperature = temperature;
            Pressure = pressure;

            QuantumMode sumModes = new QuantumMode();
            QuantumMode trans = _calculateTranlation();
            QuantumMode rot = _calculateRotation();
            QuantumMode vib = _calculateVibration();
            QuantumMode elec = _calculateElectrical();

            double cv_trans = trans.cv;
            double cv_rot = rot.cv;
            double cv_vib = vib.cv;
            double cv_elec = elec.cv;

            sumModes = _calculateTranlation() + _calculateRotation() + _calculateVibration()
                      + _calculateElectrical();

            output.Temperature = temperature;         // units: K
            output.Pressure = pressure;            // units: MPa
            output.MolecularWeight = _molWeight;          // units: kg/kmol
            output.GasConstant = R_bar / _molWeight;  // units: kJ/kg-K

            output.InternalEnergy = sumModes.intEnergy / _molWeight;  // units: kJ/kg.
            output.Enthalpy = sumModes.enthalpy / _molWeight;  // units: kJ/kg.
            output.Entropy = sumModes.entropy / _molWeight;  // units: kJ/kg-K.

            output.Cp = sumModes.cp / _molWeight;  // units: kJ/kg-K.
            output.Cv = sumModes.cv / _molWeight;  // units: kJ/kg-K.
            output.Gamma = sumModes.cp / sumModes.cv;    // -dimensionless-

            // Calculate the speed of sound of the gas [units: m/s].
            // 1000.0, convert kJ -> J.
            output.SoundSpeed = Math.Sqrt(output.Gamma * output.GasConstant
                                     * 1000.0 * output.Temperature);

            // Calculate the gas density [units: kg/m^3].
            //    Using:
            //
            //        h = u + (P/rho)
            //
            // 1000.0, convert MPa -> kPa.
            output.Density = (output.Pressure * 1000.0)
                             / (output.Enthalpy - output.InternalEnergy);

            // Calculate the compressibility factor [-dimensionless-].
            //    Using:
            //
            //        P = Z(rho)RT
            //
            // 1000.0, convert MPa -> kPa.
            output.Compressibility = (output.Pressure * 1000.0)
                / (output.Density * output.GasConstant * output.Temperature);

            output.GibbsEnergy = sumModes.gibbs / _molWeight;     // units: kJ/kg.
            output.HelmholtzEnergy = sumModes.helmholtz / _molWeight; // units: kJ/kg.

            output.DynamicViscosity = (2.0 / (3.0 * Math.PI * Math.Pow((2.0 * _radius), 2.0)))
                                     * Math.Sqrt(_mass * k * _temp / Math.PI);

            output.KinematicViscosity = output.DynamicViscosity / output.Density;

            output.ThermalConductivity = output.DynamicViscosity * ((2.5 * cv_trans)
                                         + cv_rot + cv_vib + cv_elec);

            return output;
        }

        /// <summary>
        /// Calculate the reduced mass of a diatomic species for calculating the moment of inertia.
        /// </summary>
        /// <param name="molWeight_1">The molecular weight of the first atom.</param>
        /// <param name="molWeight_2">The molecular weight of the second atom.</param>
        /// <returns></returns>
        public static double calculateReducedMass(double molWeight_1, double molWeight_2)
        {
            double reducedMass;

            // The reduced mass is defined as:
            //
            //                    massA * massB
            //    reducedMass =  ---------------
            //                   (massA + massB)
            //
            // When mass = molWeight / Na, this reduces to:
            reducedMass = (molWeight_1 * molWeight_2)
                          / (Na * (molWeight_1 + molWeight_2));

            // Convert the mass from g -> kg.
            reducedMass /= 1000.0;

            return reducedMass;
        }

        /// <summary>
        /// Calculate the mass of the particle given a molar mass [units: kg].
        /// </summary>
        public void calculateMass()
        {
            if (_molWeight == 0)
                return;

            // 1000.0 = convert g -> kg.
            else
                _mass = _molWeight / (1000.0 * Na);
        }

        /// <summary>
        /// Calculates the translational energy component of to the species thermodynamic properties.
        /// </summary>
        /// <returns>A QuantumMode object that contains the calculated contributions.</returns>
        private QuantumMode _calculateTranlation ()
        {
            QuantumMode translation = new QuantumMode();

            /**********************************
            **    Translational Energy       **
            **********************************/

            // 1000.0 = convert g -> kg.
            // 1E6 = convert MPa -> Pa.
            translation.partitionFunction =  Math.Pow((2.0 * pi) / (Na * Math.Pow(h, 2.0)), 1.5)
                                           * Math.Pow(_molWeight / 1000.0, 1.5)
                                           * Math.Pow((k * _temp), 2.5)
                                           / (_press * 1E6);

            // Calculate the molecular translational contributions
            // to the thermodynamic properties.
            translation.intEnergy = (3.0 / 2.0) * R_bar * _temp;
            translation.enthalpy  = (5.0 / 2.0) * R_bar * _temp;
            translation.cv        = (3.0 / 2.0) * R_bar;
            translation.cp        = (5.0 / 2.0) * R_bar;
            translation.entropy   = R_bar * (Math.Log(translation.partitionFunction) + 2.5);
            translation.gibbs     = -R_bar * _temp * Math.Log(translation.partitionFunction);
            translation.helmholtz =  -R_bar * _temp
                                   * (Math.Log(translation.partitionFunction) + 1.0);

            return translation;
        }  // End method _calculateTranslation().

        /// <summary>
        /// Calculates the rotational energy component to the species thermodynamic properties.
        /// </summary>
        /// <returns>A QuantumMode object containing the calculated contributions.</returns>
        private QuantumMode _calculateRotation()
        {
            QuantumMode rotation = new QuantumMode();

            /**********************************
            **       Rotational Energy       **
            **********************************/

            double rotTemp;  // The characteristic rotational temperature [units: K].

            if (!(IsMonatomic))
            {
                // Calculate the characteristic rotational temperature [units: K].
                rotTemp = Math.Pow(h, 2.0) / (8.0 * Math.Pow(pi, 2.0) * _momInertia * k);

                // Calculate the value of the partition function [-dimensionless-].
                rotation.partitionFunction = _temp / rotTemp;

                // Account for the symmetry number.
                //    sigma = 1 for heteronuclear molecules (not symmetric).
                //    sigma = 2 for homonuclear molecules (symmetric).
                if (IsSymmetric)
                    rotation.partitionFunction /= 2.0;

                // Now calculate the molecular rotational contributions
                // to the thermodynamic properties.
                rotation.intEnergy = R_bar * _temp;
                rotation.enthalpy = R_bar * _temp;
                rotation.cv = R_bar;
                rotation.cp = R_bar;
                rotation.entropy = R_bar * (Math.Log(rotation.partitionFunction) + 1.0);
                rotation.gibbs = -R_bar * _temp * Math.Log(rotation.partitionFunction);
                rotation.helmholtz = rotation.gibbs;
            }
            else
            {
                rotation.partitionFunction = 0.0;
                rotation.intEnergy = 0.0;  // Internal energy [units: J/mol].
                rotation.enthalpy = 0.0;  // Enthalpy [units: J/mol].
                rotation.cv = 0.0;  // Specific heat [units: J/mol-K].
                rotation.cp = 0.0;  // Specific heat [units: J/mol-K].
                rotation.entropy = 0.0;  // Entropy [units: J/mol-K].
                rotation.gibbs = 0.0;  // Gibbs function [units: J/mol].
                rotation.helmholtz = 0.0;  // Helmholtz function [units: J/mol].
            }

            return rotation;
        }  // End method _calculateRotation().

        /// <summary>
        /// Calculates the vibrational component to the species thermodynamic properties.
        /// </summary>
        /// <returns>A QuantumMode object that contains the calculated contributions.</returns>
        private QuantumMode _calculateVibration()
        {
            QuantumMode vibration = new QuantumMode();

            /**********************************
            **      Vibrational Energy       **
            **********************************/

            double vibTemp;  // The characteristic vibrational temperature [units: K].
            double x;        // x = vibTemp / temperature [-dimensionless-].

            // Molal ground state energy [units: J/kmol-K].
            double uv0 = Na * _zpEnergy;

            if (!(IsMonatomic))
            {
                // Calculate the characteristic vibrational temperature [units: K].
                vibTemp = h * c * _waveNumber / k;
                x = vibTemp / _temp;

                // Calculate the value of the partition function [-dimensionless-].
                vibration.partitionFunction = 1.0 / (1.0 - Math.Exp(-x));

                // Now calculate the molecular vibrational contributions
                // to the thermodynamic properties.
                vibration.intEnergy = R_bar * _temp * x / (Math.Exp(x) - 1.0);
                vibration.enthalpy = vibration.intEnergy;
                vibration.cv = R_bar * (Math.Pow(x, 2.0) * Math.Exp(x)) / Math.Pow((Math.Exp(x) - 1.0), 2.0);
                vibration.cp = vibration.cv;
                vibration.entropy = R_bar * ((-1.0 * Math.Log(1.0 - Math.Exp(-x)))
                                          + (x / (Math.Exp(x) - 1.0)));
                vibration.gibbs = R_bar * _temp * Math.Log(1 - Math.Exp(-x));
                vibration.helmholtz = vibration.gibbs;
            }
            else
            {
                vibration.partitionFunction = 0.0;
                vibration.intEnergy = 0.0;  // Internal energy [units: J/mol].
                vibration.enthalpy = 0.0;  // Enthalpy [units: J/mol].
                vibration.cv = 0.0;  // Specific heat [units: J/mol-K].
                vibration.cp = 0.0;  // Specific heat [units: J/mol-K].
                vibration.entropy = 0.0;  // Entropy [units: J/mol-K].
                vibration.gibbs = 0.0;  // Gibbs function [units: J/mol].
                vibration.helmholtz = 0.0;  // Helmholtz function [units: J/mol].
            }

            return vibration;
        }

        /// <summary>
        /// Calculates the electrical component to the species thermodynamic properties.
        /// </summary>
        /// <returns>A QuantumMode object that contains the calculated contributions.</returns>
        private QuantumMode _calculateElectrical()
        {
            QuantumMode electrical = new QuantumMode();

            /**********************************
            **      Electrical Energy        **
            **********************************/
            double eps;
            double g;

            double [] term = new double[2];
            double z_prime = 0.0;      // 1st-derivative of the partition function.
            double z_doublePrime = 0.0; // 2nd-derivative of the partition function.

            if (IsMonatomic)
            {
                // Initialize the partition function value
                // to zero for the summation.
                electrical.partitionFunction = 0.0;

                // We sum the given energy state values to
                // determine the electical partition function.
                for (int i = 0; i < _elecMult.Count; ++i)
                {
                    eps = _elecLevel.ElementAt(i);
                    g = _elecMult.ElementAt(i);

                    term[0] = eps / (k * Temperature);
                    term[1] = Math.Exp(-term[0]);

                    electrical.partitionFunction += (g * term[1]);

                    // The first and second derivatives of the partition function.
                    z_prime += (g * term[0] * term[1]);
                    z_doublePrime += (g * Math.Pow(term[0], 2.0) * term[1]);
                }

                z_doublePrime -= z_prime;

                // Now that we've calculated the value of the partition function
                // (and it's derivatives), we calculate the internal electrical
                // contributions to the thermodynamic properties.
                electrical.intEnergy = R_bar * Temperature * z_prime
                                  / electrical.partitionFunction;

                electrical.enthalpy = electrical.intEnergy;

                electrical.cv = R_bar * ( ( (z_doublePrime + z_prime)
                                                / electrical.partitionFunction)
                                 - Math.Pow((z_prime / electrical.partitionFunction), 2.0) );

                electrical.cp = electrical.cv;

                electrical.entropy =  R_bar * (Math.Log(electrical.partitionFunction)
                                 + (z_prime / electrical.partitionFunction));

                electrical.gibbs = -R_bar * Temperature * Math.Log(electrical.partitionFunction);

                electrical.helmholtz = electrical.gibbs;
            }
            else
            {
                electrical.partitionFunction = 1.0;  // Let the ground-energy state be 1.
                electrical.intEnergy         = 0.0;  // Internal energy [units: J/mol].
                electrical.enthalpy          = 0.0;  // Enthalpy [units: J/mol].
                electrical.cv                = 0.0;  // Specific heat [units: J/mol-K].
                electrical.cp                = 0.0;  // Specific heat [units: J/mol-K].
                electrical.entropy           = 0.0;  // Entropy [units: J/mol-K].
                electrical.gibbs             = 0.0;  // Gibbs function [units: J/mol].
                electrical.helmholtz         = 0.0;  // Helmholtz function [units: J/mol].
            }

            return electrical;
        }
    }
}
