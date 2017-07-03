namespace Net.Chdk.Meta.Providers
{
    public interface IBootMetaProvider
    {
        string FileName { get; }
        int[][] Offsets { get; }
    }
}
