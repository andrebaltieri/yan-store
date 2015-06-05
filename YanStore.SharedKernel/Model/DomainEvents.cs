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
                    foreach (var handler in Container.GetServices(typeof(IHandle<T>)))
                        ((IHandle<T>)handler).Handle(args);
                }
            }
            catch
            {
                //throw;
            }
        }
    }
}
