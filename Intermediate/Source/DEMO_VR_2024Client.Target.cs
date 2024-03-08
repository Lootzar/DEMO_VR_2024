using UnrealBuildTool;

public class DEMO_VR_2024ClientTarget : TargetRules
{
	public DEMO_VR_2024ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("DEMO_VR_2024");
	}
}
