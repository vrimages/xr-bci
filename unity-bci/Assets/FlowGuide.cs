using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FlowGuide : MonoBehaviour
{
    public Animator panelAnim;
    public Animator textAnim;
    public TextMeshProUGUI text;

    public AudioSource ping;
    public AudioSource track1;
    public AudioSource track2;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;

    //public RectMask2D rect;
    public Animator rectAnim;
    public Animator naviAnim;
    public Animator canvasAnim;

    private bool gameStart = false;

    public GameObject circle1;

    public GameObject fireball;
    public Transform myHand;

    public AudioSource end;

    public GameObject canvas2;

    bool startEnd = true;

    public GameObject navi2;

    // Start is called before the first frame update
    void Start()
    {
        //Next5();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStart){
            if(OVRInput.GetDown(OVRInput.Button.One)){
                Debug.Log("yo!");
                GameObject thisBall = Instantiate(fireball, myHand.position, Quaternion.identity);
                //thisBall.GetComponent<Rigidbody>().AddForce(myHand.forward * 2.0f, ForceMode.Impulse);
                thisBall.GetComponent<Rigidbody>().velocity = myHand.forward * 5.0f;
                //thisBall.velocity = myHand.TransformDirection( Vector3( 0, 0, 2.0f) );
            }
            if(startEnd)
            {
                StartCoroutine(End());
                startEnd = false;
            }
            
        }
        
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(30f);
        gameStart = false;
        end.Play();
        track2.Pause();
        canvas2.SetActive(true);
        navi2.SetActive(true);
    }

    public void Next1(){
        textAnim.Play("text_fadeout");
        ping.Play();
        StartCoroutine(Co1());
        button1.SetActive(false);
        button2.SetActive(true);
        
    }
    IEnumerator Co1()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "Let's begin by training a mental command.";
        textAnim.Play("text_fadein");
    }

    public void Next2(){
        textAnim.Play("text_fadeout");
        ping.Play();
        StartCoroutine(Co2());
        button2.SetActive(false);
        button3.SetActive(true);
        
    }
    IEnumerator Co2()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "First, we need to record a neutral state of mind.";
        textAnim.Play("text_fadein");
        StartCoroutine(Co2_2());
    }
    IEnumerator Co2_2()
    {
        yield return new WaitForSeconds(3f);
        textAnim.Play("text_fadeout");
        StartCoroutine(Co2_3());
    }
    IEnumerator Co2_3()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "Please sit still, and take a breath in and out.";
        rectAnim.Play("rect_breathe");
        //rectAnim.Play("rect_fade");
        textAnim.Play("text_fadein");
        StartCoroutine(Co2_4());
    }
    IEnumerator Co2_4()
    {
        yield return new WaitForSeconds(5f);
        textAnim.Play("text_fadeout");
        rectAnim.Play("rect_fade");
        StartCoroutine(Co2_5());
    }
    IEnumerator Co2_5()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "Great! Next let's record a mental command.";
        textAnim.Play("text_fadein");
        //StartCoroutine(Co2_6());
    }


    public void Next3(){
        textAnim.Play("text_fadeout");
        ping.Play();
        StartCoroutine(Co2_7());
        button3.SetActive(false);
        button4.SetActive(true);
    }
    IEnumerator Co2_7()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "Please imagine an energy ball propelling out from one of your hands.";
        rectAnim.Play("rect_breathe");
        //rectAnim.Play("rect_fadein");
        textAnim.Play("text_fadein");
        StartCoroutine(Co2_8());
    }
    IEnumerator Co2_8()
    {
        yield return new WaitForSeconds(4f);
        textAnim.Play("text_fadeout");
        rectAnim.Play("rect_fade");
        StartCoroutine(Co2_9());
    }
    IEnumerator Co2_9()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "Alright! We're all set.";
        textAnim.Play("text_fadein");
    }


    public void Next4(){
        textAnim.Play("text_fadeout");
        ping.Play();
        StartCoroutine(Co3());
        button4.SetActive(false);
        button5.SetActive(true);
    }
    IEnumerator Co3()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "You can propel an energy ball out of your hand by imagining the mental command we just trained.";
        textAnim.Play("text_fadein");
        StartCoroutine(Co3_2());
    }
    IEnumerator Co3_2()
    {
        yield return new WaitForSeconds(5f);
        textAnim.Play("text_fadeout");
        StartCoroutine(Co3_3());
    }
    IEnumerator Co3_3()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "To score points, propel energy balls into as many rings as possible in 30 seconds.";
        textAnim.Play("text_fadein");
        StartCoroutine(Co3_4());
    }
    IEnumerator Co3_4()
    {
        yield return new WaitForSeconds(5f);
        textAnim.Play("text_fadeout");
        StartCoroutine(Co3_5());
    }
    IEnumerator Co3_5()
    {
        yield return new WaitForSeconds(0.5f);
        text.text = "That's it! Good luck :)";
        textAnim.Play("text_fadein");
    }

    public void Next5(){
        textAnim.Play("text_fadeout");
        ping.Play();
        naviAnim.Play("navi_shrink");
        canvasAnim.Play("canvas_fade");
        track1.Pause();
        track2.Play();
        gameStart = true;
        circle1.SetActive(true);
    }





}
