using UnrealBuildTool;

public class ColiseumChaosTarget : TargetRules
{
	public ColiseumChaosTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ColiseumChaos");
	}
}
