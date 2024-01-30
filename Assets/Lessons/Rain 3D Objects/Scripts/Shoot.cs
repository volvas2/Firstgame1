using UnityEngine;

namespace Lessons.Rain_3D_Objects
{
    public class Shoot : MonoBehaviour
    {
        [SerializeField] private LayerMask _mask;
        
        private Camera _camera;
        
        private const int RADIUS_AREA_PHYSICS = 10;
        private const int MAX_DISTANCE_RAY = 100;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray, out RaycastHit hit, MAX_DISTANCE_RAY, _mask))
                {
                    Collider[] colliders = Physics.OverlapSphere(hit.point, RADIUS_AREA_PHYSICS);
                    foreach (var collider in colliders)
                    {
                        collider.TryGetComponent(out ObjectView view);
                        view?.AddImpulse();
                    }
                }
            }
        }
    }
}