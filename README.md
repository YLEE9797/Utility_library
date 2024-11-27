# Utility Libary Ver 1.0
만든목적
- 공부 목적과 나중에 보기 위함
- 나중에 필요 할때 쓰기 위해서 만들었다(앞으로도 업데이트 할 예정)
- 공부 하면서 내가 쓰고 싶은 함수를 만들었습니다

## Utility 함수 클래스 정리
1. Compare.cs
2. ConvertType.cs
3. Equal.cs
4. Iteration.cs
5. Lamda.cs
6. LINQ.cs
7. Properties.cs
8. Stream.cs
9. Utility.cs

## 클래스 함수

### Compare.cs


- 알람타이머 함수 : 설정 된 시간보다 더 많이 지속 되면 CheckFlag 가 true 가 된다
```C#
    public static bool CompareDateTime<T>(double preViousTime,double SettingTime ,bool CheckFlag)
```
- 모델 비교 함수 : 모델의 두개를 제네릭 형식으로 비교해서 리턴 시킵니다
```C#

    //모델의 두개를 제네릭 형식으로 비교해서 리턴 시킵니다
   public static int CompareModel<T>(T firstModel, T secondModel)

    //int 형식의 모델 두 개체를 비교해서 있는지 없는지 비교 합니다
   public static int? CompareModel<T>(IComparer<T> comparer,T first,T second)
```

###