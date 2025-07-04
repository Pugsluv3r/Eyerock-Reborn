using eyerockreborn.Menu;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


namespace eyerockreborn.Mods
{
    internal class GravityMods
    {
        public static void LowgravityV2()
        {
            
            GorillaTagger.Instance.rigidbody.AddForce(new Vector3(0, 1.7f, 0), ForceMode.Impulse);
        }
    }
}





