using eyerockreborn.Classes;
using eyerockreborn.Menu;
using eyerockreborn.Mods;
using static eyerockreborn.Settings;

namespace eyerockreborn.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "LEAVE", method =() => Safety.Disconnect(), toolTip = "Lobby Left", isTogglable = false},
                new ButtonInfo { buttonText = "Movement", isTogglable = false},
                new ButtonInfo { buttonText = "unsticky Plats", method =() => Platforms.PlatformsMod(), toolTip = "Use Left and right triggers to Spawn platforms", isTogglable = true},
                new ButtonInfo { buttonText = "Speedboost", method =() => SpeedBoost.speedboost(), toolTip = "Gives Player a slight speedboost", isTogglable = true},
                new ButtonInfo { buttonText = "WASD FLY", method =() => KeyflyTEMP.WASDFly(), toolTip = "Fly with the WASD keys", isTogglable = true},
                new ButtonInfo { buttonText = "Low Gravity", method =() => GravityMods.LowgravityV2(),toolTip = "Monkes on da Moon!", isTogglable=true},
                new ButtonInfo { buttonText = "Super Monke [A]", method =() => SuperMonke.Flymonke(), toolTip = "fly with A", isTogglable = true},
                new ButtonInfo { buttonText = "Super Monke [T]", method =() => SuperMonke.FlymonkeT(), toolTip = "Fly with your trigger", isTogglable = true},
                new ButtonInfo { buttonText = "LEAVE", method =() => Safety.Disconnect(), toolTip = "Lobby Left", isTogglable = false},
                new ButtonInfo { buttonText = "Rig Mods", isTogglable = false},
                new ButtonInfo { buttonText = "Ghost Monke [T]", method =() => Rig.ghost(), toolTip = "Enables ghost monke", isTogglable = true},
                new ButtonInfo { buttonText = "Hold Rig", method =() => Rig.Grabrig(), toolTip = "allows you to hold your rig", isTogglable = true},
                new ButtonInfo { buttonText = "Join Code", isTogglable = false},
                new ButtonInfo { buttonText = "Join Room MODS", method =() => JoinRoom.JoinCodeMODS(), toolTip = "Joins Room on click!", isTogglable = false},
                new ButtonInfo { buttonText = "Join Room MOD", method =() => JoinRoom.JoinCodeMOD(), toolTip = "Joins Room on click!", isTogglable = false},
                new ButtonInfo { buttonText = "Join Random Pub", method =() => JoinRoom.JoinRandom(), toolTip  = "Joins Room on click!", isTogglable =false},
                new ButtonInfo { buttonText = "LEAVE", method =() => Safety.Disconnect(), toolTip = "Lobby Left", isTogglable = false},
                new ButtonInfo { buttonText = "Safety", isTogglable = false},
                new ButtonInfo { buttonText = "Tp to stump", method =() => Safety.ReturnTostump(), toolTip = "teloports you to stump when clicked", isTogglable = false},
                new ButtonInfo { buttonText = "AntiReport [DC]", method =() => Safety.AntiReport(), toolTip = "Disconnects you when someone attempts to report you", isTogglable = true},
                new ButtonInfo { buttonText = "Fake Quest Menu [X]", method =() => Safety.QuestMenu(), toolTip = "press A to activate fake quest menu", isTogglable = true},
                new ButtonInfo { buttonText = "Advantage", isTogglable = false},
                new ButtonInfo { buttonText = "Quest slide control", method =() => Advantage.Questslidecontroll(), toolTip = "Gives you quest slide control", isTogglable = true},
                new ButtonInfo { buttonText = "Better slide control", method =() => Advantage.Betterslidecontroll(), toolTip = "Gives you Better slide control", isTogglable = true},
                new ButtonInfo { buttonText = "LEAVE", method =() => Safety.Disconnect(), toolTip = "Lobby Left", isTogglable = false},
                new ButtonInfo { buttonText = "Pull Mod", method =() => Advantage.PullMod(), toolTip = "Pulls you to the ground", isTogglable = true},
                new ButtonInfo { buttonText = "Other", isTogglable = false},
                new ButtonInfo { buttonText = "NoClip [T]", method =() => Othershit.Noclip(), toolTip = "disables all collides", isTogglable = true},
                new ButtonInfo { buttonText = "TP to City", method =() => Othershit.Tptocityload(), toolTip = "TPs you to city on click", isTogglable = false},
                new ButtonInfo { buttonText = "TP to Beach", method =() => Othershit.Tptobeachload(), toolTip = "TPs you to beach on click", isTogglable = false},


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
