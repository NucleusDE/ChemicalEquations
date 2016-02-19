using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Data;

namespace Model
{
    public class ItemPack_Material
    {
        private Materials item = new Materials();

        public Materials Item
        {
            get { return item; }
            set { item = value; }
        }

        private bool isKnown = true;

        public bool IsKnown
        {
            get { return isKnown; }
            set { isKnown = value; }
        }
    }

    public class ItemPack_Condition
    {
        private Conditions item = new Conditions();

        public Conditions Item
        {
            get { return item; }
            set { item = value; }
        }

        private bool isKnown = true;

        public bool IsKnown
        {
            get { return isKnown; }
            set { isKnown = value; }
        }
    }

    public class DataPack_Input
    {
        private ArrayList reactents = new ArrayList();

        public ArrayList Reactent
        {
            get { return reactents; }
            set { reactents = value; }
        }

        private ArrayList conditions = new ArrayList();

        public ArrayList Conditions
        {
            get { return conditions; }
            set { conditions = value; }
        }
    }
}
