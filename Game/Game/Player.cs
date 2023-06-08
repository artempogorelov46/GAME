using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player
    {
        string _name;
        int _level;
        double _damage;
        double _health;
       
        

        public Player(string name,int level, double damage, double health)
        {
            _name = name;
            _level = level;
            _damage = damage;
            _health = health;
            
        }
        public string Name 
        {
            get => _name;
            set => _name = value; 
        }
        public int Level 
        { 
            get => _level; 
            set => _level = value; 
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
