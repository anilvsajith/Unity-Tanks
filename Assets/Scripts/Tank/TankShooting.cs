using UnityEngine;
using UnityEngine.UI;

public class TankShooting : MonoBehaviour
{
    public int m_PlayerNumber = 1;       
    public Rigidbody m_Shell;            
//    public Transform m_FireTransform;    
//    public Slider m_AimSlider;           
//    public AudioSource m_ShootingAudio;  
//    public AudioClip m_ChargingClip;     
//    public AudioClip m_FireClip;         
//    public float m_MinLaunchForce = 15f; 
//    public float m_MaxLaunchForce = 30f; 
//    public float m_MaxChargeTime = 0.75f;
	private float starttime;
	private float timepressed;

    
    private string m_FireButton;         
//    private float m_CurrentLaunchForce;  
//    private float m_ChargeSpeed;         
//    private bool m_Fired;                


    private void OnEnable()
    {
 //       m_CurrentLaunchForce = m_MinLaunchForce;
//        m_AimSlider.value = m_MinLaunchForce;
    }


    private void Start()
    {
        m_FireButton = "Fire" + m_PlayerNumber;

       // m_ChargeSpeed = (m_MaxLaunchForce - m_MinLaunchForce) / m_MaxChargeTime;
    }
    

    private void Update()
    {
        // Track the current state of the fire button and make decisions based on the current launch force.
		if (Input.GetButtonDown (m_FireButton)) {
			starttime = Time.time;
		}
		if (Input.GetButtonUp (m_FireButton)) {
			timepressed = Time.time - starttime;
			timepressed = timepressed * 10;
			timepressed = Mathf.Max (timepressed, 2.0f);
			timepressed = Mathf.Min (timepressed, 4);
			//Insatiate a new bullet on this object (which will be our camera)
			Rigidbody m_Bullet = Instantiate (m_Shell, transform.position, transform.rotation) as Rigidbody;

			//Add force to the bullet to shoot it
			m_Bullet.AddForce (transform.forward * 500 * timepressed);
		}
    }


    private void Fire()
    {
        // Instantiate and launch the shell.
    }
}