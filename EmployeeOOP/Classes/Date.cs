using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day; // 06/05/2023

        #endregion

        #region Methods

        public Date(int day, int month, int year)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public override string ToString()
        {
            //dia/mes/año
            //var dateConcatenated1 = _day + "/" + _month + "/" + _year; //La más vieja y fea
            //var dateConcatenated2 = $"{_day}/{_month}/{_year}"; //Interpolación para no generar mucho peso de consumo de memoria con +
            return String.Format("{0}/{1}/{2}", _day, _month, _year); //Mucho mejor a la interpolación y es para concatenar String

        }

        #endregion
    }
}
