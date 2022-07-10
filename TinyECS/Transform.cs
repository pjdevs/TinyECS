using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TinyECS
{
    public struct Transform
    {
        public Vector3 Position;
        public Vector3 Rotation;
        public Vector3 Scale;

        public Transform()
        {
            Position = Vector3.Zero;
            Rotation = Vector3.Zero;
            Scale = Vector3.One;
        }

        public Matrix4x4 ComputeMatrix()
        {
            return Matrix4x4.CreateTranslation(Position)
                * Matrix4x4.CreateRotationX(Rotation.X)
                * Matrix4x4.CreateRotationX(Rotation.Y)
                * Matrix4x4.CreateRotationX(Rotation.Z)
                * Matrix4x4.CreateScale(Scale);
        }
    }
}
