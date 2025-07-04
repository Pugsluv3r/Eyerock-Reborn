using GorillaLocomotion;
using Photon.Realtime;
using PlayFab.ClientModels;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;

namespace eyerockreborn.Mods
{
    internal class Advantage
    {
        public static void Questslidecontroll()
        {
            GTPlayer.Instance.slideControl = 0.23f;
        }
        public static void Betterslidecontroll()
        {
            GTPlayer.Instance.slideControl = 1f;
        }
        public static void PullMod()
        {

            GorillaTagger.Instance.rigidbody.AddForce(new Vector3(0, -1.04f, 0), ForceMode.VelocityChange);
        }
    }
}