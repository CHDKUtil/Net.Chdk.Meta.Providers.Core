﻿using Net.Chdk.Model.Software;

namespace Net.Chdk.Meta.Providers
{
    public interface ICameraMetaProvider
    {
        CameraInfo GetCamera(string name);
    }
}
