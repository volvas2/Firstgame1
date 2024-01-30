using UnityEngine;

namespace Lessons.Rain_3D_Objects
{
    public class ImpulseController
    {
        private readonly Rigidbody _rigidbody;
        
        private const int IMPULSE = 55;

        public ImpulseController(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void AddImpulse()
        {
            _rigidbody.AddForce(Random.insideUnitSphere * IMPULSE, ForceMode.Impulse);
        }
    }
}