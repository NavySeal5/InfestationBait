using System;
using System.Runtime.InteropServices;
using RimWorld;
using Verse;
using System.Collections.Generic;

namespace InfestationBait{
	public class Building_InfestationBait : Building{
		
		public override void SpawnSetup(Map map, bool respawningAfterLoad){
			
			if(InfestationBaitSettings.mapDict.ContainsKey(map)){
				Log.Error("InfestationBait_Error_FoundMoreThanOneInSave".Translate());
				return;
			}
			base.SpawnSetup(map, respawningAfterLoad);
			InfestationBaitSettings.mapDict.Add(map,this);
		}
		
		public override void Destroy(DestroyMode mode = DestroyMode.Vanish){
			base.Destroy(mode);
			InfestationBaitSettings.mapDict.Remove(Find.CurrentMap);
		}
	}
}