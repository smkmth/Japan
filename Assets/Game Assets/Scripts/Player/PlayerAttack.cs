using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class PlayerAttack : MonoBehaviour {

	private bool attacking = false;
	public bool attackstance = false;
	private float attackTimer = 0;
	public float attackCool = 0.9f;
	public Collider2D rightAttackTrigger;
	public Collider2D leftAttackTrigger;
	private Animator anim;
	private GameObject playerSprite;
	private VariableStorage variableStorage;


	public GameObject dialogue;
	private static bool facingleft;

	void Awake ()
	{
		playerSprite = transform.Find ("PlayerSprite").gameObject;
		anim = (Animator)playerSprite.GetComponent (typeof(Animator));
		rightAttackTrigger.enabled = false;
		leftAttackTrigger.enabled = false;

	}

	void Update()
	{
		if (Input.GetButton ("AttackStance")) {
			attackstance = true;
			Debug.Log("Attack stance");
			anim.SetBool ("attackstance", true);
			facingleft = PlayerControl.facingLeft; 
			if (Input.GetKeyDown (KeyCode.Z) && !attacking) {
				attacking = true;


				attackTimer = attackCool;

				if (facingleft == true) {
					leftAttackTrigger.enabled = true;
				} else {
					rightAttackTrigger.enabled = true;
				}
			}
			if (attacking) {
				if (attackTimer > 0) {
					attackTimer -= Time.deltaTime;
				} else {
					attacking = false;
					rightAttackTrigger.enabled = false;
					leftAttackTrigger.enabled = false;
				}

			}
			anim.SetBool ("Attacking", attacking);
		} else {
			anim.SetBool ("attackstance", false);
			attacking = false;
		}
		


	}

}
