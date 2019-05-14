namespace BuilderPatternSample
{
    public interface IPetsBuilder<T>
    {
        IPetsBuilder<T> AddNames();
        IPetsBuilder<T> AddOwners();
        T Build();
    }
}
