using System;
using HarmonyLib;
using RimWorld;
using Verse;


namespace InfestationBait
{

	//[HarmonyPatch()]
	//[HarmonyPatch("TryFindCell")]
	public class Patch_VFEI
	{
		public static void Postfix(bool __result, ref IntVec3 cell, Map map)
		{
			if (__result)
			{
				bool isBaitApplied = Verse.Rand.Chance((float)InfestationBaitSettings.baitChance / 100f);
				bool mapHasBait = InfestationBaitSettings.mapDict.ContainsKey(map);

				if (isBaitApplied && mapHasBait)
				{
					var building = InfestationBaitSettings.mapDict[map];
					cell = building.Position;

				}
			}
		}
	}
}