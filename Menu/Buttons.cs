using eyerock.Classes;
using eyerock.Menu;
using eyerockreborn.Mods;
using static eyerock.Settings;

namespace eyerockreborn.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "LEAVE", method =() => Saftey.Disconnect(), toolTip = "Lobby Left", isTogglable = false},
                new ButtonInfo { buttonText = "Movement", isTogglable = false},
                new ButtonInfo { buttonText = "unsticky Plats", method =() => Platforms.PlatformsMod(), toolTip = "Use Left and right triggers to Spawn platforms", isTogglable = true},
                new ButtonInfo { buttonText = "Speedboost", method =() => SpeedBoost.speedboost(), toolTip = "speedbust", isTogglable = true},
                new ButtonInfo { buttonText = "WASD FLY", method =() => KeyflyTEMP.WASDFly(), toolTip = "Fly with the WASD keys", isTogglable = true},
                new ButtonInfo { buttonText = "Low Gravity", method =() => GravityMods.ToggleLowGravity(),toolTip = "Monkes on da Moon!", isTogglable=true},
                new ButtonInfo { buttonText = "Super Monke [A]", method =() => SuperMonke.Flymonke(), toolTip = "fly with A", isTogglable = true},
                new ButtonInfo { buttonText = "Super Monke [T]", method =() => SuperMonke.FlymonkeT(), toolTip = "Fly with your trigger", isTogglable = true},
                new ButtonInfo { buttonText = "LEAVE", method =() => Saftey.Disconnect(), toolTip = "Lobby Left", isTogglable = false},
                new ButtonInfo { buttonText = "Rig Mods", isTogglable = false},
                new ButtonInfo { buttonText = "Ghost Monke", method =() => Rig.ghost(), toolTip = "Enables ghost monke", isTogglable = true},
                new ButtonInfo { buttonText = "Hold Rig", method =() => Rig.Grabrig(), toolTip = "allows you to hold your rig", isTogglable = true},
                new ButtonInfo { buttonText = "Join Code", isTogglable = false},
                new ButtonInfo { buttonText = "Join Room MODS", method =() => JoinRoom.JoinCodeMODS(), toolTip = "Joining...", isTogglable = false},
                new ButtonInfo { buttonText = "Join Room MOD", method =() => JoinRoom.JoinCodeMOD(), toolTip = "Joining...", isTogglable = false},
                new ButtonInfo { buttonText = "Join Random Pub", method =() => JoinRoom.JoinRandom(), toolTip  = "Joining...", isTogglable =false},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
