using UnrealBuildTool;

public class ProjectRamulusClientTarget : TargetRules
{
	public ProjectRamulusClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ProjectRamulus");
	}
}
