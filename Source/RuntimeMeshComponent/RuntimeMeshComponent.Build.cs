// Copyright 2016-2018 Chris Conway (Koderz). All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class RuntimeMeshComponent : ModuleRules
{
    public RuntimeMeshComponent(ReadOnlyTargetRules rules) : base(rules)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        if (Target.Version.MinorVersion <= 19)
        {
            PublicIncludePaths.AddRange(
                new string[] {
                    "RuntimeMeshComponent/Public"
                });

            PrivateIncludePaths.AddRange(
                new string[] {
                    "RuntimeMeshComponent/Private"
                });
        }

		PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
			});

        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "CoreUObject",
                "Engine",
                "RenderCore",

                "RHI",
            });

        if (Target.Version.MinorVersion >= 22)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "NavigationSystem"
                });
        }

        if (Target.Version.MinorVersion <= 21)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "ShaderCore",
                });
        }
    }
}
