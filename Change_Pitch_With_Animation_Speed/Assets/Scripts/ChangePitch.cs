using System;
using UnityEngine;

public class ChangePitch : MonoBehaviour
{

    public float accel = 0.05f;
    public float minSpeed = 0.0f;
    public float maxSpeed = 2.0f;
    public float animationSoundRatio = 1.0f;
    private float speed = 0.0f;
    private Animator animator;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        speed = animator.speed;
        AccelRocket(0f);
    }

    private void AccelRocket(float accel)
    {
        speed += accel;
        speed = Mathf.Clamp(speed, minSpeed, maxSpeed);
        animator.speed = speed = Mathf.Clamp(speed, 0, maxSpeed);
        var soundPitch = animator.speed * animationSoundRatio;
        audioSource.pitch = soundPitch;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
            AccelRocket(accel);
        if (Input.GetKey(KeyCode.Alpha2))
            AccelRocket(-accel);
    }
}
