using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 40f;
    float timer = 1;
    bool countdown;
    public void TakeDamage (float amount)
    {
        health -= amount;
        GameObject.Find("Player").GetComponent<Money>().AddFunds(25);
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die ()
    {
        if (countdown == false)
        {
            GameObject.Find("Player").GetComponent<Money>().AddFunds(250);
            transform.GetComponent<Animator>().SetBool("IsDead", true);
            countdown = true;
        }
    }
    private void Update()
    {
        if (countdown == true)
            timer -= Time.deltaTime;
        if (timer < 0)
            Destroy(gameObject);
    }
}
