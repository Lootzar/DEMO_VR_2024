using UnrealBuildTool;

public class DEMO_VR_2024EditorTarget : TargetRules
{
	public DEMO_VR_2024EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("DEMO_VR_2024");
	}
}
