using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Model
{
    public class AllData_IN
    {
        private int nodeThis;

        public int NodeThis
        {
            get { return nodeThis; }
            set { nodeThis = value; }
        }

        private ArrayList nodeNext = new ArrayList();

        public ArrayList NodeNext
        {
            get { return nodeNext; }
            set { nodeNext = value; }
        }

        private DataPack_Input data = new DataPack_Input();

        public DataPack_Input Data
        {
            get { return data; }
            set { data = value; }
        }

        private bool isLoaded = false;

        public bool IsLoaded
        {
            get { return isLoaded; }
            set { isLoaded = value; }
        }

    }

    public class Solution_Input
    {
        private ArrayList data = new ArrayList();

        public ArrayList Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
