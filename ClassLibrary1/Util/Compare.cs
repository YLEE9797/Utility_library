﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    public class Compare
    {
        #region 알람 타이머
        //만약에 시계초가 설정시간 보다 지나면 CheckFlag 는 true 가 되고 아니면 false 상태로 있는다
        //사실 이거만든 이유가 제한 시간동안 초과 했을떄 알람치게 만들려고 이렇게 해놨음
        public static bool CompareDateTime<T>(double preViousTime,double SettingTime ,bool CheckFlag)
        {
            double pvTime;
            if (preViousTime > SettingTime)
                CheckFlag = true;
            else
                CheckFlag = false;
           
            return CheckFlag;
        }
        #endregion
        #region 모델 비교 함수
        //모델의 두개를 제네릭 형식으로 비교해서 리턴 시킵니다
        public static int CompareModel<T>(T firstModel, T secondModel)
        {
            return CompareModel(firstModel, secondModel);
        }
       //int 형식의 모델 두 개체를 비교해서 있는지 없는지 비교 합니다
        public static int? CompareModel<T>(IComparer<T> comparer,T first,T second)
        {
            int ret = comparer.Compare(first,  second);
            return ret == 0 ? new int?() : ret;
        }
        #endregion
        //데이터 정렬 row 1번 하고 2번하고 비교해서 만약에 앞에 값이 더크면
        //값이 치환된다
        public static void SortData(DataTable DT)
        {
            int Row1Value;
            int Row2Value;
            for(int i=0; i < DT.Rows.Count; i++)
            {
                //25
                Row1Value = int.Parse(DT.Rows[i][2].ToString());
                //22
                Row2Value = int.Parse(DT.Rows[i + 1][2].ToString());
                if (Row1Value>Row2Value)
                {
                    Row1Value= int.Parse(DT.Rows[i + 1][2].ToString());
                    Row2Value= int.Parse(DT.Rows[i][2].ToString());
                }
            }
        }
    }
}
