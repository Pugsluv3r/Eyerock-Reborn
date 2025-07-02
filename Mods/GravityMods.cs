using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace eyerockreborn.Mods
{
    internal class GravityMods
    {
        private static bool lowGravityEnabled;
        private static bool lowGravityDisabled;

        public static void ToggleLowGravity()
        {
            lowGravityEnabled = !lowGravityEnabled;
            lowGravityDisabled = !lowGravityDisabled;

            if (lowGravityEnabled)
            {
                SetPlayerGravity(2.5f);
                Debug.Log("Low Gravity Enabled");
            }
            else (lowGravityDisabled) = true;
            
            if (lowGravityDisabled)
            {

                    SetPlayerGravity(9.81f);
                    Debug.Log("Low Gravity Disabled");
                }
            }
        

        private static void SetPlayerGravity(float gravity)
        {
            var rb = GorillaTagger.Instance?.bodyCollider?.attachedRigidbody;
            if (rb != null)
            {
                Physics.gravity = new Vector3(0, -gravity, 0);
                Debug.Log($"Set global gravity to {gravity}");
            }
        }
    }
}




