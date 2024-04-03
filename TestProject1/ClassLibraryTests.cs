namespace ClassLibraryTest
{
  public class ClassLibraryTests
  {
    [Fact]
    public void Do_Submodules_Rock()
    {
      var a = ClassLibrary.QuestionResolver.Answer;

      Assert.NotNull(a);
      Assert.IsType<int>(a);
      Assert.Equal(42, a);


    }
  }
}
