using UnityEngine;

namespace Lessons.Rain_3D_Objects
{
    public class ColorComponent
    {
        private readonly MeshRenderer _renderer;

        public ColorComponent(MeshRenderer renderer)
        {
            _renderer = renderer;
        }

        public void SetColor(Color color)
        {
            _renderer.material.color = color;
        }
    }
}