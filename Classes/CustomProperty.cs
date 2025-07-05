using ExitGames.Client.Photon;
using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace eyerockreborn.Classes
{
    internal class CustomProperty
    {
        public static void Eyerockcusp()
        {
            Eyerock["Eyerock Reborn 1.3.3"] = "";
            PhotonNetwork.SetPlayerCustomProperties(Eyerock);
        }
        private static ExitGames.Client.Photon.Hashtable Eyerock = PhotonNetwork.LocalPlayer.CustomProperties;
    }
}
