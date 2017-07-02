using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Providers
{
    public interface IBuildMetaProvider
    {
        SoftwareBuildInfo GetBuild(SoftwareInfo software);
    }
}
