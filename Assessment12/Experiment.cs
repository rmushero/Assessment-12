using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment12
{
    class Experiment
    {
        //Fields
        private string _stuName;
        private int _expNumber;
        private string _exDesc;
        private decimal _exWeight;
        private string _exColor;
        private decimal _exValue;

        //constructor

        public Experiment()
        {
            _stuName = "";
            _expNumber = 0;
            _exDesc = "";
            _exWeight = 0m;
            _exColor = "";
            _exValue = 0m;
        }
    }
    
}
