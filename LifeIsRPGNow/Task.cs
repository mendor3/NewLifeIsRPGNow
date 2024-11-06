using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LifeIsRPGNow
{
    public class Task
    {
        private int id;
        private string name;
        private string text;
        private int xp;

        private int strength;
        private int dexterity;
        private int constitution;
        private int knowledge;
        private int mind;

        public Task(int id, string name, string text, int xp, int strength, int dexterity, int constitution, int knowledge, int mind )
        {
            this.id = id;
            this.name = name;
            this.text = text;
            this.xp = xp;

            this.strength = strength;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.knowledge = knowledge;
            this.mind = mind;
        }

        public int GetId() { return id; }
        public string GetName() { return name; }
        public string GetText() { return text; }
        public int GetXP() { return xp; }

        public int GetStrength() { return strength; }
        public int GetDexterity() {  return dexterity; }
        public int GetConstitution() { return constitution; }
        public int GetKnowledge() {  return knowledge; }
        public int Getmind() { return mind;}

    }
}
