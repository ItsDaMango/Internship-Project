using UnrealBuildTool;

public class ProjectRamulusEditorTarget : TargetRules
{
	public ProjectRamulusEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ProjectRamulus");
	}
}
