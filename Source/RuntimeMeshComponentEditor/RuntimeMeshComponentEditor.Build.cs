// Copyright 2016-2018 Chris Conway (Koderz). All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class RuntimeMeshComponentEditor : ModuleRules
{
    public RuntimeMeshComponentEditor(ReadOnlyTargetRules rules) : base(rules)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        if (Target.Version.MinorVersion <= 19)
        {
            PublicIncludePaths.AddRange(
                new string[] {
                    "RuntimeMeshComponentEditor/Public"
                });

            PrivateIncludePaths.AddRange(
                new string[] {
                    "RuntimeMeshComponentEditor/Private",
                });
        }

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core"
            });

		PrivateIncludePaths.AddRange(new string[] { Path.Combine(ModuleDirectory, "Private") });
		PublicIncludePaths.AddRange(new string[] { Path.Combine(ModuleDirectory, "Public") });

        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
                "RenderCore",
                "RHI",
                "UnrealEd",
                "LevelEditor",
                "PropertyEditor",
                "RawMesh",
                "AssetTools",
                "AssetRegistry",
                "Projects",
                "EditorStyle",
                "InputCore",

                "RuntimeMeshComponent",
            });

        if (Target.Version.MinorVersion <= 21)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "ShaderCore",
                });
        }

        if (Target.Version.MinorVersion > 20)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "NavigationSystem"
                });
        }
    }
}
