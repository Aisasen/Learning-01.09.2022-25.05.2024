using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player: MonoBehaviour
{
	[SerializeField] private float speed = 10f;
	[SerializeField] static public int Maxlives;
    [SerializeField] static public int Currentlives;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private int PlayerDamage;

    private bool isGrounded = false;

	public bool isAttacking = false;
	public bool isRecharged = true;
	public Transform attackPos;
	public float attackRange;
	public LayerMask enemy;

	private Rigidbody2D rb;
	private Animator anim;
	private SpriteRenderer sprite;
	public static Player Instance { get; set; }

	float inputHorizontal;
	float inputVertical;
	bool facingRight = true;

	static public int score;
	public Text scoreText;
	private States State
    {
		get { return (States)anim.GetInteger("State"); }
		set { anim.SetInteger("State", (int)value); }
    }
	private void Awake()
	{
		Maxlives = PlayerPrefs.GetInt("MaxLives", 100);
		Currentlives = PlayerPrefs.GetInt("CurrentLives", 100);
		score = PlayerPrefs.GetInt("Score", 0);
		scoreText.text = score.ToString();
		Instance = this;
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		sprite = GetComponentInChildren<SpriteRenderer>();
		isRecharged = true;
		PlayerDamage = 5;
    }

	private void FixedUpdate()
	{
		CheckGround();
		inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

		if (inputHorizontal > 0 && !facingRight)
		{
			Flip();
		}
        if (inputHorizontal < 0 && facingRight)
        {
			Flip();
        }
    }

	void Flip()
	{
		Vector3 currentScale = gameObject.transform.localScale;
		currentScale.x *= -1;
		gameObject.transform.localScale = currentScale;
		facingRight = !facingRight;
	}

	private void Update()
    {
        if (isGrounded && !isAttacking) State = States.idle;

        if (!isAttacking && Input.GetButton("Horizontal"))
            Run();
        if (!isAttacking && isGrounded && Input.GetButtonDown("Jump"))
            Jump();
        if (Input.GetButtonDown("Fire1"))
            Attack();
    }

    private void Run()
	{
		if (isGrounded) State = States.run;

		Vector3 dir = transform.right * Input.GetAxis("Horizontal");
		transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
	}

	private void Jump()
	{
		rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
	}

	private void Attack()
	{
		if (isGrounded && isRecharged)
		{
			State = States.attack;
			isAttacking = true;
			isRecharged = false;
			StartCoroutine(AttackAnimation());
            StartCoroutine(AttackCoolDown());
        }
    }

    public void OnAttack()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemy);

        for (int i = 0; i < colliders.Length; i++)
        {
            colliders[i].GetComponent<EnemyWithAI>().GetDamage(PlayerDamage);
        }
    }

    private IEnumerator AttackAnimation()
    {
        yield return new WaitForSeconds(0.4f);
        isAttacking = false;
    }

    private IEnumerator AttackCoolDown()
    {
        yield return new WaitForSeconds(0.5f);
        isRecharged = true;
    }

    private void CheckGround()
	{
		Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.3f);
		isGrounded = collider.Length > 1;

		if (!isGrounded) State = States.jump;
	}

    public void GetDamage(int EnemyDamage)
    {
        Currentlives = Currentlives-EnemyDamage;
        if (Currentlives < 1)
		{
			Die();
		}  
    }

    public void Die()
    {
		Destroy(this.gameObject);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Maxlives = PlayerPrefs.GetInt("MaxLives");
		Currentlives = PlayerPrefs.GetInt("CurrentLives");
		score = PlayerPrefs.GetInt("Score");
	}

    private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(attackPos.position, attackRange);
	}

	public void AddScore(int points)
	{
		score += points;
		scoreText.text = score.ToString();
	}
}


public enum States
{
	idle,
	run,
	jump,
	attack
}