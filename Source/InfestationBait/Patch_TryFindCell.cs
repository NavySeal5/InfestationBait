/*
 * Created by SharpDevelop.
 * User: Tobias
 * Date: 11.09.2018
 * Time: 16:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Harmony;
using RimWorld;
using Verse;

namespace InfestationBait
{
	/// <summary>
	/// Description of Patch_IncidentWorker_Infestation_TryFindCell.
	/// </summary>
	/// 
	[HarmonyPatch(typeof(InfestationCellFinder))]
	[HarmonyPatch("TryFindCell")]
	internal static class Patch_TryFindCell
	{
		private static void Postfix(bool __result,ref IntVec3 cell,Map map)
		{
			if(__result)
			{
				bool flag  = Verse.Rand.Chance((float)InfestationBaitSettings.baitChance/100f);
				bool flag2 = InfestationBaitSettings.mapDict.ContainsKey(map);

				if(flag && flag2)
				{
					var building = InfestationBaitSettings.mapDict[map];
					cell = building.Position;
					
				}
			}			
		}
	}
}
