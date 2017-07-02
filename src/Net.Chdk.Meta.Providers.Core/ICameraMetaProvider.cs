using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Providers
{
    public interface ICameraMetaProvider
    {
        SoftwareCameraInfo GetCamera(string name);
    }
}
