/*
 * Created by SharpDevelop.
 * User: Tobias
 * Date: 10.09.2018
 * Time: 19:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using RimWorld;
using Verse;
using System.Collections.Generic;

namespace InfestationBait
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class Building_InfestationBait : Building
	{
		
		public override void SpawnSetup(Map map, bool respawningAfterLoad)
		{
			
			
			if(InfestationBaitSettings.mapDict.ContainsKey(map))
			{
				Log.Error("InfestationBait_Error_FoundMoreThanOneInSave".Translate());
				return;
			}
			base.SpawnSetup(map, respawningAfterLoad);
			InfestationBaitSettings.mapDict.Add(map,this);
			
						
		}
		
		
		
		public override void Destroy(DestroyMode mode = DestroyMode.Vanish)
		{
			base.Destroy(mode);
			InfestationBaitSettings.mapDict.Remove(Find.CurrentMap);
		}
		

	}
}