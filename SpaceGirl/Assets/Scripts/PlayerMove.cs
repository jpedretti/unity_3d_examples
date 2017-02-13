using UnityEngine;

public class PlayerMove : MonoBehaviour {


    public float speed = 10;
    private Rigidbody2D _rigidyBody;

    private void Awake()
    {
        _rigidyBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        var xMove = Input.GetAxis(Axis.Horizontal.ToString());
        var yMove = Input.GetAxis(Axis.Vertical.ToString());

        _rigidyBody.velocity = new Vector2(xMove * speed, yMove * speed);
    }
}

public enum Axis
{
    Horizontal,
    Vertical
}
