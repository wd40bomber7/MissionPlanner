using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArdupilotMega
{
    public class CameraSelectorSettings
    {
        public enum Selection
        {
            Left,
            Center,
            Right,
            Cycle
        }

        public Selection selected = Selection.Left;
        public double cycleTime;
        public int channelNumber = -1;
        public bool enabled = false;
    }
}
