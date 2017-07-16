namespace Net.Chdk.Meta.Providers
{
    public interface IProductCameraMetaProvider
    {
        CameraInfo GetCamera(string fileName);
    }
}
