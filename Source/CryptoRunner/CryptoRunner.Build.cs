// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CryptoRunner : ModuleRules
{
	public CryptoRunner(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
