using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Providers
{
    public interface IEncodingMetaProvider
    {
        SoftwareEncodingInfo GetEncoding(uint version);
        SoftwareEncodingInfo GetEncoding(SoftwareEncodingInfo encoding);
    }
}
