using UnrealBuildTool;

public class ProjectRamulusTarget : TargetRules
{
	public ProjectRamulusTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectRamulus");
	}
}
