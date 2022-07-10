using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyECS
{
    public class World
    {
        private Entity _nextEntity;
        private Archetype _nextComponentArchetype;

        private Dictionary<Entity, int> _lookup;
        private Dictionary<Archetype, int> _archetypes;
        private List<Entity> _entities;
        private List<Transform> _transforms;

        public World()
        {
            _nextEntity = Entity.FirstEntity;
            _nextComponentArchetype = Archetype.FirstArchetype;

            _lookup = new Dictionary<Entity, int>();
            _entities = new List<Entity>();
            _transforms = new List<Transform>();
        }

        public void AddComponent<T>(Entity entity, ref T component) where T : struct, IComponent
        {

        }
    }
}
