using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;

    float speed = 3.0f;

    bool idle = true;
    bool frontwalk = false;
    bool backwalk = false;
    bool leftwalk = false;
    bool rightwalk = false;

    Vector3 moveVec;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 inputVec;
        inputVec.y = Input.GetAxisRaw("Vertical");
        inputVec.x = Input.GetAxisRaw("Horizontal");

        moveVec = Vector3.zero;

        if(inputVec != Vector2.zero)
        {
            if(inputVec.x > 0 && moveVec.y == 0)
            {
                moveVec.x = 1;
                Moveright();
                animator.SetBool("idle", false);
                animator.SetBool("rightidle", false);
                animator.SetBool("leftidle", false);
                animator.SetBool("backidle", false);
                animator.SetBool("frontwalk", false);
                animator.SetBool("leftwalk", false);
                animator.SetBool("backwalk", false);
                rightwalk = true;
            }
            if(inputVec.x < 0 && moveVec.y == 0)
            {
                moveVec.x = -1;
                Moveleft();
                animator.SetBool("idle", false);
                animator.SetBool("rightidle", false);
                animator.SetBool("leftidle", false);
                animator.SetBool("backidle", false);
                animator.SetBool("frontwalk", false);
                animator.SetBool("rightwalk", false);
                animator.SetBool("backwalk", false);
                leftwalk = true;
            }
            if(inputVec.y > 0 && moveVec.x == 0)
            {
                moveVec.y = 1;
                Moveback();
                animator.SetBool("idle", false);
                animator.SetBool("rightidle", false);
                animator.SetBool("leftidle", false);
                animator.SetBool("backidle", false);
                animator.SetBool("frontwalk", false);
                animator.SetBool("leftwalk", false);
                animator.SetBool("rightwalk", false);
                backwalk = true;
            }
            if(inputVec.y < 0 && moveVec.x == 0)
            {
                moveVec.y = -1;
                Movefront();
                animator.SetBool("idle", false);
                animator.SetBool("rightidle", false);
                animator.SetBool("leftidle", false);
                animator.SetBool("backidle", false);
                animator.SetBool("rightwalk", false);
                animator.SetBool("leftwalk", false);
                animator.SetBool("backwalk", false);
                frontwalk = true;
            }
            animator.speed = speed;
        }
        if (moveVec.x == 0)
        {
            if (rightwalk == true)
            {
                animator.SetBool("rightwalk", false);
                animator.SetBool("rightidle", true);
                rightwalk = false;
            }
            if (leftwalk == true)
            {
                animator.SetBool("leftwalk", false);
                animator.SetBool("leftidle", true);
                leftwalk = false;
            }
        }
        if (moveVec.y == 0)
        {
            if (backwalk == true)
            {
                animator.SetBool("backwalk", false);
                animator.SetBool("backidle", true);
                backwalk = false;
            }
            if (frontwalk == true)
            {
                animator.SetBool("frontwalk", false);
                animator.SetBool("idle", true);
                frontwalk = false;
            }
        }
    }

    void Moveright()
    {
        if(rightwalk == true)
        {
            animator.SetBool("rightwalk", true);
            transform.position += moveVec * speed * Time.deltaTime;
        }
    }
    void Moveleft()
    {
        if (leftwalk == true)
        {
            animator.SetBool("leftwalk", true);
            transform.position += moveVec * speed * Time.deltaTime;
        }
    }
    void Moveback()
    {
        if (backwalk == true)
        {
            animator.SetBool("backwalk", true);
            transform.position += moveVec * speed * Time.deltaTime;
        }
    }
    void Movefront()
    {
        if (frontwalk == true)
        {
            animator.SetBool("frontwalk", true);
            transform.position += moveVec * speed * Time.deltaTime;
        }
    }
}
