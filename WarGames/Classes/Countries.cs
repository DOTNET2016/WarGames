﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WarGames
{
    public abstract class Countries : IComparable<Countries>
    {
        private string _countryName;
        private int _durability;
        private int _strength;
        private int _rep;
        private float _xCoord;
        private float _yCoord;

        public int Durability
        {
            get
            {
                return _durability;
            }

            set
            {
                _durability = value;
            }
        }
        public float XCoord
        {
            get
            {
                return _xCoord;
            }

            set
            {
                _xCoord = value;
            }
        }

        public float YCoord
        {
            get
            {
                return _yCoord;
            }

            set
            {
                _yCoord = value;
            }
        }

        public Countries(string CountryName, int Durability, int Strength, int Rep, float x, float y)
        {
            _countryName = CountryName;
            _durability = Durability;
            _xCoord = x;
            _yCoord = y;
            _strength = Strength;
            _rep = Rep;
        }

        public override string ToString()
        {
            return _countryName + ": " + Durability;
        }

        public int CompareTo(Countries other)
        {
            return this.Durability.CompareTo(other.Durability);
        }
    }
}
