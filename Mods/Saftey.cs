using System;
using System.Collections.Generic;
using System.Text;

namespace eyerockreborn.Mods
{
    internal class Saftey
    {
        public static void Disconnect()
        {
           NetworkSystem.Instance.ReturnToSinglePlayer();
        }
    }
}
