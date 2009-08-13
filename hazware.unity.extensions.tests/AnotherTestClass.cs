using System;

namespace hazware.unity.extensions.tests
{
  public class AnotherTestClass : ITest
  {
    string _data;
    public string Data
    {
      get { return _data; }
      set { _data = value; }
    }

    /// <summary>
    /// Initializes a new instance of the AnotherTestClass class.
    /// </summary>
    public AnotherTestClass()
    {
    }
  }
}
