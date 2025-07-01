using Photon.Voice.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eyerockreborn.Mods
{
    internal class SpeedBoost
    {
        public static void speedboost()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 7f;
        }
    }
}
