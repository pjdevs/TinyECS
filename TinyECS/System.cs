namespace TinyECS
{
    public abstract class System
    {
        public Archetype AcceptedArchetype { get; private set; }
        public List<Entity> Entities { get; private set; }

        public System(Archetype acceptedArchetype)
        {
            AcceptedArchetype = acceptedArchetype;
            Entities = new List<Entity>();
        }

        public abstract void OnEntityAdded(Entity entity);
        public abstract void OnEntityRemoved(Entity entity);
        public abstract void OnComponentAdded(Entity entity);
        public abstract void OnComponentAdded(Entity entity, ref IComponent component);
        public abstract void OnComponentRemoved(Entity entity, ref IComponent component);

        public abstract void Execute();
    }
}
