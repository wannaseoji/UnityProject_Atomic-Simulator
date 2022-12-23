using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshHitMolecule : MonoBehaviour
{
    public Transform C6H12O6;
    public Transform Boom;
    public Transform C6H12O6TMI;
    public Transform TmiPos;
    public Transform MoleculeCollisionPos;
    private int hitnum = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll)
    {
        if (hitnum > 0) {
            Destroy(coll.gameObject);
            hitnum--;
            if (hitnum == 0) {
                Instantiate(Boom, MoleculeCollisionPos.position, MoleculeCollisionPos.rotation);
                Instantiate(C6H12O6TMI, TmiPos.position, TmiPos.rotation);
                Instantiate(C6H12O6, MoleculeCollisionPos.position, MoleculeCollisionPos.rotation);
                
            }
        }
        
       
       
    }


}
