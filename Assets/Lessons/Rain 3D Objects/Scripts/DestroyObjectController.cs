using UnityEngine;

namespace Lessons.Rain_3D_Objects
{
    public class DestroyObjectController
    {
        private readonly Transform _transform;

        public DestroyObjectController(Transform transform)
        {
            _transform = transform;
        }

        public void Check()
        {
            if (_transform.position.y < -5)
            {
                Object.Destroy(_transform.gameObject);
            }

        }
    }
}