using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyECS
{
    public struct Entity : IEquatable<Entity>
    {
        internal ulong Id;
        internal static Entity FirstEntity = new(0);
        internal Entity NextEntity()
            => new Entity(Id + 1);

        private Entity(ulong id)
        {
            Id = id;
        }

    public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}
