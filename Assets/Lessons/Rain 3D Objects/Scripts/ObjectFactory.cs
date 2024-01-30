using UnityEngine;

namespace Lessons.Rain_3D_Objects
{
    [CreateAssetMenu(fileName = "ObjectFactory", menuName = "Factories/Object")]
    public class ObjectFactory : ScriptableObject
    {
        [SerializeField] private ObjectView[] _objects;

        public ObjectView Get(Vector3 pos, Vector3 rot, Color color)
        {
            var prefab = _objects[Random.Range(0, _objects.Length)];
            var instance = Instantiate(prefab);
            instance.transform.position = pos;
            instance.transform.eulerAngles = rot;
            instance.SetColor(color);
            return instance;
        }
    }
}