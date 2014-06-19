using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirSpeciesProperties
{
    class QuantumMode
    {
        /******************************************************
        **                     Members                       **
        ******************************************************/

        public double partitionFunction;
        public double intEnergy;  // Internal energy [units: J/mol].
        public double enthalpy;   // Enthalpy [units: J/mol].
        public double cp;         // const. pr. specific heat [units: J/mol-K].
        public double cv;         // const. v. specific heat [units: J/mol-K].
        public double entropy;    // Entropy [units: J/mol-K].
        public double gibbs;      // Gibbs function [units: J/mol].
        public double helmholtz;  // Helmholtz function [units: J/mol].

        public static QuantumMode operator + (QuantumMode leftArg, QuantumMode rightArg)
        {
            QuantumMode output = new QuantumMode();

            output.partitionFunction = leftArg.partitionFunction + rightArg.partitionFunction;
            output.intEnergy = leftArg.intEnergy + rightArg.intEnergy;
            output.enthalpy = leftArg.enthalpy + rightArg.enthalpy;
            output.cp = leftArg.cp + rightArg.cp;
            output.cv = leftArg.cv + rightArg.cv;
            output.entropy = leftArg.entropy + rightArg.entropy;
            output.gibbs = leftArg.gibbs + rightArg.gibbs;
            output.helmholtz = leftArg.helmholtz + rightArg.helmholtz;

            return output;
        }
    }
}
