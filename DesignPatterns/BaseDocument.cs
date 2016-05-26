using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class BaseDocument : IDocument, ICloneable
    {

        public Dal dal { get; set; }

        public static BaseDocument LoadDocument(int id)
        {
            return new DocumentA();
        }

        public static void DeleteDocument(int id)
        {
            ;
        }


        public virtual void AddDocument(BaseDocument doc)
        {
            ;
        }
        public virtual void RemoveDocument(BaseDocument doc)
        {
            ;
        }

        public DocumentState State { get; set; }
        public DocumentsCoordinator Coordiantor { get; set; }
        public List<Employee> Owners { get; set; }

        public RenderingStrategy RenderingStrategy { get; set; }

        public int id { get; private set; }
        public string Name { get; set; }

        public virtual void Create()
        {
            NotifyObservers();
        }
        public abstract void Update();

        public DocumentMemento CreateMemento()
        {
            return new DocumentMemento() { Id = id, Name = Name };

        }
        public void StoreFromMemento(DocumentMemento memento)
        {
            id = memento.Id;
            Name = memento.Name;
        }
        public void Confirm()
        {
            State.Confirm();
        }

        protected void NotifyObservers()
        {
            foreach (var item in Owners)
            {
                item.ConfirmDocument(this);
            }
        }

        public void Render()
        {
            RenderingStrategy.Render();
        }

        public void Save()
        {
            if (id > 0)
                Update();
            else
                Create();
        }

        public void SendCoordinationAction()
        {
            Coordiantor.SendCoordinationAction(this);
        }

        public void ReceiveCoordinationAction(BaseDocument sender)
        {
            Console.WriteLine("received");
        }

        public abstract object Clone();
    }
}