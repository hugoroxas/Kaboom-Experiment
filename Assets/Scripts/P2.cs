using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : PlayerScript
{

    protected override void Update(){

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded == true)
            {
                myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jump);
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.UpArrow))
                {
                    myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, myRigidbody2D.position.y);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            horizontalMove = -1;
            facingRight = false;
            playerAim = -1;
            myAnimator.SetBool("DirectionFaced", false);
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                horizontalMove = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            horizontalMove = 1;
            facingRight = true;
            playerAim = 1;
            myAnimator.SetBool("DirectionFaced", true);
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                horizontalMove = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightControl) && gotBomb > 0)
        {
            GameObject bombInstance = Instantiate(
                prefabBomb,
                new Vector2(transform.position.x, transform.position.y),
                Quaternion.identity
            );
            bombInstance.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.right.x * playerAim, 0.5f) * projectileSpeed);
            gotBomb -= gotBomb;
        }
		if (Input.GetKeyDown(KeyCode.RightShift) && gotBomb > 0){
			GameObject bombInstance = Instantiate(prefabBombAntiGrav, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			bombInstance.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.right.x * playerAim, 0.5f) * projectileSpeed);
			gotBomb = gotBomb - 1;
		}

    }
}
