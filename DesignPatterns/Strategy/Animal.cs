using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Animal
    {
        private string name;        
        private string sound;
        public IFly flyingType;
        public void SetName(string newName) { name = newName; }
        public string GetName() { return name; }
        public void SetSound(string newSound) { sound = newSound; }
        public string GetSound() { return sound; }
        public string TryToFly()
        {
            return flyingType.Fly();
        }
        public void SetFlyingAbility(IFly newFlyType)
        {
            flyingType = newFlyType;
        }
    }
}
