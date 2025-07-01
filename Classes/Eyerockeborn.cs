using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace eyerockreborn.Classes
{
    internal class Eyerockeborn
    {
    }


    namespace EyerockRebornMod
    {
        [BepInPlugin("com.JordanMckeever.eyerockreborn", "eyerock REBORN", "1.0.0")]
        public class EyerockReborn : BaseUnityPlugin
        {
            private GameObject textObject;

            void Start()
            {
                
                textObject = new GameObject("PersistentTextObject");
                textObject.AddComponent<PersistentText>();
                DontDestroyOnLoad(textObject); 
            }
        }

        public class PersistentText : MonoBehaviour
        {
            private GUIStyle textStyle;

            void Start()
            {
                // Configure text appearance
                textStyle = new GUIStyle
                {
                    fontSize = 32,
                    fontStyle = FontStyle.Bold,
                    alignment = TextAnchor.UpperCenter
                };
                textStyle.normal.textColor = Color.red;
            }

            void OnGUI()
            {
                // Draw the text at top-center of the screen
                GUI.Label(new Rect(Screen.width / 2 - 150, 20, 300, 50), "Eyerock Reborn", textStyle);
            }
        }
    }
}