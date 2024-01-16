using UnityEngine;

public class Movement : MonoBehaviour
{
    public int Speed = 1;
    private Rigidbody2D rigidbody;
    private Animator anim;
    private float scaleX, x, y;
    

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        scaleX = transform.localScale.x;
    }

    private void Update()
    {

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y);
        rigidbody.velocity = direction * Speed * Time.deltaTime;

        PlayAnimation(direction.x);

        if (direction.x < 0)
        {
            Flip(true);
        }
        else
        {
            Flip(false);
        }

    }

    private void PlayAnimation(float direction)
    {
        bool result = direction == 0 ? false : true;
        anim.SetBool("isRunning", result);

    }

    private void Flip(bool isBack)
    {
        float y = isBack ? 180 : 0;
        Vector3 rot = transform.eulerAngles;
        rot.y = y;
        transform.eulerAngles = rot;
        /*Vector3 Scaler = transform.localScale;
        Scaler.x = scaleX * direction;
        transform.localScale = Scaler;*/
    }
}

