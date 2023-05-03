namespace FibonacciApi.Repository
{
    public interface ISequenceRepository
    {
        Task<Sequence> GetSequenceAsync(long len);

        Task SetSequenceValue(long len, Sequence values);

        Task ClearCacheAsync();
    }
}
