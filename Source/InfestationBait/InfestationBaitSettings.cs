/*
 * Created by SharpDevelop.
 * User: Tobias
 * Date: 10.09.2018
 * Time: 19:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace InfestationBait
{
	/// <summary>
	/// Description of InfestationBait.
	/// </summary>
	public class InfestationBaitSettings : ModSettings
	{
		public static int baitChance = 50;
				
		public static Dictionary<Map,Thing> mapDict = new Dictionary<Map, Thing>();
		
		public override void ExposeData(){
			Scribe_Values.Look<int>(ref InfestationBaitSettings.baitChance,"baitChance",50,false);
			
		}
		
	}
	
	
}
