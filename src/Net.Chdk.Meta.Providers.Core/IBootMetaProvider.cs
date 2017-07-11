using Net.Chdk.Model.Category;

namespace Net.Chdk.Meta.Providers
{
    public interface IBootMetaProvider
    {
        string GetFileName(string productName);
        int[][] GetOffsets(string productName);
        int[][] GetOffsets(CategoryInfo category);
    }
}
