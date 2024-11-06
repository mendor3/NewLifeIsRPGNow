using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeIsRPGNow
{
    public class MainSkill
    {
        private int id;
        private string groupName;

        private string name;
        private string codeName;

        private int level;
        private int current_xp;

        private string picture;

        private Task[] taskArray;

        public MainSkill(int id, string groupName, string name, string codeName, int level, int current_xp, string picture)
        {
            this.id = id;
            this.groupName = groupName;
            this.name = name;
            this.codeName = codeName;
            this.level = level;
            this.current_xp = current_xp;
            this.picture = picture;
        }

        public int GetId() { return id; }
        public string GetGroupName() { return groupName; }  
        public string GetName() { return name; }
        public string GetCodeName() { return codeName; }
        public int GetLevel() { return level; }
        public int GetCurrent_xp() { return current_xp; }
        public string GetPicture() { return picture; }

    }
}
