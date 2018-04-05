using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotClicker
{
    class Task
    {
        public string Command { get; set; }
        public int TimeMS { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Type { get; set; }

        public Task()
        {
            Command = "";
            TimeMS = 1000;
            X = 0;
            Y = 0;
            Type = 0;
        }

        public Task(string cmd, int ms)
        {
            Command = cmd;
            TimeMS = ms;
            Type = 0;
        }

        public Task(int ms, int xx, int yy, int flag)
        {
            TimeMS = ms;
            X = xx;
            Y = yy;
            Type = flag;
        }

        public Task(string ms, string xx, string yy, int flag)
        {
            TimeMS = Convert.ToInt32(ms);
            X = Convert.ToInt32(xx);
            Y = Convert.ToInt32(yy);
            Type = flag;
        }

        public Task(string cmd, string ms)
        {
            Command = cmd;
            TimeMS = Convert.ToInt32(ms);
            Type = 0;
        }
    }
}
