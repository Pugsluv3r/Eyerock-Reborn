using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace eyerockreborn.Mods
{
    internal class Othershit
    {
        public static void Noclip()
        {
            bool NoCollide = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();

            foreach (MeshCollider collider in colliders)
            {
                collider.enabled = !NoCollide;
            }
        }
    }
}