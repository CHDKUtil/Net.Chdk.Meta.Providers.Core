namespace Net.Chdk.Meta.Providers
{
    public interface IBootMetaProvider
    {
        string GetFileName(string productName);
        int[][] GetOffsets(string productName);
    }
}
