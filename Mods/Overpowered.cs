using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace eyerockreborn.Mods
    //Credit to GoldenTrophy & KingOfNetflix | This is not my method (:
{
    internal class Overpowered
    {
        private static float kgDebounce;

        public static void LagAll(int packets, float delay)
        {
            if (Time.time > kgDebounce)
            {
                for (int i = 0; i < packets; i++)
                    GhostReactorManager.instance.gameAgentManager.photonView.RPC("ApplyBehaviorRPC", RpcTarget.Others, new object[] { null, null });
                Throwfunc();
                kgDebounce = Time.time + delay;
            }
        }
        private static void Throwfunc()
        {
            throw new NotImplementedException();
        }
    }
}
