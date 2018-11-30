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
        private decimal _exVolume;

        //constructor

        public Experiment()
        {
            _stuName = "";
            _expNumber = 0;
            _exDesc = "";
            _exWeight = 0m;
            _exColor = "";
            _exVolume = 0m;
        }
        //overloaded with student name known
        public Experiment(string stuName)
        {
            _expNumber = 0;
            _exDesc = "";
            _exWeight = 0m;
            _exColor = "";
            _stuName = stuName;
            _exVolume = 0m;
        }
        //overloaded with experiement number and experiment description known
        public Experiment(int expNumber, string expDesc)
        {
            _stuName = "";
            _exWeight = 0m;
            _exColor = "";
            _expNumber = expNumber;
            _exDesc = expDesc;
            _exVolume = 0m;
        }

        public string StuName
        {
            get { return _stuName; }
            set { _stuName = value; }
        }
        public int ExpNumber
        {
            get { return _expNumber; }
            set { _expNumber = value; }
        }
        public string ExDesc
        {
            get { return _exDesc; }
            set { _exDesc = value; }
        }
        public decimal ExWeight
        {
            get { return _exWeight; }
            set { _exWeight = value; }
        }
        public string ExColor
        {
            get { return _exColor; }
            set { _exColor = value; }
        }
        public decimal ExVolume
        {
            get { return _exVolume; }
            set { _exVolume = value; }
        }
    }
    
}
