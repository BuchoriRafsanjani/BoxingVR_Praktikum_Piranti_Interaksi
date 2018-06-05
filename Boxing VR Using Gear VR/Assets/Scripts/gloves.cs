using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gloves : MonoBehaviour {

    public GameObject permukaan;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            // mengecek object yang dideteksi harus memiliki collider
            if (hit.collider)
            {

                // pastikan object yang dideteksi memiliki tag Monster
                if (hit.transform.tag.Equals("Monster"))
                {
                    hit.transform.GetComponent<RespondButton>().SetHit();

                    // ketika user menekan/klik tombol
                    if (OVRInput.GetDown(OVRInput.RawButton.A)|| Input.GetKeyDown(KeyCode.Space))
                    {
                        hit.transform.GetComponent<RespondButton>().SetAttack();
                    }
                }
            }
        }
    }
}
