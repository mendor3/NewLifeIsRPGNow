using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LifeIsRPGNow
{
    public class SkillGroup
    {
        private int id;
        private string name;
        private string codeName;

        private int groupLevel;
        private string picture;
        private MainSkill[] mainSkillArray;

        public SkillGroup(int id, string name, string codeName, int groupLevel, string picture)
        {
            this.id = id;
            this.name = name;
            this.codeName = codeName;
            this.groupLevel = groupLevel;
            this.picture = picture;
        }

        public int GetId() { return id; }
        public string GetName() { return name; }
        public string GetCodeName(){ return codeName; }
        public int GetGroupLevel() {  return groupLevel; }
        public string GetPicture() { return picture; }

        public void SetId(int id) { this.id = id;}


    }
}
