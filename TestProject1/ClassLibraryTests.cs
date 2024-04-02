namespace TestProject1
{
  public class ClassLibraryTests
  {
    [Fact]
    public void Submodule_Rocks()
    {
      var a = ClassLibrary.QuestionResolver.Answer;

      Assert.NotNull(a);
      Assert.IsType<int>(a);
      Assert.Equal(42, a);


    }
  }
}