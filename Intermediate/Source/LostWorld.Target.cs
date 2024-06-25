using UnrealBuildTool;

public class LostWorldTarget : TargetRules
{
	public LostWorldTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("LostWorld");
	}
}
