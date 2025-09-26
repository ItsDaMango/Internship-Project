using UnrealBuildTool;

public class ProjectRamulusServerTarget : TargetRules
{
	public ProjectRamulusServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ProjectRamulus");
	}
}
