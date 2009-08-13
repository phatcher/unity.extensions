using System;

namespace hazware.unity.extensions.tests
{
  public class TestClass : ITest
  {
    string _data;
    public string Data
    {
      get { return _data; }
      set { _data = value; }
    }

    /// <summary>
    /// Initializes a new instance of the TestClass class.
    /// </summary>
    public TestClass()
    {
    }
  }
}
