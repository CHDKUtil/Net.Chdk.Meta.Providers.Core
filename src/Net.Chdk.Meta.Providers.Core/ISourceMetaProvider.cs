﻿using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Providers
{
    public interface ISourceMetaProvider
    {
        SoftwareSourceInfo GetSource(SoftwareInfo software);
    }
}
