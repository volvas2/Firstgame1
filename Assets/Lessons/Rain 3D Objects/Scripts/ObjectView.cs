using UnityEngine;

namespace Lessons.Rain_3D_Objects
{
    [RequireComponent(typeof(MeshRenderer))]
    public class ObjectView : MonoBehaviour
    {
        public bool IsClickable { get; set; }
        
        [SerializeField] private MeshRenderer _renderer;

        private ColorComponent _color;
        private DestroyObjectController _destroyObject;
        private ImpulseController _impulse;

        private void Awake()
        {
            _color = new ColorComponent(_renderer);
            _destroyObject = new DestroyObjectController(transform);
            _impulse = new ImpulseController(GetComponent<Rigidbody>());
        }

        private void Update()
        {
            _destroyObject.Check();
        }

        public void SetColor(Color color)
        {
            _color.SetColor(color);
        }

        public void AddImpulse()
        {
            if (IsClickable) _impulse.AddImpulse();
        }

        private void OnDestroy()
        {
            _color = null;
            _destroyObject = null;
            _impulse = null;
        }
    }
}