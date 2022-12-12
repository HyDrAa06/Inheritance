using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string username;
        private int level;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Hero(string name, int level)
        {
            this.Username = name;
            this.Level = level;
        }
        public override string ToString()
        {
            return $"Type: {this.Username} Level: {this.Level}";
        }
    }
    public class Elf : Hero 
    {
        public Elf(string username, int level): base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }

    }

    public class MuseElf : Elf
    {
        public MuseElf(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }
    public class Wizard : Hero
    {
        public Wizard(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }

    public class DarkWizard : Wizard
    {
        public DarkWizard(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }
    public class SoulMaster : DarkWizard
    {
        public SoulMaster(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }

    public class Knight : Hero
    {
        public Knight(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }
    public class DarkKnight : Knight
    {
        public DarkKnight(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }
    public class BladeKnight : DarkKnight
    {
        public BladeKnight(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }


}
