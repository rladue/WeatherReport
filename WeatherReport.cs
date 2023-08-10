using System.Collections.Generic;
using System;
using UnityEngine;

namespace Oxide.Plugins
{
    [Info("WeatherReport", "iLakSkiL", "0.0.1")]
    [Description("Weather Reporter.")]
    public class WeatherReport : RustPlugin
    {
        [ChatCommand("weather")]
        private void weatherReport(BasePlayer player, string command, string[] args)
        {
            if (args == null || command == null || player == null) return;
            string current = SingletonComponent<Climate>.Instance.WeatherStateTarget.name;
            string upNext = SingletonComponent<Climate>.Instance.WeatherStateNext.name;
            string currentColor = "#222222";
            string nextColor = "#888888";
            if (current == "Clear") currentColor = "#00ffff";
            if (current == "Dust") currentColor = "#ffa44a";
            if (current == "Fog") currentColor = "#757575";
            if (current == "Overcast") currentColor = "#a80b00";
            if (current == "RainHeavy") currentColor = "#00910c";
            if (current == "RainMild") currentColor = "#00e613";
            if (current == "Storm") currentColor = "#a80b00";
            if (upNext == "Clear") nextColor = "#00ffff";
            if (upNext == "Dust") nextColor = "#ffa44a";
            if (upNext == "Fog") nextColor = "#757575";
            if (upNext == "Overcast") nextColor = "#a80b00";
            if (upNext == "RainHeavy") nextColor = "#00910c";
            if (upNext == "RainMild") nextColor = "#00e613"; 
            if (upNext == "Storm") nextColor = "#a80b00";
            SendReply(player, $"<color=#0c6ccc>--BCR Weather Report--</color>\nCurrently: <color={currentColor}>{current}</color>\nUp Next: <color={nextColor}>{upNext}</color>" );
            return;
        }

    }
}