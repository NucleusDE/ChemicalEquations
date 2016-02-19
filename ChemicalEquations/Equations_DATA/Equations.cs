using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Data;
using Model;

namespace Equations_DATA
{
    public class DefaultEquations
    {
        static private ArrayList allEquations = new ArrayList();

        static public ArrayList AllEquations
        {
            get { return allEquations; }
            set { allEquations = value; }
        }

        static public void AddIntoRquationsList()
        {
            Equation equ = new Equation();
            equ.Reactants.Add(Materials.KMnO4);
            equ.Conditions.Add(Conditions.Heating);
            equ.Prodcts.Add(Materials.K2MnO4);
            equ.Prodcts.Add(Materials.MnO2);
            equ.Prodcts.Add(Materials.O2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.KClO3);
            equ.Conditions.Add(Conditions.MnO2);
            equ.Conditions.Add(Conditions.Heating);
            equ.Prodcts.Add(Materials.KCl);
            equ.Prodcts.Add(Materials.O2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.H2O2);
            equ.Conditions.Add(Conditions.MnO2);
            equ.Prodcts.Add(Materials.H2O);
            equ.Prodcts.Add(Materials.O2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.HCl);
            equ.Reactants.Add(Materials.CaCO3);
            equ.Prodcts.Add(Materials.CaCl2);
            equ.Prodcts.Add(Materials.H2O);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.Zn);
            equ.Reactants.Add(Materials.CaCO3);
            equ.Prodcts.Add(Materials.ZnSO4);
            equ.Prodcts.Add(Materials.H2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.P);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.P2O5);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.Mg);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.MgO);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.C);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.S);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.SO2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.Fe);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.Fe3O4);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.CO);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.C);
            equ.Reactants.Add(Materials.CO2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.CO);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.C);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.O2);
            equ.Prodcts.Add(Materials.CO);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.H2);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.H2O);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.C2H5OH);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.CO2);
            equ.Reactants.Add(Materials.H2O);
            AllEquations.Add(equ);


            equ = new Equation();
            equ.Reactants.Add(Materials.CH4);
            equ.Reactants.Add(Materials.O2);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.CO2);
            equ.Prodcts.Add(Materials.H2O);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.H2);
            equ.Reactants.Add(Materials.C);
            equ.Conditions.Add(Conditions.FireLighting);
            equ.Prodcts.Add(Materials.HCl);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.C);
            equ.Reactants.Add(Materials.CuO);
            equ.Conditions.Add(Conditions.HighTempature);
            equ.Prodcts.Add(Materials.Cu);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.C);
            equ.Reactants.Add(Materials.Fe2O3);
            equ.Conditions.Add(Conditions.HighTempature);
            equ.Prodcts.Add(Materials.Fe);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.CO);
            equ.Reactants.Add(Materials.CuO);
            equ.Conditions.Add(Conditions.Heating);
            equ.Prodcts.Add(Materials.Cu);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.CO);
            equ.Reactants.Add(Materials.Fe2O3);
            equ.Conditions.Add(Conditions.HighTempature);
            equ.Prodcts.Add(Materials.Fe);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);


            equ = new Equation();
            equ.Reactants.Add(Materials.H2);
            equ.Reactants.Add(Materials.CuO);
            equ.Conditions.Add(Conditions.Heating);
            equ.Prodcts.Add(Materials.Cu);
            equ.Prodcts.Add(Materials.H2O);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.CaCO3);
            equ.Conditions.Add(Conditions.HighTempature);
            equ.Prodcts.Add(Materials.CaO);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);


            equ = new Equation();
            equ.Reactants.Add(Materials.H2O);
            equ.Reactants.Add(Materials.CO2);
            equ.Prodcts.Add(Materials.H2CO3);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.H2CO3);
            equ.Prodcts.Add(Materials.H2O);
            equ.Prodcts.Add(Materials.CO2);
            AllEquations.Add(equ);

            equ = new Equation();
            equ.Reactants.Add(Materials.Ca_OH_2);
            equ.Reactants.Add(Materials.CO2);
            equ.Prodcts.Add(Materials.CaCO3);
            equ.Prodcts.Add(Materials.H2O);
            AllEquations.Add(equ);
        }
    }
}
