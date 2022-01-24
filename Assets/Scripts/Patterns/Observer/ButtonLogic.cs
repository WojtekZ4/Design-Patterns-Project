using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour, ISubject
{
    public List<Observer> observers = new List<Observer>();
    bool playerInside = false;
    bool State = false;
    public Sprite buttonOnState;
    public Sprite buttonOffState;
    public void Attach(Observer observer)
    {
        observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        observers.Remove(observer);
    }
    private void SwapState()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (State)
            sr.sprite = buttonOffState;
        else
            sr.sprite = buttonOnState;

        State = !State;
    }
    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.ObserverUpdate(this);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            playerInside = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {

            playerInside = false;
        }
    }
    private void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            SwapState();
            Notify();
        }
    }
}
