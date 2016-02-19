using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Model
{
    public class SolutionSet_Output
    {
        private ArrayList solutionSets = new ArrayList();

        public ArrayList SolutionSets
        {
            get { return solutionSets; }
            set { solutionSets = value; }
        }
    }

    public class Solution_Output
    {
        private ArrayList solutions = new ArrayList();

        public ArrayList Solutions
        {
            get { return solutions; }
            set { solutions = value; }
        }
    }

    public class Equation
    {
        private ArrayList reactants = new ArrayList();

        public ArrayList Reactants
        {
            get { return reactants; }
            set { reactants = value; }
        }

        private ArrayList products = new ArrayList();

        public ArrayList Prodcts
        {
            get { return products; }
            set { products = value; }
        }

        private ArrayList conditions = new ArrayList();

        public ArrayList Conditions
        {
            get { return conditions; }
            set { conditions = value; }
        }

        public int nodeNUM;

        public int NodeNUM
        {
            get { return nodeNUM; }
            set { nodeNUM = value; }
        }
    }


}
