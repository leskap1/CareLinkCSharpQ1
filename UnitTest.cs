using System;

public class UnitTest {

  public static void TestTwoSum () 
  {
    Console.WriteLine("Test TwoSum: Problem A");
    Example TestTarget = new Example();
    int[] sample = new int[] {1, 5, 19, 43, 58, 99};

    int[] answer = TestTarget.TwoSum(sample, 24);
    
    Assert(answer != null, "Answer should not be null.");
    Assert(answer.Length, 2, "Length should be 2.");
    Assert(answer[0], 1, "Index 0 should be 1.");
    Assert(answer[1], 2, "Index 1 should be 2.");
    Console.WriteLine();
  }

  public static void TestTwoSumB () 
  {
    Console.WriteLine("Test TwoSum: Problem B");
    Example TestTarget = new Example();
    int[] sample = new int[] {2, 7, 11, 15, 21};

    int[] answer = TestTarget.TwoSum(sample, 28);
    
    Assert(answer != null, "Answer should not be null.");
    Assert(answer.Length, 2, "Length should be 2.");
    Assert(answer[0], 1, "Index 0 should be 1.");
    Assert(answer[1], 4, "Index 1 should be 4.");
    Console.WriteLine();
  }

  public static void Assert(int value, int correctValue, string testcase) 
  {
      if (value == correctValue)
      {
         Console.WriteLine("Pass: " + testcase);
      }
      else
      {
         Console.WriteLine("Fail: " + testcase);
      }
  }

  public static void Assert(bool isTrue, string testcase) 
  {
      if (isTrue)
      {
         Console.WriteLine("Pass: " + testcase);
      }
      else
      {
         Console.WriteLine("Fail: " + testcase);
      }
  }
}