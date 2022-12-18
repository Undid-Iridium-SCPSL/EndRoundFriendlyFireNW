using System;
using System.Collections.Generic;
using GameCore;
using HarmonyLib;
using Hints;
using PlayerStatsSystem;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using Log = PluginAPI.Core.Log;

namespace EndRoundFriendlyFire
{
    public class FriendlyFire
    {
        [PluginConfig]
        public Config Config;

        [PluginEntryPoint("EndRoundFriendlyFire", "1.0.1", "Friendly fire auto enabled/disable on round ends", "Undid Iridium")]
        void LoadPlugin()
        {
            Instance = this;
            PluginAPI.Events.EventManager.RegisterEvents(this);
            Log.Debug("We have started EndRoundFriendlyFire", Config.Debug);
        }

        public FriendlyFire Instance { get; set; }

        [PluginEvent(ServerEventType.RoundEnd)]
        void onRoundEnd(RoundSummary.LeadingTeam curLeadingTeam)
        {
            Server.FriendlyFire = true;
            ConfigFile.ServerConfig.SetString("friendly_fire_multiplier", Instance.Config.OverriddenFriendlyFireMultiplier.ToString());
            Log.Debug($"Current friendly fire multiplier: { Instance.Config.OverriddenFriendlyFireMultiplier}", Instance.Config.Debug);

            List<Player> allPlayers = Player.GetPlayers();
            if (Instance.Config.FriendlyFireNotifyingType is MessageType.Hint)
            {
                foreach (Player player in allPlayers)
                {
                    player.ReceiveHint(Instance.Config.Message, 15);
                }
            }
            else
            {
                Server.Init();
              
                foreach (Player player in allPlayers)
                {
                    player.SendBroadcast(Instance.Config.Message, (ushort)Instance.Config.MessageDuration);
                }
            }
            //Reflection because.. NW
            Traverse.Create<AttackerDamageHandler>().Method("RefreshConfigs").GetValue();
            Log.Debug($"End FF server with FriendlyFire On", Instance.Config.Debug);
        }
        
        [PluginEvent(ServerEventType.RoundStart)]
        void onRoundStart()
        {
            Server.FriendlyFire = false;
            Traverse.Create<AttackerDamageHandler>().Method("RefreshConfigs").GetValue();
            Log.Debug($"Recycled server with FriendlyFire off", Instance.Config.Debug);
        }
        
    }
}