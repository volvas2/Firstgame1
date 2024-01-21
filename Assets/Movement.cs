using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int _speed = 10;
    
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private Vector2 _direction;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        _direction = new Vector2(x, y);
        _rigidbody.velocity = _direction * _speed * Time.deltaTime;

        PlayAnimation(_direction.x);
        Flip(_direction.x < 0);
    }

    private void PlayAnimation(float direction)
    {
        bool result = direction != 0;
        _animator.SetBool("isRunning", result);
    }

    private void Flip(bool isBack)
    {
        float y = isBack ? 180 : 0;
        Vector3 rot = transform.eulerAngles;
        rot.y = y;
        transform.eulerAngles = rot; 
    }
}