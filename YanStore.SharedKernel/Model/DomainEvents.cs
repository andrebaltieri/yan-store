namespace YanStore.SharedKernel.Model
{
    public static class DomainEvents
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            try
            {
                if (Container != null)
                {
                    // TODO>: Melhorar
                    //foreach (var handler in Container.GetServices(typeof(IHandle<T>)))
                    //{
                        var obj = Container.GetService(typeof(IHandle<T>));
                        ((IHandle<T>)obj).Handle(args);
                    //}                    
                }
            }
            catch
            {
                //throw;
            }
        }
    }
}
