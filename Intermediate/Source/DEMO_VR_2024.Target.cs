using UnrealBuildTool;

public class DEMO_VR_2024Target : TargetRules
{
	public DEMO_VR_2024Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("DEMO_VR_2024");
	}
}
