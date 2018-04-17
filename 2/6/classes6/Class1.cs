﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes6
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public Converter(double _usd, double _eur, double _rub)
        {
            usd = _usd;
            eur = _eur;
            rub = _rub;
        }
        public double ConvertCurrency(double currency, int action)
        {
            switch (action)
            {
                case 1:
                    return currency / usd;
                case 2:
                    return currency / eur;
                case 3:
                    return currency / rub;
                case 4:
                    return currency * usd;
                case 5:
                    return currency * eur;
                case 6:
                    return currency * rub;
                default:
                    return currency;
            }
        }
    }
}
