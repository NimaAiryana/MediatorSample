namespace MediatorSample
{
    internal interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
