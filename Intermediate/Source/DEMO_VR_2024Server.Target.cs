using UnrealBuildTool;

public class DEMO_VR_2024ServerTarget : TargetRules
{
	public DEMO_VR_2024ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("DEMO_VR_2024");
	}
}
