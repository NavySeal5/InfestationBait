/*
 * Created by SharpDevelop.
 * User: Tobias
 * Date: 10.09.2018
 * Time: 21:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using RimWorld;
using Verse;

namespace InfestationBait
{
	/// <summary>
	/// Description of PlaceWorker_InfestationBait.
	/// </summary>
	public class PlaceWorker_InfestationBait : PlaceWorker
	{
		
		public override  AcceptanceReport AllowsPlacing(BuildableDef checkDef,IntVec3 loc,Rot4 rot,Map map, Thing thingtoIgnore = null){
			
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
