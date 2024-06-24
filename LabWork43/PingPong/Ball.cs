using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace PingPong
{
    internal class Ball
    {
        public int x { get; set; }
        public int y { get; set; }
        public int speedX { get; set; }
        public int speedY { get; set; }

        void Move()
        {
            DispatcherTimer timerMove = new DispatcherTimer(DispatcherPriority.Render);
        }
    }
}
