using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Providers
{
    public interface IEncodingMetaProvider
    {
        SoftwareEncodingInfo GetEncoding(SoftwareEncodingInfo encoding);
    }
}
