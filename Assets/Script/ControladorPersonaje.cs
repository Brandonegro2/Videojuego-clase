using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D rigidbody;
    [SerializeField] Animator animator;
    [SerializeField] float alturaSalto = 500;
    void Start()
    {
        rigidbody=GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Comprobarsuelo.estaEnSuelo)
        {
            rigidbody.AddForce(Vector2.up * alturaSalto);
            animator.SetBool("Saltar", true);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemigo")
        {
            GameManager.Instancia.Perder();
        }
    }
}
