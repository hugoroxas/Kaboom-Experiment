using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    protected float jump;
    protected float horizontalMove;
    [SerializeField]
    protected float speed = 2f;
    protected Rigidbody2D myRigidbody2D;
    protected bool grounded = false;
	[SerializeField]
	protected GameObject prefabBomb;
	[SerializeField]
	protected GameObject prefabBombAntiGrav;
    [SerializeField]
    protected float projectileSpeed = 20f;
    protected int playerAim;
    protected bool facingRight = false;
    protected int gotBomb = 0;
    protected int maxBomb = 5;
    protected Animator myAnimator;

    private void Awake(){
        myAnimator = GetComponent<Animator>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    protected virtual void Update()
    {
        
    }

    private void FixedUpdate(){
            myRigidbody2D.velocity =
            new Vector2(horizontalMove * speed, myRigidbody2D.velocity.y);

    }

    private void OnTriggerEnter2D(Collider2D other){
        grounded = true;
        if (other.CompareTag("GotABomb") && gotBomb == 0 ){
            gotBomb = gotBomb + 1;
        }
        print(gotBomb);
    }

    private void OnTriggerExit2D(Collider2D other){
        grounded = false;
    }
    private void Faced(){
        if (facingRight){
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (!facingRight){
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }
}