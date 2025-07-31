namespace MegaToolbox
{
    public interface ITool
{
    string Name { get; }
    string Description { get; }
    void Run(string[] args);
}
}