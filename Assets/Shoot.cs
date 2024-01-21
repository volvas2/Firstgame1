using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float _speedBullet;
    [SerializeField] private float _minAngleRot = -60;
    [SerializeField] private float _maxAngleRot = 40;

    [SerializeField] Bullet _bullet;
    [SerializeField] Transform _shotPoint;
    [SerializeField] Transform _gun;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var instance = Instantiate(_bullet, _shotPoint.position, Quaternion.identity);
            instance.SetSpeed(_speedBullet);
            instance.SetDirection(_shotPoint.localPosition);
        }

        RotationGun();
    }

    private void RotationGun()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - _gun.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        rotZ = Mathf.Clamp(rotZ, _minAngleRot, _maxAngleRot);
        _gun.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rotZ);
    }
}