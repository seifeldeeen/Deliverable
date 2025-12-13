interface IDeliverable
{
    bool RequiresSpecialDocking { get; }
    void LoadCargo(int weight);
    void UnloadCargo(int weight);
}





class Program
{
    static async Task Main(string[] args)
    {
        //Testting goes here...
    }
}