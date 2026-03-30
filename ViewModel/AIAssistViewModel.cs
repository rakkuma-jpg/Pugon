using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using Syncfusion.Maui.AIAssistView;

namespace Pugon.ViewModel;

public class AIAssistViewModel : INotifyPropertyChanged
{

    /// <summary>
    /// Collection of messages in a conversation.
    /// </summary>
    private ObservableCollection<IAssistItem> assistItems;

    /// <summary>
    /// Gets or sets the collection of messages of a conversation.
    /// </summary>
    public ObservableCollection<IAssistItem> AssistItems
    {
        get
        {
            return this.assistItems;
        }

        set
        {
            this.assistItems = value;
        }
    }
    public AIAssistViewModel()
	{
        this.assistItems = new ObservableCollection<IAssistItem>();
    }

    #region PropertyChanged

    /// <summary>
    /// Property changed handler.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Occurs when property is changed.
    /// </summary>
    /// <param name="propName">changed property name</param>
    public void RaisePropertyChanged(string propName)
    {
        if (this.PropertyChanged != null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }

    #endregion
}