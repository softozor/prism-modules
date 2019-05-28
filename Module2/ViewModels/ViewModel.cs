using Prism.Mvvm;

namespace Module2.ViewModels
{
  public class ViewModel : BindableBase
  {
    private string _message;
    public string Message
    {
      get { return _message; }
      set { SetProperty(ref _message, value); }
    }

    public ViewModel()
    {
      Message = "View from Prism Module 2";
    }
  }
}
