using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace numerator_interface
{
    
        class MedicalCard : IEnumerable
        {
            public string Heart { get; set; }
            public string Kidney { get; set; }
            public string Liver { get; set; }
        public IEnumerator<string> GetEnumerator()
        {
            yield return Heart;
            yield return Kidney;
            yield return Liver; 
            //return new Enumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        

        }
   
        class Enumerator : IEnumerator<string>
        {
            int index;
            public MedicalCard my_card;
        
        public void Dispose() { }
        public Enumerator(MedicalCard obj)
            {
                my_card = obj;
            }
            public string Current
            {
                get
                {
                    if (this.index == 0) { return my_card.Heart; }
                    else if (this.index == 1) { return my_card.Kidney; }
                    else if (this.index == 2) { return my_card.Liver; }
                    //throw new InvalidOperationException();
                    else return null;
                }
            }
        object IEnumerator.Current => throw new NotImplementedException();
        public bool MoveNext()
            {
                if (index > 2 || index < 0) { return false; }
                index++;
                return true;
            }
            public void Reset()
            {
                index = 0;
            }

        }
    
class Program
{
    static void Main(string[] args)
    {
        MedicalCard m1 = new MedicalCard { Heart = "zle", Kidney = "ok", Liver = "normas" };
            foreach (var i in m1)
            {
                Console.WriteLine(i);
            }
        }
}
}
