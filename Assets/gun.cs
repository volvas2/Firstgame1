using UnityEngine;

public class gun : MonoBehaviour
{
    public float offset;
    public float speedBullet;
    public GameObject bullet;
    public Transform shotPoint;
    public Transform Gun;

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - Gun.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        rotZ = Mathf.Clamp(rotZ, -60, 40);
        Gun.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rotZ);

        if (Input.GetMouseButtonDown(0))
        { 
            var instance = Instantiate(bullet, shotPoint.position, Quaternion.identity).GetComponent<bullet>();
            instance.SetSpeed(speedBullet);
            instance.SetDirection(shotPoint.localPosition);
        }
    }
}
