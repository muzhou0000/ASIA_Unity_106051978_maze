using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousemove : MonoBehaviour
{
    #region 數據
    [Header("速度"),Range(50,2000)]
    public float speed;
    [Header("旋轉"),Range(50, 200)]
    public float turn;
    public Rigidbody rig;
    public Transform Tra;
    public Animator ani;
    #endregion

    private void Start()
    {
        
    }
    private void Update()
    {
        Walk();
        Run();
        Attack();
    }

    #region 行動

    void Walk()
    {
        float v = Input.GetAxis("Vertical");
        rig.AddForce(Tra.forward * v * speed * Time.deltaTime);
        ani.SetBool("walk", v!=0); 
    }
    void Run()
    {
        float h = Input.GetAxis("Horizontal");
        Tra.Rotate(0,turn * h * Time.deltaTime,0);

    }
    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetBool("Attack",true);

        }
        else
        {
            ani.SetBool("Attack", false);

        }

    }

    #endregion
}