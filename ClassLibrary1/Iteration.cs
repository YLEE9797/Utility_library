using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{

    //열거자 반복 클래스
    public class Iteration : IEnumerable
    {
        public int[] Input;
        public int StartInput;
        //Input 클래스 : Input 배열안에서 start 포인트 부터 시작
      
        //만든이유 : Input 신호 받아와서 그 신호 있는지 없는지 계속 체크할려고
        //만들어놨음
        public Iteration(int[]Input,int StartInput)
        {
            this.Input = Input;
            this.StartInput = StartInput;
        }

      //아직 미구현
      public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }


    //컬렉션 반복 클래스
    public class Enumeration_Iterator : IEnumerator
    {
        //지금 현재 위치가 벗어낫거나 순회 배열이 같을때 (예외처리)
        public object Current
        {
            get
            {
                if(posit ==-1 || posit == iter.Input.Length)
                {
                    throw new InvalidCastException();
                }
                int index = posit + iter.StartInput;
                index = index % iter.Input.Length;
                return iter.Input[index];
            }

        }
        Iteration iter;
        int posit=-1;
        private Enumeration_Iterator enumeration_Iterator;

        internal Enumeration_Iterator(Iteration iter)
        {
            this.iter = iter;
            posit = -1;
        }
        
        public Enumeration_Iterator(Enumeration_Iterator enumeration_Iterator)
        {
            this.enumeration_Iterator = enumeration_Iterator;
        }
        public bool MoveNext()
        {
            if (posit != iter.Input.Length)
            {
                posit++;
            }
            return posit < iter.Input.Length;
              
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumeration_Iterator(this);
        }

        public void Reset()
        {
            posit = -1;
            for(int i = 0; i < iter.Input.Length; i++)
            {
                iter.Input[i] = 0;
            }
        }
    }
}
