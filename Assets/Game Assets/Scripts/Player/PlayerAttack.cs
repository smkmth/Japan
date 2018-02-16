using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class PlayerAttack : MonoBehaviour {

	private bool attacking = false;
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
		facingleft = PlayerControl.facingLeft; 
		if (Input.GetKeyDown(KeyCode.Z) && !attacking) {
			attacking = true;

			//PlayerState.Instance.localPlayerData.Health -= 10;

			//string talkedtogran = VariableStorage.GetValue





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
	}

}
