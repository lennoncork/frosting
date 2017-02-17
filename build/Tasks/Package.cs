using Cake.Common.Tools.DotNetCore;
using Cake.Common.Tools.DotNetCore.Pack;
using Cake.Core.IO;
using Cake.Frosting;

[Dependency(typeof(UnitTests))]
public class Package : FrostingTask<Context>
{
    public override void Run(Context context)
    {
        var path = new FilePath("./src/Cake.Frosting/Cake.Frosting.csproj");
        context.DotNetCorePack(path.FullPath, new DotNetCorePackSettings(){
            Configuration = context.Configuration,
            VersionSuffix = context.Suffix,
            NoBuild = true,
            Verbose = false
        });
    }
}