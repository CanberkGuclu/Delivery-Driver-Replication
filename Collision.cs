using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Collision : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.5f;

    bool hasPackage= false;

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ah bu acıdı!");
    }
     
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Tebrikler, bir şeyler başardın!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        
        if (other.tag == "Müşteri" && hasPackage)
        {
        Debug.Log("Aferin sana çocuk adam!");
        hasPackage = false;
        spriteRenderer.color = noPackageColor;
        }
    }
}
