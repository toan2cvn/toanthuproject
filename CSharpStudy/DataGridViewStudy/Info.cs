using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataGridViewStudy
{
    public class Info
    {
        public int No { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public string DelBtn { set; get; }

        public Info(int no, string name, string gender, string delbtn)
        {
            this.No = no;
            this.Name = name;
            this.Gender = gender;
            this.DelBtn = delbtn;
        }
    }
}
