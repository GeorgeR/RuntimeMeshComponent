// Copyright 2016-2018 Chris Conway (Koderz). All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class RuntimeMeshComponent : ModuleRules
{
    public RuntimeMeshComponent(ReadOnlyTargetRules rules) : base(rules)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

<<<<<<< HEAD
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
            new string[] {
                "Core"
			});
=======
		PrivateIncludePaths.AddRange(new string[] { Path.Combine(ModuleDirectory, "Private") });
		PublicIncludePaths.AddRange(new string[] { Path.Combine(ModuleDirectory, "Public") });

		PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
				// ... add other public dependencies that you statically link with here ...
			}
            );

>>>>>>> 422_ready

        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "CoreUObject",
                "Engine",
                "RenderCore",
<<<<<<< HEAD
                "RHI",
            });

        if (Target.Version.MinorVersion <= 21)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "ShaderCore",
                });
        }
=======
#if !UE_4_22_OR_LATER
				"ShaderCore",  // ShaderCore was Merged into RenderCore in 4.22
#endif
				"RHI",
#if UE_4_20_OR_LATER
				"NavigationSystem"
#endif
            }
            );


        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
				// ... add any modules that your module loads dynamically here ...
			}
            );
>>>>>>> 422_ready
    }
}
