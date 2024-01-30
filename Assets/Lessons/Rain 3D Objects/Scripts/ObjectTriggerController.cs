using UnityEngine;

namespace Lessons.Rain_3D_Objects
{
    public class ObjectTriggerController : MonoBehaviour
    { 
        private void OnTriggerEnter(Collider other)
        {
            UpdateObjectView(other.gameObject, true);
        }

        private void OnTriggerExit(Collider other)
        {
            UpdateObjectView(other.gameObject, false);
        }

        private void UpdateObjectView(GameObject obj, bool status)
        {
            obj.TryGetComponent(out ObjectView view);
            if (view is not null)
            {
                view.IsClickable = status;
            }
        }
    }
}