using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace Structure.Models
{
    class Product
    {
        private int _Price, _Amount, _Number;
        private float _Weight, _Capacity, _AmountAllowed, _MaxPrice;
        private string _Name;

        public float Capacity
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }

        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public float AmountAllowed
        {
            get
            {
                if ((_Capacity / _Weight) >= _Amount)
                {
                    return _Amount;
                }
                else if ((_Capacity <= 0) || (_Weight <= 0))
                {
                    return 0;
                }
                else
                {
                    return MathF.Round(_Capacity / _Weight);
                }
            }
            set { _AmountAllowed = value; }
        }

        public float MaxPrice
        {
            get
            {
                if (((_Capacity / _Weight) > _Amount) && (_Capacity > 0) && (_Weight > 0) && (_Amount > 0))
                {
                    return MathF.Round(_Amount * _Price);
                }
                else if (((_Capacity / _Weight) <= _Amount) && (_Capacity > 0) && (_Weight > 0) && (_Amount > 0))
                {
                    return MathF.Round(_Capacity / _Weight) * _Price;
                }
                else
                {
                    return 0;
                }
            }
            set { _MaxPrice = value; }
        }

        public int Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        public float Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public string Name
        {
            get { return _Name; } 
            set { _Name = value; }
        }
        public int Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
    }
}
