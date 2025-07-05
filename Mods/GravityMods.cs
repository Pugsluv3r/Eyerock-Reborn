using eyerockreborn.Menu;
using HarmonyLib;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace eyerockreborn.Mods
{
    internal class GravityMods
    {
        public static void LowGravity()
        {
            SetGravity(1.7f);
        }

        public static void SetGravity(float value)
        {
            if (GorillaTagger.Instance != null && GorillaTagger.Instance.rigidbody != null)
            {
                GorillaTagger.Instance.rigidbody.AddForce(new Vector3(0, value, 0), ForceMode.Impulse);
            }
            else
            {
                Debug.LogWarning("GorillaTagger.Instance or its Rigidbody is null!");
            }
        }
    }
}
