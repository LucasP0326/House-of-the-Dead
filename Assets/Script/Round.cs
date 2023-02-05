using UnityEngine;

public class Round : MonoBehaviour
{
    public float damage;

    void OnCollisionEnter(Collision other)
    {
        Target target = other.gameObject.GetComponent<Target>();
        //only deals damage to things with the "Target" component attach Target to all enemies
        if(target != null)
        {
            target.Hit(damage);
            Destroy(gameObject);
        }
    }
}
