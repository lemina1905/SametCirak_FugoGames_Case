using UnityEngine;

public class ExecuteAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return)) 
        {
            animator.SetTrigger("_openChest");
            animator.ResetTrigger("_resetChest");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("_resetChest");
            animator.ResetTrigger("_openChest");
        }
    }

    
}
