using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Providers
{
    public interface ICompilerMetaProvider
    {
        SoftwareCompilerInfo GetCompiler(SoftwareInfo software);
    }
}
