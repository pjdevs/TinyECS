namespace TinyECS
{
    public struct Archetype
    {
        private ulong _archetypeMask;

        internal Archetype(ulong mask)
        {
            _archetypeMask = mask;
        }

        internal static Archetype FirstArchetype = new(0);
        internal Archetype NextArchetype()
        {
            Archetype next;
            next._archetypeMask = _archetypeMask << 1;

            return next;
        }

        public static Archetype Combine(params Archetype[] archetypes)
        {
            var finalArchetype = new Archetype(0);

            foreach (var archetype in archetypes)
            {
                finalArchetype._archetypeMask |= archetype._archetypeMask;
            }

            return finalArchetype;
        }
    }
}