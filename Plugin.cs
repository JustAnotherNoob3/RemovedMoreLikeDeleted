using SML;
using HarmonyLib;
using Server.Shared.State;
using Server.Shared.Info;
using Art;
using Services;
using System.Reflection;
using UnityEngine;
using Home.Common.Settings;

namespace KYS
{
    
	[Mod.SalemMod]
	class Main{
		public static void Start(){
			Debug.Log("Working?");
		}
	}
    [HarmonyPatch(typeof(SettingsController), "Start")]
	class Kill{
		public static void Prefix(SettingsController __instance){
			__instance.deleteAccountGO.SetActive(false);
	}
	}
}
