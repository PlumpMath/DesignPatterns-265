using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();

    }



    public class LoadDocumentCommand : Command
    {
        public Application app { get; set; }
        public int Id { get; set; }

        public override void Execute()
        {
            app.loadedDocs.Add(BaseDocument.LoadDocument(Id));
        }

        public override void UnExecute()
        {
            //remove from the list
        }
    }


    public class DeleteDocumentCommand : Command
    {
        public Application app { get; set; }
        public int Id { get; set; }

        BaseDocument deletedDoc;

        public override void Execute()
        {
            deletedDoc = BaseDocument.LoadDocument(Id);
            BaseDocument.DeleteDocument(Id);
            //remove from the list
        }

        public override void UnExecute()
        {
            //create deletedDoc
            //add to list
        }
    }



    public class Application
    {
        Stack<Command> commands = new Stack<Command>();

        public List<BaseDocument> loadedDocs = new List<BaseDocument>();




        public void LoadDocument(int id)
        {
            LoadDocumentCommand cmd = new LoadDocumentCommand();
            cmd.app = this;
            cmd.Id = id;

            cmd.Execute();

            commands.Push(cmd);
        }



        public void DeleteDocument(int id)
        {
            DeleteDocumentCommand cmd = new DeleteDocumentCommand();
            cmd.app = this;
            cmd.Id = id;

            cmd.Execute();

            commands.Push(cmd);
        }

        public void Undo()
        {
            Command last = commands.Pop();
            last.UnExecute();

        }



    }

}
