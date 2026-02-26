using System;
using System.Runtime.Intrinsics.X86;

// README.md를 읽고 아래에 코드를 작성하세요.

Student student1 = new Student("김철수", 85,90,95);
Console.WriteLine($"=== 성적표: {student1.Name} ===");
Console.WriteLine($"국어: {student1.KoreanScore}, " +
    $"영어: {student1.EnglishScore}," +
    $"수학: {student1.MathScore}");
Console.WriteLine($"총점: {student1.TotalScore}");
Console.WriteLine($"평균: {student1.Average:F2}");
Console.WriteLine($"학점: {student1.Grade}");

Student student2 = new Student("이영희", 75, 80, 70);
Console.WriteLine($"=== 성적표: {student2.Name} ===");
Console.WriteLine($"국어: {student2.KoreanScore}, " +
    $"영어: {student2.EnglishScore}," +
    $"수학: {student2.MathScore}");
Console.WriteLine($"총점: {student2.TotalScore}");
Console.WriteLine($"평균: {student2.Average:F2}");
Console.WriteLine($"학점: {student2.Grade}");

Student student3 = new Student("박민수", 100, 100, 0);
Console.WriteLine($"=== 성적표: {student3.Name} ===");
Console.WriteLine($"국어: {student3.KoreanScore}, " +
    $"영어: {student3.EnglishScore}," +
    $"수학: {student3.MathScore}");
Console.WriteLine($"총점: {student3.TotalScore}");
Console.WriteLine($"평균: {student3.Average:F2}");
Console.WriteLine($"학점: {student3.Grade}");

class Student
{
    private string _name;
    private int _koreanScore;
    private int _englishScore;
    private int _mathScore;

    public Student(string name, int koreanScore, int englishScore, int mathScore)

    {
        _name = name;
        _koreanScore = koreanScore;
        _englishScore = englishScore;
        _mathScore = mathScore;
        
    }
    public string Name
    {
        get { return _name; } 
    }

    public int KoreanScore
    {
        get { return _koreanScore; }
        set {

            if (value < 0)
            {
                _koreanScore = 0;
            }
            else if (value > 100)
            {
                _koreanScore = 100;
            }
            else
                _koreanScore = value;

        }
    }
    public int EnglishScore
    {
        get { return _englishScore; }
        set
        {

            if (value < 0)
            {
                _englishScore = 0;
            }
            else if (value > 100)
            {
                _englishScore = 100;
            }
            else
                _englishScore = value;

        }
    }
    public int MathScore
    {
        get { return _mathScore; }
        set
        {

            if (value < 0)
            {
                _mathScore = 0;
            }
            else if (value > 100)
            {
                _mathScore = 100;
            }
            else
                _mathScore = value;
        }
    }

    public int TotalScore
    {
        get { return _koreanScore + _englishScore + _mathScore; }
    }

    public double Average
    {
        get { return (double)TotalScore / 3; }
    }

    public string Grade
    {
        get
        {
            if (Average >= 90)
            {
                return "A";

            }
            else if (Average >= 80)
            {
                return "B";
            }
            else if (Average >= 70)
            {
                return "C";
            }
            else if (Average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        
    }
}