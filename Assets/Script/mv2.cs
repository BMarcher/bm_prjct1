using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class mv2 : NetworkBehaviour
{

    public float moveSpeed;

    private Vector3 movement;

    private Rigidbody2D rigidBody;
   // private bool playerIsMoving = false;

    void Start()
    {
        if (!isLocalPlayer)
            return;
        rigidBody = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        if (!isLocalPlayer)
            return;
        float h = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed;
        Move(h, v);
        Turning();
    }

    public void Move(float h, float v)
    {

        if (!isLocalPlayer)
            return;
        movement.Set(h, v, 0f);
        rigidBody.MovePosition(transform.position + movement);
        movement = movement.normalized * moveSpeed * Time.deltaTime;
    }

    public void Turning()
    {

        if (!isLocalPlayer)
            return;
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);
        transform.rotation = rot;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        rigidBody.angularVelocity = 0;
    }
}
