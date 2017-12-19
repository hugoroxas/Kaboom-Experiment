using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : PlayerScript
{
	
        protected override void Update (){

        if (Input.GetKeyDown(KeyCode.W)){
            if (grounded){
                myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, jump);
            }
            else{
                if (Input.GetKeyUp(KeyCode.W)){
                    myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, myRigidbody2D.position.y);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.A)){
            horizontalMove = -1;
            playerAim = -1;
            myAnimator.SetBool("DirectionFaced", false);
        }
        else{
            if (Input.GetKeyUp(KeyCode.A)){
                horizontalMove = 0;
            }
        }if (Input.GetKeyDown(KeyCode.D)){
            horizontalMove = 1;
            playerAim = 1;
            myAnimator.SetBool("DirectionFaced", true);
        }
        else{
            if (Input.GetKeyUp(KeyCode.D)){
                horizontalMove = 0;
            }
        }
		if (Input.GetKeyDown(KeyCode.F) && gotBomb > 0){
			GameObject bombInstance = Instantiate(prefabBomb, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			bombInstance.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.right.x * playerAim, 0.5f) * projectileSpeed);
			gotBomb = gotBomb - 1;
		}
		if (Input.GetKeyDown(KeyCode.G) && gotBomb > 0){
			GameObject bombInstance = Instantiate(prefabBombAntiGrav, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			bombInstance.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.right.x * playerAim, 0.5f) * projectileSpeed);
			gotBomb = gotBomb - 1;
		}

    }
}
