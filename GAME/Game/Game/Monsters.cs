﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Monsters
    {
        string _name;

        double _damage;
        double _health;

        public Monsters(string name, double damage, double health)
        {
            _name = name;
           
            _damage = damage;
            _health = health;

        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
       
        public double Damage
        {
            get => _damage;
            set => _damage = value;
        }
        public double Health
        {
            get => _health;
            set => _health = value;
        }
    }
}
