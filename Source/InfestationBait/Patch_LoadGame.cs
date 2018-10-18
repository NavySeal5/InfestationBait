
using System;
using System.Collections.Generic;
using Harmony;
using Verse;

namespace InfestationBait
{

	[HarmonyPatch(typeof(Game))]
	[HarmonyPatch("LoadGame")]
	internal static class Patch_LoadGame
	{
		
		private static bool Prefix(){
			InfestationBaitSettings.mapDict=new Dictionary<Map,Thing>();
			return true;
		}
	}
}
