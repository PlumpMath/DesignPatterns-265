using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DocumentsCollection : IEnumerable<BaseDocument>
    {

        List<BaseDocument> documents = new List<BaseDocument>();


        public void Add(BaseDocument doc)
        {
            documents.Add(doc);
        }


        public void AcceptVisitor(IDocumentVisitor visitor)
        {
            foreach (var item in documents)
            {
                visitor.Visit(item);
            }
        }



        public DocumentCollectionEnumerator GetEnumerator()
        {
            return new DocumentCollectionEnumerator() { collection = documents };
        }

        IEnumerator<BaseDocument> IEnumerable<BaseDocument>.GetEnumerator()
        {
            return new DocumentCollectionEnumerator() { collection = documents };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


    public class DocumentCollectionEnumerator : IEnumerator<BaseDocument>
    {

        public List<BaseDocument> collection { get; set; }
        private int index;
        private BaseDocument currentDoc;



        public DocumentCollectionEnumerator()
        {
            index = -1;
            currentDoc = null;
        }

        public BaseDocument Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return currentDoc;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (++index >= collection.Count)
            {
                return false;
            }
            else
            {
                currentDoc = collection[index];
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
            currentDoc = null;
        }
    }


}
