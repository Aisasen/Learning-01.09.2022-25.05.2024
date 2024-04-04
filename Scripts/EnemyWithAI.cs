using System.Collections;
using UnityEngine;
using Pathfinding;

public class EnemyWithAI : MonoBehaviour
{
    public int Currentlives;
    public int Maxlives;
    public int EnemyDamage;
    [SerializeField] private float attackRange = 1.2f;
    [SerializeField] private float attackCooldown = 1f;
    [SerializeField] private Transform attackPoint;
    [SerializeField] private LayerMask playerLayer;
    private bool isAttackReady = true;
    private float lastAttackTime;
    private SpriteRenderer sprite;
    [SerializeField] private AIPath aipath;
    [SerializeField] private Animator animator;
    public GameObject healthBar;
    [SerializeField] private int points = 1;
    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        animator = GetComponent<Animator>();
        Currentlives = Maxlives;
    }
    void Update()
    {
        bool isMovingRight = aipath.desiredVelocity.x > 0;
        bool isMovingLeft = aipath.desiredVelocity.x < 0;
        if (isMovingRight)
        {
            sprite.flipX = false;
        }
        else if (isMovingLeft)
        {
            sprite.flipX = true;
        }
        if (isMovingRight && attackPoint.localPosition.x < 0)
        {
            attackPoint.localPosition = new Vector3(-attackPoint.localPosition.x, attackPoint.localPosition.y, attackPoint.localPosition.z);
        }
        else if (isMovingLeft && attackPoint.localPosition.x > 0)
        {
            attackPoint.localPosition = new Vector3(-attackPoint.localPosition.x, attackPoint.localPosition.y, attackPoint.localPosition.z);
        }
        sprite.flipX = aipath.desiredVelocity.x >= 0.01f;
        if (isAttackReady && Time.time - lastAttackTime > attackCooldown)
        {
            Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);
            foreach (Collider2D player in hitPlayers)
            {
                animator.SetBool("isAttacking", true);
                isAttackReady = false;
                lastAttackTime = Time.time;
                animator.Play("attack");
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    public void EndAttackAnimation()
    {
        Collider2D[] hitPlayers = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);
        foreach (Collider2D player in hitPlayers)
        {
            player.GetComponent<Player>().GetDamage(EnemyDamage);
        }
        animator.SetBool("isAttacking", false);
        StartCoroutine(AttackCooldown());
    }

    private IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(attackCooldown);
        isAttackReady = true;
    }

    public void GetDamage(int PlayerDamage)
    {
        Currentlives = Currentlives - PlayerDamage;
        if (Currentlives < 1)
            Die();
        else
        {
            float damageRatio = (float)Currentlives / Maxlives;
            healthBar.transform.localScale = new Vector2(damageRatio, 0.3317f);
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);
        Player player = GameObject.FindObjectOfType<Player>();
        if (player != null)
        {
            player.AddScore(points);
        }
    }
}
