using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerAnimationController : MonoBehaviour
{
    // Code like Me https://www.youtube.com/watch?v=p1_Om8viUJQ

    public Animator animator;
    private Player player;
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null)
        {
            Debug.LogWarning("No Animator Found");
            return;
        }

        animator.SetFloat( "Velocity", player.getVelocity() );
        Debug.Log(player.getVelocity());
        Emote();
    }

    void Emote()
    {
        if (Input.GetKeyDown(KeyCode.V))
            animator.Play("TwistDance");
        if (Input.GetKeyDown(KeyCode.V))
            audioSource.PlayOneShot(clip);
        if (Input.GetKeyUp(KeyCode.V))
            animator.Play("Blend Tree");
        if (Input.GetKeyUp(KeyCode.V))
            audioSource.Stop();
    }
}
