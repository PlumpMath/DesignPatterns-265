using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory_Method
{
    class FactoryMethod
    {
        IDocument currentDocument;
        Container c = new TextContainer();


        void OpenDocment()
        {
            c.CreateDocument();
            currentDocument = c.doc;
        } 

    }




    interface IDocument
    {

    }

    class TextDocument : IDocument
    {

    }


    class ImageDocument : IDocument
    {

    }



    abstract class Container
    {
        public IDocument doc { get; set; }

        public abstract void CreateDocument();
    }

    class TextContainer : Container
    {
        IDocument document;

        public override void CreateDocument()
        {
            document =  new TextDocument();
        }
    }

    class PictureContainer : Container
    {
        IDocument document;

        public override void CreateDocument()
        {
            document = new ImageDocument();
        }
    }


}
