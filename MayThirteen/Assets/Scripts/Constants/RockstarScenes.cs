using UnityEngine;
using System.Collections;
using System;

namespace Drolegames.LittleRockstar.Scenes.Constants
{

    public static class RockstarScenes
    {

        public const string Menu = "Menu";
        public const string Tutorial = "IntroScene";
        public const string Lobby = "LevelSelectionLobby";
        public const string Credits = "Credits";

        internal static bool IsGameLevel(int buildIndex)
        {
            return buildIndex > 2;
        }
    }
}

