using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChompMan : MonoBehaviour {

    private float speed = 0.05f;
    Vector2 dest = Vector2.zero;
    public BallManTransform currentBallChomp;

    void Start()
    {
        dest = transform.position;
    }

    void FixedUpdate()
    {
        if (currentBallChomp.CurrentMode == PlayerMode.ChompMan){
            // Move closer to Destination
            Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);


            
        }

        // Check for Input if not moving
        //if ((Vector2)transform.position == dest)
        //{
        //    if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up)){
        //        dest = (Vector2)transform.position + Vector2.up;
        //        Debug.Log("Up");
        //    }
        //    if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right)){
        //        dest = (Vector2)transform.position + Vector2.right;
        //        Debug.Log("Right");}
        //    if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up)){
        //        dest = (Vector2)transform.position - Vector2.up;
        //        Debug.Log("Down");}
        //    if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right)){
        //        dest = (Vector2)transform.position - Vector2.right;
        //        Debug.Log("Left");}
        //}


        float movementDirectionHorizontal = Input.GetAxisRaw("Horizontal") ;

        if (movementDirectionHorizontal> 0){
            dest = (Vector2)transform.position + (Vector2.right* 10.0F);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            //Debug.Log("Right");
            //Debug.Log(movementDirectionHorizontal);
        }else if (movementDirectionHorizontal < 0){
            dest = (Vector2)transform.position - (Vector2.right* 10.0F);
            transform.localRotation = Quaternion.Euler(0, -180, 0);
            //Debug.Log("Left");
            //Debug.Log(movementDirectionHorizontal);
        }


        float movementDirectionVertical = Input.GetAxisRaw("Vertical");
        if (movementDirectionVertical > 0)
        {
            dest = (Vector2)transform.position + (Vector2.up* 10.0F);
            //Debug.Log("Up");
            //Debug.Log(movementDirectionVertical);
        }
        else if (movementDirectionVertical < 0)
        {
            dest = (Vector2)transform.position - (Vector2.up* 10.0F);
            //Debug.Log("Down");
            //Debug.Log(movementDirectionVertical);
        }

    }

    bool valid(Vector2 dir)
    {
        // Cast Line from 'next to Pac-Man' to 'Pac-Man'
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }
}
