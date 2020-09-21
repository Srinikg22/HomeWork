using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ObserverPattern
{

    // Observer Pattern - Create a dependency between objects so that one object changes its state other observers
    // are notified.
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new ConcreteSubject("ABC");

            subject.AttachRange(new List<Observer>
            {
                new ConcreteObserver("o1"),
                new ConcreteObserver("o2"),
                new ConcreteObserver("o3")
            });
   
            subject.SetState("XYZ");
            Console.ReadKey();
        }
    }

    abstract class Observer
    {
        public abstract void Update(string state);
    }

    abstract class Subject
    {
        protected string SubjectState;

        protected List<Observer> Observers = new List<Observer>();

        public virtual void Attach(Observer o)
        {
            Observers.Add(o);
        }

        public virtual void AttachRange(List<Observer> o)
        {
            Observers.AddRange(o);
        }

        public virtual void Dettach(Observer o)
        {
            Observers.Remove(o);
        }

        public abstract void SetState(string state);

        protected virtual void Notify()
        {
            Observers.ForEach(o => o.Update(this.SubjectState));
        }
    }

    class ConcreteSubject : Subject
    {
        private string Name;

        public ConcreteSubject(string state)
        {
            SetState(state);
        }

        public override void SetState(string state)
        {
            if (this.SubjectState != state)
            {
                this.SubjectState = state;
                Notify();
            }
        }
    }

    class ConcreteObserver : Observer
    {
        private string Name;

        public ConcreteObserver(string name)
        {
            this.Name = name;
        }

        public override void Update(string state)
        {
            Console.WriteLine($"Observer{Name} notified.New subject state: {state}");
        }
    }
}
