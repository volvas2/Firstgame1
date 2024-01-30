using System.Collections;
using UnityEngine;

namespace Lessons.Rain_3D_Objects
{
    public class SpawnerComponent : MonoBehaviour
    {
        [SerializeField] private ObjectFactory _factory;

        private const float SECONDS_SPAWN = 0.0015f;
        private const int COUNT_SPAWN_OBJECTS = 30000;
        
        private WaitForSeconds _waitForSeconds;
        private Vector3 _posSpawn;
        private Vector3 _rotSpawn;

        private IEnumerator Start()
        {
            _waitForSeconds = new WaitForSeconds(SECONDS_SPAWN);
            
            for (int i = 0; i < COUNT_SPAWN_OBJECTS; i++)
            {
                UpdatePointSpawn();
                UpdateRotationSpawn();
                _factory.Get(_posSpawn, _rotSpawn, Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
                yield return _waitForSeconds;
            }
        }

        private void UpdatePointSpawn()
        {
            _posSpawn.x = Random.Range(-15, 11);
            _posSpawn.y = 40;
            _posSpawn.z = Random.Range(-17, 10); 
        }
        
        private void UpdateRotationSpawn()
        {
            _rotSpawn.x = Random.Range(0, 180);
            _rotSpawn.y = Random.Range(0, 180);
            _rotSpawn.z = Random.Range(0, 180); 
        }
    }
}
