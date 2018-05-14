using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    private Animator myAnimator;
    public Collider[] attackHitboxes;
    // Use this for initialization
    void Start () {
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        GameManager.IsInputEnabled = true;
        if (GameManager.IsInputEnabled) {
            //Keyboard Inputs
            if (Input.GetKeyDown(KeyCode.Z))
            {
                GameManager.IsInputEnabled = false;
                launchAttack(attackHitboxes[0]);
                //speed = 10;
                myAnimator.ResetTrigger("idle");
                myAnimator.SetTrigger("punch1");
            }
            //GameManager.IsInputEnabled = true;
            if (Input.GetKeyUp(KeyCode.Z))
            {
                myAnimator.ResetTrigger("punch1");
                myAnimator.SetTrigger("idle");
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                GameManager.IsInputEnabled = false;
                launchAttack(attackHitboxes[1]);
                //speed = 10;
                myAnimator.ResetTrigger("idle");
                myAnimator.SetTrigger("kick1");
            }
            //GameManager.IsInputEnabled = true;
            if (Input.GetKeyUp(KeyCode.X))
            {
                myAnimator.ResetTrigger("kick1");
                myAnimator.SetTrigger("idle");
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                GameManager.IsInputEnabled = false;
                launchAttack(attackHitboxes[2]);
                //speed = 10;
                myAnimator.ResetTrigger("idle");
                myAnimator.SetTrigger("special1");
            }
            //GameManager.IsInputEnabled = true;
            if (Input.GetKeyUp(KeyCode.C))
            {
                myAnimator.ResetTrigger("special1");
                myAnimator.SetTrigger("idle");
            }

            //Controller Inputs
            if (Input.GetButtonDown("X_Button"))
            { 
                GameManager.IsInputEnabled = false;
                launchAttack(attackHitboxes[0]);
                //speed = 10;
                myAnimator.ResetTrigger("idle");
                myAnimator.SetTrigger("punch1");
            }
            //GameManager.IsInputEnabled = true;
            if (Input.GetButtonUp("X_Button"))
            {
                myAnimator.ResetTrigger("punch1");
                myAnimator.SetTrigger("idle");
            }
            if (Input.GetButtonDown("B_Button"))
            {
                GameManager.IsInputEnabled = false;
                launchAttack(attackHitboxes[1]);
                //speed = 10;
                myAnimator.ResetTrigger("idle");
                myAnimator.SetTrigger("kick1");
            }
            //GameManager.IsInputEnabled = true;
            if (Input.GetButtonUp("B_Button"))
            {
                myAnimator.ResetTrigger("kick1");
                myAnimator.SetTrigger("idle");
            }
            if (Input.GetButtonDown("A_Button"))
            {
                GameManager.IsInputEnabled = false;
                launchAttack(attackHitboxes[2]);
                //speed = 10;
                myAnimator.ResetTrigger("idle");
                myAnimator.SetTrigger("special1");
            }
            //GameManager.IsInputEnabled = true;
            if (Input.GetButtonUp("A_Button"))
            {
                myAnimator.ResetTrigger("special1");
                myAnimator.SetTrigger("idle");
            }
        }
    }
    

    private void launchAttack(Collider col)
    {
        Collider[] cols = Physics.OverlapBox(col.bounds.center, col.bounds.extents, col.transform.rotation, LayerMask.GetMask("Hitbox"));
        foreach (Collider c in cols)
        {
            if (c.transform.parent.parent == transform)
                continue;
            Debug.Log(c.name);

            float damage = 0;
            switch(c.name)
            {
                case "Body":
                    damage = 20;
                    break;
                default:
                    Debug.Log("Unable to identify body part, check switch case");
                    break;
            }

            c.SendMessageUpwards("TakeDamage", damage);
        }
    }
}
