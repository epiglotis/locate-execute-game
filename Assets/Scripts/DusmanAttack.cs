using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanAttack : MonoBehaviour
{

    OyuncuHP target;
    [SerializeField] float damage = 40f;


    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<OyuncuHP>();
    }

    public void OnDamageTaken()
    {
        Debug.Log(name + " biliyorum hasar aldık");
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.GetComponent<OyuncuHP>().TakeDamage(damage);
        target.GetComponent<DisplayDamage>().ShowDamageImpact();
    }

  
}
