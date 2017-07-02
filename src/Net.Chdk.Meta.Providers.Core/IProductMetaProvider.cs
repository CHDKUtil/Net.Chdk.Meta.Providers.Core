using Net.Chdk.Model.Software;
using System;

namespace Net.Chdk.Meta.Providers
{
    public interface IProductMetaProvider
    {
        SoftwareProductInfo GetProduct(string name, DateTime created);
    }
}
