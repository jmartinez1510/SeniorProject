using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPunch : MonoBehaviour {

	public GameObject Punch1Box;
	private Animator myAnimator;
	public Sprite Punch1BoxHitFrame;
	SpriteRenderer currentSprite;
    public Collider[] attackHitboxes;

    // Use this for initialization
    void Start () {
		myAnimator = GetComponent<Animator>();
		currentSprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (EnemyMovment.NotNearPlayer == false) {
            myAnimator.SetTrigger ("punch1");
            //launchAttack(attackHitboxes[0]);

        }

		/*if (NotNearPlayer == false)
		{
			//launchAttack(attackHitboxes[0]);
			//speed = 10;
			//myAnimator.ResetTrigger("idle");
			myAnimator.SetTrigger("punch1");
		}*/
		if (EnemyMovment.NotNearPlayer == true)
		{
			myAnimator.ResetTrigger("punch1");
			//myAnimator.SetTrigger("idle");
		}

		if (Punch1BoxHitFrame == currentSprite.sprite) {
			Punch1Box.gameObject.SetActive (true);
			launchAttack(attackHitboxes[0]);
            
        } else
			Punch1Box.gameObject.SetActive (false);
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
            switch (c.name)
            {
                case "Body":
                    damage = 5;
                    break;
                default:
                    Debug.Log("Unable to identify body part, check switch case");
                    break;
            }

            c.SendMessageUpwards("TakeDamage", damage);
        }
    }

}
