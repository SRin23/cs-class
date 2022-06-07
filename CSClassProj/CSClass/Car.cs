using System;

namespace CSClass
{
    ///<summary>
    ///자동차 주차장 입차, 출차 시간 등을 저장하는 클래스 입니다.
    ///</summary>
    internal class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        ///<summary>
        ///무엇인가를 입력받고 출력합니다.
        ///</summary>
        ///<param name="any">입력받는 변수</param>
        ///<returns>반환되는 값(입력변수 * 10)</returns>
        public int some(int any)
        {
            return any * 10;
        }

        ///<summary>
        ///자동차 입차 시간을 지정합니다.
        ///</summary>
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        ///<summary>
        ///자동차 출차 시간을 지정합니다.
        ///</summary>
        public void SetOUtTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}