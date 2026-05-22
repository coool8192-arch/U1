using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public AnimatorStateInfo animatorStateInfo;

    public void Idle()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk", false);
        }
        else if (animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Attack", false);
        }

        animator.SetBool("Idle", true);
    }

    public void Walk()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Idle", false);
        }
        else if(animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Attack", false);
        }

        animator.SetBool("Walk",true);
    }

    public void Attack()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Idle", false);
        }
        else if (animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk", false);
        }

        animator.SetBool("Attack", true);
    }

    public void Die()
    {
        if (animatorStateInfo.IsName("Die") || animator.IsInTransition(0))
        {
            return;
        }
        animator.SetBool("Walk", false);
        animator.SetBool("Attack", false);
        animator.SetTrigger("Die");
    }
}
