using System;
using RimWorld;
using Verse;

namespace InfestationBait{
	public class PlaceWorker_InfestationBait : PlaceWorker{
		
		public override  AcceptanceReport AllowsPlacing(BuildableDef checkDef,IntVec3 loc,Rot4 rot,Map map, Thing thingtoIgnore = null,Thing thing = null){
			
			if(InfestationBaitSettings.mapDict==null){
				Log.Error("Error:Bait Dictionary was not initialized!");
				return new AcceptanceReport("InfestationBait_AcceptanceReportFailed_notInitialized".Translate());
			}
			
			if(!loc.Roofed(map) || !loc.GetRoof(map).isThickRoof){
				return new AcceptanceReport("InfestationBait_AcceptanceReportFailed_Roof".Translate());
			}
			
			if(InfestationBaitSettings.mapDict.ContainsKey(map)){
				return new AcceptanceReport("InfestationBait_AcceptanceReportFailed_exist".Translate());
			}
			
			return AcceptanceReport.WasAccepted;
		}
	}
}